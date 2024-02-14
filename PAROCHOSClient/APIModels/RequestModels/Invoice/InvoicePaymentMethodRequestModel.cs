using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Requests used for creating or updating a payment method
    /// </summary>
    public class InvoicePaymentMethodRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Payment method code according to Tax Authorities' documentation 
        /// </summary>
        [JsonRequired]
        [JsonProperty("type")]
        [JsonConverter(typeof(PaymentMethodToIntJsonConverter))]
        public PaymentMethod? Type { get; set; }

        /// <summary>
        /// Portion of net amount
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoicePaymentMethodRequestModel() : base()
        {

        }

        #endregion
    }
}