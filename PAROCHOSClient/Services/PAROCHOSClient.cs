using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// 
    /// </summary>
    public class PAROCHOSClient
    {
        #region Private Members

        private string? mJWToken;

        private Uri? mBaseURL;

        #endregion

        #region Public Properties

        /// <summary>
        /// The credentials
        /// </summary>
        public PAROCHOSCredentials Credentials { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PAROCHOSClient(PAROCHOSCredentials credentials) : base()
        {
            Credentials = credentials ?? throw new ArgumentNullException(nameof(credentials));
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Executes a log in operation and returns credentials that can be used for accessing the rest end points
        /// </summary>
        /// <returns></returns>
        public async Task<WebRequestResult<LoginResponseModel>> LogInAsync()
        {
            var response = await WebRequestsClient.Instance.PostAsync<LoginResponseModel>(PAROCHOSAPIRoutes.LoginRoute, new LoginRequestModel() { Email = Credentials.Email, Password = Credentials.Password, SubscriptionKey = Credentials.SubscriptionKey }, null);

            if (!response.IsSuccessful)
                return response;


            mJWToken = response.Result.JWT;
            mBaseURL = response.Result.URL1;

            return response;
        }

        /// <summary>
        /// Executes a refresh operation using the <see cref="RefreshRequestModel.RefreshToken"/> to retrieve a new
        /// <see cref="RefreshResponseModel.JWT"/> and a new <see cref="RefreshResponseModel.JWTRefreshToken"/>
        /// </summary>
        /// <param name="model">The model</param>
        /// <returns></returns>
        public Task<WebRequestResult<RefreshResponseModel>> RefreshTokenAsync(RefreshRequestModel model)
            => WebRequestsClient.Instance.PostAsync<RefreshResponseModel>(PAROCHOSAPIRoutes.RefreshTokenRoute, model, null);

        #endregion

        #region Private Methods



        #endregion
    }
}
