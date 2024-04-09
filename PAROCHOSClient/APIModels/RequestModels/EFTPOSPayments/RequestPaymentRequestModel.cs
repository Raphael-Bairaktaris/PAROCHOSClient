using Newtonsoft.Json;
using System;

namespace PAROCHOSClient
{
    /// <summary>
    /// Request model used for starting the registration of a payment
    /// </summary>
    public class RequestPaymentRequestModel : BasePAROCHOSRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The issuer's vat number
        /// </summary>
        [JsonProperty("issuerVatNumber")]
        public string? InvoiceIssuerVATNumber { get; set; }

        /// <summary>
        /// The invoice issue date
        /// </summary>
        [JsonProperty("invoiceIssueDate")]
        [JsonConverter(typeof(DateOnlyToStringJsonConverter))]
        public DateOnly? InvoiceIssueDate { get; set; }

        /// <summary>
        /// The company branch
        /// </summary>
        [JsonProperty("companyBranch")]
        public string? InvoiceCompanyBranch { get; set; }

        /// <summary>
        /// The invoice type
        /// </summary>
        [JsonRequired]
        [JsonProperty("invoiceType")]
        [JsonConverter(typeof(InvoiceTypeToStringJsonConverter))]
        public InvoiceType? InvoiceType { get; set; }

        /// <summary>
        /// The invoice series
        /// </summary>
        [JsonRequired]
        [JsonProperty("invoiceSeries")]
        public string? InvoiceSeries { get; set; }

        /// <summary>
        /// The invoice increasing number
        /// </summary>
        [JsonRequired]
        [JsonProperty("invoiceAA")]
        public int? InvoiceAA { get; set; }

        /// <summary>
        /// The mark value
        /// </summary>
        [JsonRequired]
        [JsonProperty("mark")]
        public long? InvoiceMark { get; set; }

        /// <summary>
        /// The net amount of the invoice
        /// </summary>
        [JsonProperty("netValue")]
        public decimal? InvoiceNetAmount { get; set; }

        /// <summary>
        /// The tax amount of th einvoice
        /// </summary>
        [JsonProperty("vatAmount")]
        public decimal? InvoiceTaxAmount { get; set; }

        /// <summary>
        /// The payment amount
        /// </summary>
        [JsonProperty("paymentAmount")]
        public decimal? PaymentAmount { get; set; }

        /// <summary>
        /// The terminal id
        /// </summary>
        [JsonProperty("terminalId")]
        public string? TerminalId { get; set; }

        #endregion

        #region Internal Properties

        /// <summary>
        /// The total value
        /// </summary>
        [JsonProperty("totalValue")]
        internal decimal? InvoiceAmount
        {
            get => InvoiceNetAmount + InvoiceTaxAmount;

            set { }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RequestPaymentRequestModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates and returns a <see cref="RequestPaymentRequestModel"/> from the specified models
        /// </summary>
        /// <param name="invoiceTransmissionSigning">The invoice transmission signing</param>
        /// <param name="incomeInvoice">The income invoice</param>
        /// <param name="header">The header</param>
        /// <returns></returns>
        public static RequestPaymentRequestModel Create(InvoiceTransmissionSigningResponseModel invoiceTransmissionSigning, IncomeInvoiceRequestModel incomeInvoice, InvoiceHeaderRequestModel header)
        {
            return new RequestPaymentRequestModel()
            {
                InvoiceAA = header.AA,
                InvoiceType = header.InvoiceType,
                InvoiceIssueDate = header.IssueDate,
                InvoiceSeries = header.Series,

                InvoiceIssuerVATNumber = incomeInvoice.Issuer?.VATNumber,
                InvoiceCompanyBranch = incomeInvoice.Issuer?.Branch?.ToString(),

                InvoiceNetAmount = incomeInvoice.InvoiceSummary?.NetAmount,
                InvoiceTaxAmount = incomeInvoice.InvoiceSummary?.TaxAmount,

                InvoiceMark = invoiceTransmissionSigning.Mark,
            };
        }

        #endregion
    }
}
