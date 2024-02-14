namespace PAROCHOSClient
{
    /// <summary>
    /// 
    /// </summary>
    public class PAROCHOSAPIRoutes
    {
        public const string BaseRoute = "https://account.parochos.gr/api";

        public const string LoginRoute = $"{BaseRoute}/account/loginToSubscription";

        public const string RefreshTokenRoute = $"{BaseRoute}/token/refresh";

        public static string GetInvoiceTransmissionRoute(string baseUrl) => $"{baseUrl}/send";

        public static string GetPollingProcessRoute(string baseUrl) => $"{baseUrl}/get";

        public static string GetAccessToAzureStorageRoute(string baseUrl) => $"{baseUrl}/uploadFileRequest";

        public static string GetVerifyUploadToAzureStorageRoute(string baseUrl) => $"{baseUrl}/Finalize";

        public static string GetDownloadFilesRoute(string baseUrl) => $"{baseUrl}/getFiles";

        public static string GetDownloadPublishLogsRoute(string baseUrl) => $"{baseUrl}/GetPublishLogs";
    }
}
