using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Requests used for creating or updating a tax total
    /// </summary>
    public class InvoiceDetailTaxTotalRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Type of the charge/allowance according to Tax Authorities' documentation
        /// </summary>
        [JsonProperty("taxType")]
        [JsonConverter(typeof(TaxTypeToIntMapper))]
        public TaxType TaxType { get; set; }

        /// <summary>
        /// Charge/allowance category according to Tax Authorities' documentation 
        /// </summary>
        [JsonProperty("taxCategory")]
        [JsonConverter(typeof(VATCategoryToIntMapper))]
        public VATCategory TaxCategory { get; set; }

        /// <summary>
        /// Charge/allowance category according to UBL 2.1 documentation
        /// TODO
        /// </summary>
        [JsonProperty("taxCategoryUbl")]
        public string TaxCategoryUbl { get; set; }

        /// <summary>
        /// Total amount subject to a specific charge/allowance category
        /// </summary>
        [JsonProperty("underlyingValue")]
        public decimal UnderlyingValue { get; set; }

        /// <summary>
        /// Charge/allowance amount
        /// </summary>
        [JsonProperty("taxAmount")]
        public decimal TaxAmount { get; set; }

        /// <summary>
        /// Charge/allowance percent applied 
        /// </summary>
        [JsonProperty("taxPercent")]
        public decimal TaxPercent { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceDetailTaxTotalRequestModel() : base()
        {

        }

        #endregion
    }
}