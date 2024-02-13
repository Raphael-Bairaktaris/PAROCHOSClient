using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Request model used for creating a delayed process code
    /// </summary>
    public class InvoiceDetailDelayedProcessCodeRequestModel
    {
        #region Public Properties

        /// <summary>
        /// In case of real time transmission failure, authenticated code must be included, 
        /// as it was provided at issue to mobile application
        /// </summary>
        [JsonProperty("delayedProcessCode")]
        public string? DelayedProcessCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceDetailDelayedProcessCodeRequestModel() : base()
        {

        }

        #endregion
    }
}