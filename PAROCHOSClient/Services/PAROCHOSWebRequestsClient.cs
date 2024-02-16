using Newtonsoft.Json;

using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="WebRequestsClient"/> configured for making calls to the PAROCHOS API
    /// </summary>
    public class PAROCHOSWebRequestsClient : WebRequestsClient
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PAROCHOSWebRequestsClient() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Uploads the specified <paramref name="content"/> at the specified Azure <paramref name="url"/>
        /// </summary>
        /// <param name="url">The Azure URL with write privileges (SAS)</param>
        /// <param name="content">The content</param>
        /// <returns></returns>
        public async Task<WebRequestResult> PutFileToAzureAsync(string url, byte[] content)
        {
            try
            {
                var httpContent = new ByteArrayContent(content);

                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/pdf");
                httpContent.Headers.Add("x-ms-blob-type", "BlockBlob");

                Client.DefaultRequestHeaders.Authorization = null;

                return await (await Client.PutAsync(url, httpContent)).CreateWebRequestResultAsync();
            }
            catch (Exception ex)
            {
                return ex;
            }

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override string Serialize(object obj)
        {
            var result = JsonConvert.SerializeObject(obj, new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore,
            });

#if DEBUG
            Debug.WriteLine(result);
#endif

            return result;
        }

        #endregion
    }
}
