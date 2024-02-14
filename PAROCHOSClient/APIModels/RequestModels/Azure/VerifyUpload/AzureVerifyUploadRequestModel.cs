using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// Requests used for upload verification
    /// </summary>
    public class AzureVerifyUploadRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Unique processId as returned by api/send
        /// </summary>
        [JsonProperty("processId")]
        public string? ProcessId { get; set; }

        /// <summary>
        /// The external identifier provided as input to api/send method
        /// </summary>
        [JsonProperty("externalSystemId")]
        public string? ExternalSystemId { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AzureVerifyUploadRequestModel() : base()
        {

        }

        #endregion
    }
}
