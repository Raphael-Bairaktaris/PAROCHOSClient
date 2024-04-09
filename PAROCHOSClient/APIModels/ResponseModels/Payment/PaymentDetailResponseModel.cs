using Newtonsoft.Json;
using System;

namespace PAROCHOSClient
{
    /// <summary>
    /// Represents a payment detail
    /// </summary>
    public class PaymentDetailResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The payment timestamp
        /// </summary>
        [JsonProperty("timestamp")]
        public DateTimeOffset? Timestamp { get; set; }

        /// <summary>
        /// The payment signature
        /// </summary>
        [JsonProperty("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// The payment amount
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The payment status
        /// </summary>
        [JsonProperty("status")]
        public StatusType? Status { get; set; }

        /// <summary>
        /// The payment's transaction id
        /// </summary>
        [JsonProperty("transactionId")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// The tip amount
        /// </summary>
        [JsonProperty("tipAmount")]
        public decimal? TipAmount { get; set; }

        /// <summary>
        /// The payment mark
        /// </summary>
        [JsonProperty("paymentMark")]
        public long? PaymentMark { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PaymentDetailResponseModel() : base()
        {

        }

        #endregion
    }
}