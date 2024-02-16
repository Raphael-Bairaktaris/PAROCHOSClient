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

        public static string GetInvoiceTransmissionRoute(string? baseUrl) => $"{baseUrl}api/send";

        public static string GetPollingProcessRoute(string? baseUrl) => $"{baseUrl}api/get";

        public static string GetUploadFileRequestRoute(string? baseUrl) => $"{baseUrl}api/uploadFileRequest";

        public static string GetFinalizeRoute(string? baseUrl) => $"{baseUrl}api/Finalize";

        public static string GetDownloadFilesRoute(string? baseUrl) => $"{baseUrl}api/getFiles";

        public static string GetDownloadPublishLogsRoute(string? baseUrl) => $"{baseUrl}api/GetPublishLogs";
    }
}
