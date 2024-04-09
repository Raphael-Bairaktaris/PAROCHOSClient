using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
        public static string GetInvoiceTransmissionRoute(string? baseUrl) => Combine(baseUrl, "send");

        /// <summary>
        /// The polling process route
        /// </summary>
        /// <param name="baseUrl">The base URL</param>
        /// <returns></returns>
        public static string GetPollingProcessRoute(string? baseUrl) => Combine(baseUrl, "get");

        /// <summary>
        /// The upload file request route
        /// </summary>
        /// <param name="baseUrl">The base URL</param>
        /// <returns></returns>
        public static string GetUploadFileRequestRoute(string? baseUrl) => Combine(baseUrl, "uploadFileRequest");

        /// <summary>
        /// The finalize route
        /// </summary>
        /// <param name="baseUrl">The base URL</param>
        /// <returns></returns>
        public static string GetFinalizeRoute(string? baseUrl) => Combine(baseUrl, "Finalize");

        /// <summary>
        /// The files route
        /// </summary>
        /// <param name="baseUrl">The base URL</param>
        /// <returns></returns>
        public static string GetFilesRoute(string? baseUrl) => Combine(baseUrl, "getFiles");

        /// <summary>
        /// The publish logs route
        /// </summary>
        /// <param name="baseUrl">The base URL</param>
        /// <returns></returns>
        public static string GetPublishLogsRoute(string? baseUrl) => Combine(baseUrl, "GetPublishLogs");

        /// <summary>
        /// The payments route
        /// </summary>
        /// <param name="baseUrl">The base URL</param>
        /// <param name="externalSystemId">The external identifier provided as input to api/send method</param>
        /// <returns></returns>
        public static string GetPaymentsRoute(string? baseUrl, string? externalSystemId) => Combine(baseUrl, "GetPayments", externalSystemId);

        /// <summary>
        /// The request payment route
        /// </summary>
        /// <param name="baseUrl">The base URL</param>
        /// <returns></returns>
        public static string GetRequestPaymentRoute(string? baseUrl) => Combine(baseUrl, "RequestPayment");

        /// <summary>
        /// The submit payment route
        /// </summary>
        /// <param name="baseUrl">The base URL</param>
        /// <returns></returns>
        public static string GetSubmitPaymentRoute(string? baseUrl) => Combine(baseUrl, "SubmitPayment");

        /// <summary>
        /// The cancel payment route
        /// </summary>
        /// <param name="baseUrl">The base URL</param>
        /// <returns></returns>
        public static string GetCancelPaymentRoute(string? baseUrl) => Combine(baseUrl, "CancelPayment");

        /// <summary>
        /// Combines the specified <paramref name="parts"/> while ensuring a correct URL structure
        /// </summary>
        /// <returns></returns>
        public static string Combine(params string?[] parts)
        {
            var urlParts = parts
                .Where(x => !string.IsNullOrEmpty(x))
                .Select(x => x!.Trim('/'));

            return string.Join("/", urlParts);
        }
    }
}
