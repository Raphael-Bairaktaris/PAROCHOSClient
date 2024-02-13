using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Requests used for creating or updating an invoice header
    /// </summary>
    public class InvoiceHeaderRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Series Code of Invoice issued. 
        /// </summary>
        [JsonRequired]
        [JsonProperty("series")]
        public string Series { get; set; }

        /// <summary>
        /// Invoice number (increasing number)
        /// </summary>
        [JsonRequired]
        [JsonProperty("aa")]
        public double AA { get; set; }

        /// <summary>
        /// Invoice date
        /// </summary>
        /// <remarks>https://en.wikipedia.org/wiki/ISO_8601</remarks>
        [JsonRequired]
        [JsonProperty("issueDate")]
        public DateTime IssueDate { get; set; }

        /// <summary>
        /// Payment Due Date ISO 8601. In case the Amount due for payment is positive, 
        /// either the Payment due date(BT-9) or Payment terms(BT-20) shall be present.
        /// </summary>
        [JsonProperty("dueDate")]
        public DateOnly DueDate { get; set; }

        /// <summary>
        /// A textual description of the payment terms that apply to the amount due for 
        /// payment(Including description of possible penalties). In case the Amount
        /// due for payment is positive, either the Payment due date(BT-9) or the Payment
        /// terms(BT-20) shall be present.
        /// </summary>
        [JsonProperty("paymentTerms")]
        public string PaymentTerms { get; set; }

        /// <summary>
        /// Dispatch date
        /// </summary>
        /// <remarks>https://en.wikipedia.org/wiki/ISO_8601</remarks>
        [JsonProperty("dispatchDate")]
        public DateOnly DispatchDate { get; set; }

        /// <summary>
        /// Invoice code
        /// </summary>
        [JsonProperty("invoiceCode")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// Invoice Type according to Tax Authorities' documentation
        /// </summary>
        [JsonRequired]
        [JsonProperty("invoiceType")]
        [JsonConverter(typeof(InvoiceTypeToStringJsonConverter))]
        public InvoiceType InvoiceType { get; set; }

        /// <summary>
        /// Invoice Type according to UBL 2.1 documentation
        /// TODO
        /// </summary>
        [JsonProperty("invoiceTypeUbl")]
        public string InvoiceTypeUbl { get; set; }

        /// <summary>
        /// Currency of invoice
        /// </summary>
        /// <remarks>https://en.wikipedia.org/wiki/ISO_4217</remarks>
        [JsonRequired]
        [JsonProperty("currency")]
        [JsonConverter(typeof(CurrencyCodeToStringJsonConverter))]
        public CurrencyCode Currency { get; set; }

        /// <summary>
        /// Indicates whether the invoice is self pricing. Default is fault
        /// </summary>
        [JsonProperty("selfPricing")]
        public bool IsSelfPricing { get; set; }

        /// <summary>
        /// Move purpose according to tax authorities documentation
        /// </summary>
        [JsonProperty("movePurpose")]
        [JsonConverter(typeof(MovePurposeToIntJsonConverter))]
        public MovePurpose MovePurpose { get; set; }

        /// <summary>
        /// Indicates whether the invoice is related to fuel … Default is false 
        /// </summary>
        [JsonProperty("fuleInvoice")]
        public bool FuelInvoice { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceHeaderRequestModel() : base()
        {

        }

        #endregion
    }
}