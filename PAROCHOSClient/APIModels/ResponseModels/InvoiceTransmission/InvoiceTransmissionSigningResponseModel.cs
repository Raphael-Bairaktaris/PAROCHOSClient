using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PAROCHOSClient
{
    /// <summary>
    /// Represents an invoice transmission signing response
    /// </summary>
    public class InvoiceTransmissionSigningResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="UId"/> property
        /// </summary>
        private string? mUId;

        /// <summary>
        /// the member of the <see cref="AuthenticationCode"/> property
        /// </summary>
        private string? mAuthenticationCode;

        /// <summary>
        /// The member of the <see cref="QRCode"/> property
        /// </summary>
        private string? mQRCode;

        /// <summary>
        /// The member of the <see cref="PaymentTokens"/> property
        /// </summary>
        private IEnumerable<PaymentTokenResponseModel>? mPaymentTokens;

        #endregion

        #region Public Properties

        /// <summary>
        /// Identifier of the invoice provided by AADE. 
        /// </summary>
        [JsonProperty("uid")]
        public string UId
        {
            get => mUId ?? string.Empty;
            set => mUId = value;
        }

        /// <summary>
        /// Unique registration number of the invoice provided by AADE
        /// </summary>
        [JsonProperty("mark")]
        public long? Mark { get; set; }

        /// <summary>
        /// Authentication code of the invoice provided by AADE.
        /// </summary>
        [JsonProperty("authenticationCode")]
        public string AuthenticationCode
        {
            get => mAuthenticationCode ?? string.Empty;
            set => mAuthenticationCode = value;
        }

        /// <summary>
        /// The url where the client can see the invoice and 
        /// download its files produced by the system.
        /// </summary>
        [JsonProperty("qrCode")]
        public string QRCode
        {
            get => mQRCode ?? string.Empty;
            set => mQRCode = value;
        }

        /// <summary>
        /// Specifies whether the pdf of the invoice is uploaded or not.
        /// </summary>
        [JsonProperty("pdfUploaded")]
        public bool HasPDFUploaded { get; set; }

        /// <summary>
        /// Azure storage url with read rights to download the invoice pdf file.
        /// </summary>
        [JsonProperty("pdfFileUrl")]
        public Uri? PDFFileUrl { get; set; }

        /// <summary>
        /// The status of the B2G invoice transmission.
        /// </summary>
        [JsonProperty("publishStatus")]
        public PublishStatus PublishStatus { get; set; }

        /// <summary>
        /// The payment tokens
        /// </summary>
        [JsonProperty("paymentTokens")]
        public IEnumerable<PaymentTokenResponseModel> PaymentTokens
        {
            get => mPaymentTokens ?? Enumerable.Empty<PaymentTokenResponseModel>();
            set => mPaymentTokens = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceTransmissionSigningResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Uid {UId}";

        #endregion
    }
}