using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// An agent that's capable of making requests to the PAROCHOS API
    /// </summary>
    public class PAROCHOSClient
    {
        #region Private Members

        /// <summary>
        /// The log in information provided by the <see cref="LogInAsync"/> method
        /// </summary>
        private LogInResponseModel? mLogInInformation;

        #endregion

        #region Public Properties

        /// <summary>
        /// The credentials
        /// </summary>
        public PAROCHOSCredentials Credentials { get; }

        /// <summary>
        /// The client
        /// </summary>
        public PAROCHOSWebRequestsClient Client { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PAROCHOSClient(PAROCHOSCredentials credentials) : base()
        {
            Credentials = credentials ?? throw new ArgumentNullException(nameof(credentials));

            Client = new();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Executes a log in operation and returns credentials that can be used for accessing the rest end points
        /// </summary>
        /// <returns></returns>
        public async Task<WebRequestResult<LogInResponseModel>> LogInAsync()
        {
            var response = await Client.PostAsync<LogInResponseModel>(Routes.LoginRoute, new LogInRequestModel() { Email = Credentials.Email, Password = Credentials.Password, SubscriptionKey = Credentials.SubscriptionKey }, null);

            if (!response.IsSuccessful)
                return response;

            mLogInInformation = response.Result;

            return response;
        }

        /// <summary>
        /// Executes a refresh operation using the <see cref="RefreshRequestModel.RefreshToken"/> to retrieve a new
        /// <see cref="RefreshResponseModel.JWT"/> and a new <see cref="RefreshResponseModel.JWTRefreshToken"/>
        /// </summary>
        /// <returns></returns>
        public async Task<WebRequestResult<RefreshResponseModel>> RefreshTokenAsync()
        {
            if (mLogInInformation is null)
            {
                var logInResponse = await LogInAsync();

                if (!logInResponse.IsSuccessful)
                    return logInResponse.ToUnsuccessfulWebRequestResult<RefreshResponseModel>();

                return logInResponse.ToSuccessfulWebRequestResult(x => (RefreshResponseModel)x);
            }

            var response = await Client.PostAsync<RefreshResponseModel>(Routes.RefreshTokenRoute, new RefreshRequestModel()
            {
                RefreshToken = mLogInInformation.JWTRefreshToken,
                Token = mLogInInformation.JWT
            }, null);

            if (!response.IsSuccessful)
                return response;

            mLogInInformation.JWT = response.Result.JWT;
            mLogInInformation.JWTExpiration = response.Result.JWTExpiration;

            mLogInInformation.JWTRefreshToken = response.Result.JWTRefreshToken;
            mLogInInformation.JWTRefreshTokenExpiration = response.Result.JWTRefreshTokenExpiration;

            return response;
        }

        #region Invoices

        /// <summary>
        /// Sends the specified <paramref name="model"/>
        /// </summary>
        /// <param name="model">The model</param>
        /// <param name="transmissionType">Resolves the required type of transmission.</param>
        /// <param name="numberOfRetries">
        /// The number of periodic retries for the polling operations. If this is set to 0
        /// then no polling operation is executed.
        /// </param>
        /// <returns></returns>
        public async Task<WebRequestResult<InvoiceTransmissionResponseModel>> SendIncomeInvoiceAsync(IncomeInvoiceRequestModel model, TransmissionType transmissionType = TransmissionType.TransmitInvoice, int numberOfRetries = 10)
        {
            return await ExecuteAsync(
                async x =>
                {
                    var externalSystemId = Guid.NewGuid().ToString();

                    // Send the invoice to the API
                    var transmissionResponse = await Client.PostAsync<InvoiceTransmissionResponseModel>(
                        Routes.GetInvoiceTransmissionRoute(x.URL1?.ToString()),
                        new InvoiceTransmissionRequestModel<InvoiceWrapperRequestModel<IncomeInvoiceRequestModel>>()
                        {
                            ExternalSystemId = externalSystemId,
                            Source = new InvoiceWrapperRequestModel<IncomeInvoiceRequestModel>()
                            {
                                Invoice = model
                            },
                            TransmissionType = transmissionType,
                        },
                        x.JWT);

                    // If there was an error...
                    if (!transmissionResponse.IsSuccessful)
                        // Return
                        return transmissionResponse;

                    // If the API has already processed our request...
                    if (transmissionResponse.Result.Status != StatusType.InProgress)
                        // Return
                        return transmissionResponse;

                    // If we should execute a polling process...
                    if (numberOfRetries == 0)
                        // Return
                        return transmissionResponse;

                    // Execute the polling process
                    return await PollingProcessAsync(
                        new PollingProcessRequestModel()
                        {
                            ExternalSystemId = externalSystemId,
                            ProcessId = transmissionResponse.Result.ProcessId
                        }, numberOfRetries);
                });
        }

        /// <summary>
        /// Executes a periodically a process that is used for checking the status of a request
        /// created by the <see cref="SendIncomeInvoiceAsync(IncomeInvoiceRequestModel, TransmissionType, int)"/>
        /// method
        /// </summary>
        /// <param name="model">The model</param>
        /// <param name="numberOfRetries">The number of the periodic retries</param>
        /// <returns></returns>
        public async Task<WebRequestResult<InvoiceTransmissionResponseModel>> PollingProcessAsync(PollingProcessRequestModel model, int numberOfRetries = 10)
        {
            WebRequestResult<InvoiceTransmissionResponseModel>? result = null;

            var retriesCounter = 0;

            // If a request hasn't been made, or we have reached the API and the API has informed us that the operation is in process...
            while (result is null || (result.IsSuccessful && result.Result.Status == StatusType.InProgress))
            {
                // Attempt to get the information related to our transmitted invoice
                result = await ExecuteAsync(
                    x => Client.PostAsync<InvoiceTransmissionResponseModel>(
                        Routes.GetPollingProcessRoute(x.URL1?.ToString()),
                        model,
                        x.JWT));

                // If we reached the API and the API has informed us that the operation is in process 
                if (result.IsSuccessful && result.Result.Status == StatusType.InProgress)
                    // Give some time for the API to process our operation
                    await Task.Delay(TimeSpan.FromSeconds(0.5));

                // Increase the counter
                retriesCounter++;

                // If we have reached the maximum number of retries
                if (retriesCounter == numberOfRetries)
                    // Break
                    break;
            }

            return result;
        }

        /// <summary>
        /// Uploads the specified <paramref name="pdfFile"/> to the Azure storage
        /// </summary>
        /// <param name="model">The model</param>
        /// <param name="pdfFile">The PDF file</param>
        /// <returns></returns>
        public async Task<WebRequestResult<UploadFileRequestResponseModel>> UploadPDFFileAsync(UploadFileRequestRequestModel model, byte[] pdfFile)
        {
            return await ExecuteAsync<UploadFileRequestResponseModel>(
                async x =>
                {
                    // Update the length of the file
                    model.FileSize = pdfFile.Length;

                    // Create an upload request
                    var uploadFileRequestResult = await Client.PostAsync<UploadFileRequestResponseModel>(
                        Routes.GetUploadFileRequestRoute(x.URL1?.ToString()),
                        model,
                        x.JWT);

                    // If there was an error...
                    if (!uploadFileRequestResult.IsSuccessful)
                        // Return
                        return uploadFileRequestResult;

                    // If there is an internal error...
                    if (!uploadFileRequestResult.Result.IsSuccessful())
                        // Return
                        return uploadFileRequestResult.ToUnsuccessfulWebRequestResult<UploadFileRequestResponseModel>(uploadFileRequestResult.Result.ErrorMessage);

                    // Upload the file to Azure
                    var uploadFileToAzureResponse = await Client.PutFileToAzureAsync(uploadFileRequestResult.Result.UploadUrl!.ToString(), pdfFile);

                    // If there was an error...
                    if (!uploadFileToAzureResponse.IsSuccessful)
                        // Return
                        return uploadFileToAzureResponse.ToUnsuccessfulWebRequestResult<UploadFileRequestResponseModel>();

                    // Verify the upload
                    var uploadVerificationResponse = await Client.PostAsync<FinalizeResponseModel>(Routes.GetFinalizeRoute(x.URL1?.ToString()), new FinalizeRequestModel()
                    {
                        ExternalSystemId = model.ExternalSystemId,
                        ProcessId = model.ProcessId,
                    }, x.JWT);

                    // If there was an error...
                    if (!uploadVerificationResponse.IsSuccessful)
                        // Return
                        return uploadVerificationResponse.ToUnsuccessfulWebRequestResult<UploadFileRequestResponseModel>();

                    // If there is an internal error...
                    if (!uploadVerificationResponse.Result.IsSuccessful())
                        // Return
                        return uploadVerificationResponse.ToUnsuccessfulWebRequestResult<UploadFileRequestResponseModel>(uploadVerificationResponse.Result.ErrorMessage);

                    // Return
                    return uploadFileRequestResult;
                });
        }

        /// <summary>
        /// Executes a finalization action that is used for ensuring that the PDF file of an invoice
        /// has been successfully uploaded to the Azure storage
        /// </summary>
        /// <param name="model">The model</param>
        /// <returns></returns>
        public async Task<WebRequestResult<FinalizeResponseModel>> FinalizeAsync(FinalizeRequestModel model)
        {
            return await ExecuteAsync<FinalizeResponseModel>(
                async x => await Client.PostAsync<FinalizeResponseModel>(Routes.GetFinalizeRoute(x.URL1?.ToString()), model, x.JWT));
        }

        /// <summary>
        /// Gets all the files that were transmitted
        /// </summary>
        /// <param name="model">The model</param>
        /// <remarks>
        /// The request returns download urls of the PDF 
        /// uploaded by the client, together with the actual XML file transmitted to Tax Authorities' and 
        /// the e-Invoice for PEPPOL
        /// </remarks>
        /// <returns></returns>
        public async Task<WebRequestResult<FilesResponseModel>> GetFilesAsync(FilesRequestModel model)
        {
            return await ExecuteAsync<FilesResponseModel>(
                async x => await Client.PostAsync<FilesResponseModel>(Routes.GetFilesRoute(x.URL1?.ToString()), model, x.JWT));
        }

        /// <summary>
        /// Gets the publish logs
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// When the invoice publish type is B2G (2) and the whole process has been successfully 
        /// completed, the client can download all the logs of the publish process, at any time.The
        /// request returns a response status success indicator, together with a list of publish logs.
        /// </remarks>
        public async Task<WebRequestResult<PublishLogsResponseModel>> GetPublishLogsAsync(PublishLogsRequestModel model)
        {
            return await ExecuteAsync<PublishLogsResponseModel>(
                async x => await Client.PostAsync<PublishLogsResponseModel>(Routes.GetPublishLogsRoute(x.URL1?.ToString()), model, x.JWT));
        }

        #endregion

        #region EFT-POS Payments

        /// <summary>
        /// Begins the process of registering a payment to an already transmitted invoice
        /// </summary>
        /// <param name="model">The model</param>
        /// <returns></returns>
        public async Task<WebRequestResult<RequestPaymentResponseModel>> RequestPaymentAsync(RequestPaymentRequestModel model)
        {
            return await ExecuteAsync<RequestPaymentResponseModel>(
                async x =>
                {
                    if (model.ExternalSystemId.IsNullOrEmpty())
                    {
                        var externalSystemId = Guid.NewGuid().ToString();

                        model.ExternalSystemId = externalSystemId;
                    }

                    return await Client.PostAsync<RequestPaymentResponseModel>(
                        Routes.GetRequestPaymentRoute(x.URL1?.ToString()),
                        model,
                        x.JWT);
                });
        }

        /// <summary>
        /// Submitting / verifying a payment request generated by the <see cref="RequestPaymentAsync(RequestPaymentRequestModel)"/> method
        /// </summary>
        /// <param name="model">The model</param>
        /// <returns></returns>
        public async Task<WebRequestResult<SubmitPaymentResponseModel>> SubmitPaymentAsync(SubmitPaymentRequestModel model)
        {
            return await ExecuteAsync<SubmitPaymentResponseModel>(
                async x =>
                {
                    return await Client.PostAsync<SubmitPaymentResponseModel>(
                        Routes.GetSubmitPaymentRoute(x.URL1?.ToString()),
                        model,
                        x.JWT);
                });
        }

        /// <summary>
        /// Canceling a payment request generated by the <see cref="RequestPaymentAsync(RequestPaymentRequestModel)"/> method
        /// </summary>
        /// <param name="model">The model</param>
        /// <returns></returns>
        public async Task<WebRequestResult<CancelPaymentResponseModel>> CancelPaymentAsync(CancelPaymentRequestModel model)
        {
            return await ExecuteAsync<CancelPaymentResponseModel>(
                async x =>
                {
                    return await Client.PostAsync<CancelPaymentResponseModel>(
                        Routes.GetCancelPaymentRoute(x.URL1?.ToString()),
                        model,
                        x.JWT);
                });
        }

        /// <summary>
        /// Gets the payments
        /// </summary>
        /// <param name="externalSystemId">The external identifier provided as input to api/send method</param>
        /// <returns></returns>
        public async Task<WebRequestResult<PaymentResponseModel>> GetPaymentsAsync(string externalSystemId)
            => await ExecuteAsync<PaymentResponseModel>(
                async x =>
                {
                    return await Client.GetAsync<PaymentResponseModel>(
                        Routes.GetPaymentsRoute(x.URL1?.ToString(), externalSystemId),
                        x.JWT);
                });

        #endregion

        #endregion

        #region Private Methods

        /// <summary>
        /// Executes the specified <paramref name="action"/> after ensuring that a valid JWT has been retrieved.
        /// </summary>
        /// <typeparam name="T">The type of the result.</typeparam>
        /// <param name="action">The action.</param>
        /// <returns></returns>
        private async Task<WebRequestResult<T>> ExecuteAsync<T>(Func<LogInResponseModel, Task<WebRequestResult<T>>> action)
            where T : BasePAROCHOSResponseModel
        {
            LogInResponseModel info;

            // If we should update the log in information...
            if (ShouldUpdateLogInInformation())
            {
                // Refresh the log in information and get a brand new JWT
                var refreshResult = await UpdateLogInInformationAsync();

                // If there was an error...
                if (!refreshResult.IsSuccessful)
                    // Return
                    return refreshResult.ToUnsuccessfulWebRequestResult<T>();

                info = refreshResult.Result;
            }
            // Else...
            else
                // We already have a valid JWT
                info = mLogInInformation;

            // Execute the action
            var result = await action(info);

            // If there was an error...
            if (!result.IsSuccessful)
                // Return
                return result;

            // NOTE: The response body might contain error messages, show we should check them...
            if (!result.Result.IsSuccessful())
                return result.ToUnsuccessfulWebRequestResult<T>(result.Result.ErrorMessage);

            // Return
            return result;
        }

        /// <summary>
        /// Returns a flag indicating whether the log in information should be updated or not
        /// </summary>
        /// <returns></returns>
        [MemberNotNullWhen(false, nameof(mLogInInformation))]
        private bool ShouldUpdateLogInInformation() => mLogInInformation is null || mLogInInformation.JWTExpiration < DateTime.Now;

        /// <summary>
        /// Updates the <see cref="mLogInInformation"/>
        /// </summary>
        /// <returns></returns>
        private async Task<WebRequestResult<LogInResponseModel>> UpdateLogInInformationAsync()
        {
            // If we have previously logged in and we have a refresh token that hasn't expired...
            if (mLogInInformation is not null && mLogInInformation.JWTRefreshTokenExpiration > DateTime.Now)
            {
                // Refresh the token
                var refreshResult = await RefreshTokenAsync();

                // If there wasn't an error...
                if (refreshResult.IsSuccessful)
                    // Return the log in information that has now been updated by the RefreshTokenAsync method
                    return refreshResult.ToSuccessfulWebRequestResult(x => mLogInInformation);

                // NOTE: We shouldn't return and attempt to get a new JWT by logging in!
                mLogInInformation = null;
            }

            // Attempt to log in and retrieve a new token
            return await LogInAsync();
        }

        #endregion
    }
}
