using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Requests used for creating an invoice transmission
    /// </summary>
    public class InvoiceTransmissionAttachmentRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The content
        /// </summary>
        [JsonProperty("content")]
        public string? Content { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceTransmissionAttachmentRequestModel() : base()
        {

        }

        #endregion
    }
}