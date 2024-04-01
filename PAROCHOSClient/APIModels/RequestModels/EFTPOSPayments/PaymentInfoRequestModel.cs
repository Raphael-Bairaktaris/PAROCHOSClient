using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Request model used for sending information related to a payment
    /// </summary>
    public class PaymentInfoRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The type
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// the amount
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The payment method information
        /// </summary>
        [JsonProperty("paymentMethodInfo")]
        public string? PaymentMethodInfo { get; set; }

        /// <summary>
        /// The tip amount
        /// </summary>
        [JsonProperty("tipAmount")]
        public decimal? TipAmount { get; set; }

        /// <summary>
        /// The transaction id
        /// </summary>
        [JsonProperty("transactionId")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// The signature
        /// </summary>
        [JsonProperty("signature")]
        public string? Signature { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PaymentInfoRequestModel() : base()
        {

        }

        #endregion
    }
}