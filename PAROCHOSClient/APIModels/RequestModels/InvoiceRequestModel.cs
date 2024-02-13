using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Represents an invoice response
    /// </summary>
    public class InvoiceRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Issuer’s information 
        /// </summary>
        [JsonRequired]
        [JsonProperty("issuer")]
        public InvoiceIssuerRequestModel Issuer { get; set; }

        /// <summary>
        /// Counterpart's information
        /// </summary>
        [JsonRequired]
        [JsonProperty("counterpart")]
        public InvoiceCounterpartRequestModel Counterpart { get; set; }

        /// <summary>
        /// Tax Representative’s details if exists 
        /// </summary>
        [JsonRequired]
        [JsonProperty("representative")]
        public InvoiceRepresentativeRequestModel Representative { get; set; }

        /// <summary>
        /// Shipping address details
        /// </summary>
        [JsonRequired]
        [JsonProperty("deliveryAddress")]
        public InvoceDeliveryAddressRequestModel DeliveryAddress { get; set; }

        /// <summary>
        /// Header of the invoice
        /// </summary>
        [JsonRequired]
        [JsonProperty("invoiceHeader")]
        public InvoiceHeaderRequestModel InvoiceHeader { get; set; }

        /// <summary>
        /// Lines of the invoice
        /// </summary>
        [JsonRequired]
        [JsonProperty("invoiceDetails")]
        public IEnumerable<InvoiceDetailRequestModel> InvoiceDetails { get; set; }


        /// <summary>
        /// List of payment Methods applied with different type and portion of net value
        /// </summary>
        [JsonProperty("paymentMethods")]
        public IEnumerable<InvoiceDetailPaymentMethodRequestModel>? PaymentMethods { get; set; }

        /// <summary>
        /// Fees and additional charges or allowances details, when charges are included
        /// </summary>
        [JsonProperty("taxesTotals")]
        public IEnumerable<InvoiceDetailTaxTotalRequestModel>? TaxesTotals { get; set; }

        /// <summary>
        /// Specific Invoice Types needs correlation between the invoice issued
        /// and a previously issued related invoice
        /// </summary>
        /// <example>e.g. sales invoice-credit invoice</example>
        [JsonProperty("correlatedInvoices")]
        public IEnumerable<InvoiceDetailCorrelatedInvoiceRequestModel>? CorrelatedInvoices { get; set; }

        /// <summary>
        /// Summary of total amounts of the invoice 
        /// </summary>
        [JsonRequired]
        [JsonProperty("invoiceSummary")]
        public InvoiceDetailSummaryRequestModel? InvoiceSummary { get; set; }

        /// <summary>
        /// Type of Electronic Invoice Transmission
        /// </summary>
        [JsonProperty("publishType")]
        [JsonConverter(typeof(PublishTypeToIntMapper))]
        public PublishType? PublishType { get; set; }

        /// <summary>
        /// Additional Information for B2B and B2G publishing
        /// </summary>
        [JsonProperty("publishDetails")]
        public InvoicePublishDetailRequestModel? PublishDetails { get; set; }

        /// <summary>
        /// Recipients information & type of message template
        /// </summary>
        [JsonProperty("messages")]
        public IEnumerable<InvoiceDetailMessageRequestModel>? Messages { get; set; }

        /// <summary>
        /// Delayed process code
        /// </summary>
        [JsonProperty("delayedProcessCode")]
        public InvoiceDetailDelayedProcessCodeRequestModel? DelayedProcessCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceRequestModel() : base()
        {

        }

        #endregion
    }
}
