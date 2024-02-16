using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace PAROCHOSClient
{
    /// <summary>
    /// Request model used for sending an income invoice
    /// </summary>
    public class IncomeInvoiceRequestModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Details"/> property
        /// </summary>
        private IEnumerable<IncomeInvoiceDetailRequestModel>? mInvoiceDetails;

        #endregion

        #region Public Properties

        /// <summary>
        /// Issuer’s information 
        /// </summary>
        [JsonRequired]
        [JsonProperty("issuer")]
        public InvoiceIssuerRequestModel? Issuer { get; set; }

        /// <summary>
        /// Counterpart's information
        /// </summary>
        [JsonRequired]
        [JsonProperty("counterpart")]
        public InvoiceCounterpartRequestModel? Counterpart { get; set; }

        /// <summary>
        /// Tax Representative’s details if exists 
        /// </summary>
        [JsonProperty("representative")]
        public InvoiceRepresentativeRequestModel? Representative { get; set; }

        /// <summary>
        /// Shipping address details
        /// </summary>
        [JsonProperty("deliveryAddress")]
        public InvoceDeliveryAddressRequestModel? DeliveryAddress { get; set; }

        /// <summary>
        /// Header of the invoice
        /// </summary>
        [JsonRequired]
        [JsonProperty("invoiceHeader")]
        public InvoiceHeaderRequestModel? Header { get; set; }

        /// <summary>
        /// Lines of the invoice
        /// </summary>
        [JsonRequired]
        [JsonProperty("invoiceDetails")]
        public IEnumerable<IncomeInvoiceDetailRequestModel>? Details
        {
            get
            {
                if (mInvoiceDetails is null)
                    return null;

                var i = 0;
                foreach (var item in mInvoiceDetails)
                {
                    i++;
                    item.LineNumber = i;
                }

                return mInvoiceDetails;
            }

            set => mInvoiceDetails = value;
        }

        /// <summary>
        /// List of payment Methods applied with different type and portion of net value
        /// </summary>
        [JsonRequired]
        [JsonProperty("paymentMethods")]
        public IEnumerable<InvoicePaymentMethodRequestModel>? PaymentMethods { get; set; }

        /// <summary>
        /// Fees and additional charges or allowances details, when charges are included
        /// </summary>
        [JsonProperty("taxesTotals")]
        public IEnumerable<InvoiceDetailTaxTotalRequestModel>? Taxes { get; set; }

        /// <summary>
        /// Specific Invoice Types needs correlation between the invoice issued
        /// and a previously issued related invoice
        /// </summary>
        /// <example>e.g. sales invoice-credit invoice</example>
        [JsonProperty("correlatedInvoices")]
        public IEnumerable<InvoiceDetailCorrelatedInvoiceRequestModel>? CorrelatedInvoices { get; set; }

        /// <summary>
        /// Type of Electronic Invoice Transmission
        /// </summary>
        [JsonProperty("publishType")]
        [JsonConverter(typeof(PublishTypeToIntJsonConverter))]
        public PublishType? PublishType { get; set; }

        /// <summary>
        /// Additional Information for B2B and B2G publishing
        /// </summary>
        [JsonProperty("publishDetails")]
        public InvoicePublishDetailRequestModel? PublishDetails { get; set; }

        /// <summary>
        /// Recipients information and type of message template
        /// </summary>
        [JsonProperty("messages")]
        public IEnumerable<InvoiceDetailMessageRequestModel>? Messages { get; set; }

        /// <summary>
        /// Delayed process code
        /// </summary>
        [JsonProperty("delayedProcessCode")]
        public InvoiceDetailDelayedProcessCodeRequestModel? DelayedProcessCode { get; set; }

        #endregion

        #region Internal Properties

        /// <summary>
        /// Summary of total amounts of the invoice 
        /// </summary>
        [JsonRequired]
        [JsonProperty("invoiceSummary")]
        internal InvoiceDetailSummaryRequestModel? InvoiceSummary
        {
            get
            {
                if (Details is null)
                    return null;

                return new InvoiceDetailSummaryRequestModel()
                {
                    Amount = Details.Sum(x => x.Amount),
                    NetAmount = Details.Sum(x => x.NetAmount),
                    TaxAmount = Details.Sum(x => x.TaxAmount),
                };
            }

            set { }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public IncomeInvoiceRequestModel() : base()
        {

        }

        #endregion
    }
}
