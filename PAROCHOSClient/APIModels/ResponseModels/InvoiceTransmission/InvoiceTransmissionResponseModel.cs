using Newtonsoft.Json;
using System;

namespace PAROCHOSClient
{
    /// <summary>
    /// Represents an invoice transmission response
    /// </summary>
    public class InvoiceTransmissionResponseModel : BasePAROCHOSResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ExternalSystemId"/> property
        /// </summary>
        private string? mExternalSystemId;

        /// <summary>
        /// The member of the <see cref="ProcessId"/> property
        /// </summary>
        private string? mProcessId;

        /// <summary>
        /// The member of the <see cref="Signing"/> property
        /// </summary>
        private InvoiceTransmissionSigningResponseModel? mSigning;

        #endregion

        #region Public Properties

        /// <summary>
        /// The external identifier provided to send method.
        /// </summary>
        [JsonProperty("externalSystemId")]
        public string ExternalSystemId
        {
            get => mExternalSystemId ?? string.Empty;
            set => mExternalSystemId = value;
        }

        /// <summary>
        /// The identifier of the invoice
        /// </summary>
        [JsonProperty("processId")]
        public string ProcessId
        {
            get => mProcessId ?? string.Empty;

            set => mProcessId = value;
        }

        /// <summary>
        /// The invoice transmission signing 
        /// </summary>
        [JsonProperty("signing")]
        public InvoiceTransmissionSigningResponseModel Signing
        {
            get => mSigning ??= new InvoiceTransmissionSigningResponseModel();
            set => mSigning = value;
        }

        /// <summary>
        /// The timestamp of invoice creation
        /// </summary>
        [JsonProperty("timeStamp")]
        public DateTime TimeStamp { get; set; }

        /// <summary>
        /// The error severity
        /// </summary>
        [JsonProperty("errorSeverity")]
        [JsonConverter(typeof(ErrorSeverityToIntJsonConverter))]
        public ErrorSeverity? ErrorSeverity { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceTransmissionResponseModel() : base()
        {
        }

        #endregion
    }
}
