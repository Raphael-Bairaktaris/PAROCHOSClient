using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Represents an invoice transmission attachment
    /// </summary>
    public class InvoiceTransmissionAttachmentResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The member of the <see cref="Identifier"/> property
        /// </summary>
        private string? mIdentifier;

        /// <summary>
        /// The member of the <see cref="ErrorMessage"/> property
        /// </summary>
        private string? mErrorMessage;

        #endregion

        #region Public Properties

        /// <summary>
        /// The identifier
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier
        {
            get => mIdentifier ?? string.Empty;
            set => mIdentifier = value;
        }

        /// <summary>
        /// The instance number
        /// </summary>
        [JsonProperty("instanceNumber")]
        public int InstanceNumber { get; set; }

        /// <summary>
        /// The status
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StatusTypeToIntJsonConverter))]
        public StatusType Status { get; set; }

        /// <summary>
        /// The error message
        /// </summary>
        [JsonProperty("errorMessage")]
        public string ErrorMessage
        {
            get => mErrorMessage ?? string.Empty;
            set => mErrorMessage = value;
        }

        /// <summary>
        /// A flag indicating whether the url should be uploaded
        /// </summary>
        [JsonProperty("uploadUrl")]
        public bool ShouldUploadURL { get; set; }

        /// <summary>
        /// A flag indicating whether the url should be downloaded 
        /// </summary>
        [JsonProperty("downloadUrl")]
        public bool ShouldDownloadURL { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceTransmissionAttachmentResponseModel() : base()
        {

        }

        #endregion
    }
}