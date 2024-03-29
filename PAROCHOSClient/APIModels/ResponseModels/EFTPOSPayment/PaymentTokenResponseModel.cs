using Newtonsoft.Json;
using System;

namespace PAROCHOSClient
{
    /// <summary>
    /// Represents a payment token response
    /// </summary>
    public class PaymentTokenResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Signature"/> property
        /// </summary>
        private string? mSignature;

        #endregion

        #region Public Properties

        /// <summary>
        /// The timestamp
        /// </summary>
        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// The signature
        /// </summary>
        [JsonProperty("signature")]
        public string Signature 
        { 
            get => mSignature ?? string.Empty;
            set => mSignature = value;
        }

        /// <summary>
        /// The amount
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PaymentTokenResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Timestamp: {Timestamp}, InvoiceAmount: {Amount}";

        #endregion
    }
}