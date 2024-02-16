using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// The base for all the PAROCHOS request models
    /// </summary>
    public class BasePAROCHOSRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Unique processId as returned by api/send. 
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
        public BasePAROCHOSRequestModel() : base()
        {

        }

        #endregion
    }
}
