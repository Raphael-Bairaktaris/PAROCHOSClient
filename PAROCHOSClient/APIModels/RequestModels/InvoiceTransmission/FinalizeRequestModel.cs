using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Request model that is used for verifying an Azure file upload
    /// </summary>
    public class FinalizeRequestModel
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
        public FinalizeRequestModel() : base()
        {

        }

        #endregion
    }
}
