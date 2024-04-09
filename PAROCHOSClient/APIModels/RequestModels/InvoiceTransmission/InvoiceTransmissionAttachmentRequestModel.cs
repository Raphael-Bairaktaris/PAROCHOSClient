using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Request model used for creating an invoice transmission
    /// </summary>
    public class InvoiceTransmissionAttachmentRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The identifier
        /// </summary>
        [JsonProperty("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        /// The file name
        /// </summary>
        [JsonProperty("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        /// The file size
        /// </summary>
        [JsonProperty("fileSize")]
        public double? FileSize { get; set; }

        /// <summary>
        /// The content
        /// </summary>
        [JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The instance number
        /// </summary>
        [JsonProperty("instanceNumber")]
        public int? InstanceNumber { get; set; }

        /// <summary>
        /// The document id
        /// </summary>
        /// <example>3fa85f64-5717-4562-b3fc-2c963f66afa6</example>
        [JsonProperty("documentId")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// The document external id
        /// </summary>
        [JsonProperty("documentExternalId")]
        public string? DocumentExternalId { get; set; }

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