namespace PAROCHOSClient
{
    /// <summary>
    /// The API Routes for PAROCHOS Client
    /// </summary>
    public class Routes
    {
        /// <summary>
        /// The base route
        /// </summary>
        public const string BaseRoute = "https://account.parochos.gr/api";

        /// <summary>
        /// The login to subscription
        /// </summary>
        public const string LoginRoute = $"{BaseRoute}/account/loginToSubscription";

        /// <summary>
        /// The refresh token
        /// </summary>
        public const string RefreshTokenRoute = $"{BaseRoute}/token/refresh";

        /// <summary>
        /// The invoice transmission route
        /// </summary>
        /// <param name="baseUrl">The base URL</param>
        /// <returns></returns>
        public static string GetInvoiceTransmissionRoute(string? baseUrl) => $"{baseUrl}/send";

        /// <summary>
        /// The polling process route
        /// </summary>
        /// <param name="baseUrl">The base URL</param>
        /// <returns></returns>
        public static string GetPollingProcessRoute(string? baseUrl) => $"{baseUrl}/get";

        /// <summary>
        /// The upload file request route
        /// </summary>
        /// <param name="baseUrl">The base URL</param>
        /// <returns></returns>
        public static string GetUploadFileRequestRoute(string? baseUrl) => $"{baseUrl}/uploadFileRequest";

        /// <summary>
        /// The finalize route
        /// </summary>
        /// <param name="baseUrl">The base URL</param>
        /// <returns></returns>
        public static string GetFinalizeRoute(string? baseUrl) => $"{baseUrl}/Finalize";

        /// <summary>
        /// The files route
        /// </summary>
        /// <param name="baseUrl">The base URL</param>
        /// <returns></returns>
        public static string GetFilesRoute(string? baseUrl) => $"{baseUrl}/getFiles";

        /// <summary>
        /// The publish logs route
        /// </summary>
        /// <param name="baseUrl">The base URL</param>
        /// <returns></returns>
        public static string GetPublishLogsRoute(string? baseUrl) => $"{baseUrl}/GetPublishLogs";

        /// <summary>
        /// The request payment route
        /// </summary>
        /// <param name="baseUrl">The base URL</param>
        /// <returns></returns>
        public static string GetRequestPaymentAPIRoute(string? baseUrl) => $"{baseUrl}/RequestPayment";

        /// <summary>
        /// The submit payment route
        /// </summary>
        /// <param name="baseUrl">The base URL</param>
        /// <returns></returns>
        public static string GetSubmitPaymentAPIRoute(string? baseUrl) => $"{baseUrl}/SubmitPayment";

        /// <summary>
        /// The cancel payment route
        /// </summary>
        /// <param name="baseUrl">The base URL</param>
        /// <returns></returns>
        public static string GetCancelPaymentAPIRoute(string? baseUrl) => $"{baseUrl}/CancelPayment";
    }
}
