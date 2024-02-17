using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Requests used for creating or updating an invoice detail tax info
    /// </summary>
    public class InvoiceDetailTaxInfoRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Charge/allowance category according to Tax Authorities' documentation 
        /// </summary>
        [JsonProperty("taxCategory")]
        [JsonConverter(typeof(TaxTypeToIntJsonConverter))]
        public TaxType? TaxCategory { get; set; }

        /// <summary>
        /// Charge/allowance category according to UBL 2.1 documentation
        /// </summary>
        [JsonProperty("taxCategoryUbl")]
        [JsonConverter(typeof(PEPPOLAllowanceReasonCodeToStringJsonConverter))]
        public PEPPOLAllowanceReasonCode? PEPPOLAllowanceReasonCode { get; set; }

        /// <summary>
        /// Total amount subject to a specific charge/allowance category
        /// </summary>
        [JsonProperty("underlyingValue")]
        public decimal? UnderlyingValue { get; set; }

        /// <summary>
        /// Charge/allowance percent applied
        /// </summary>
        [JsonProperty("taxPercent")]
        public decimal? Rate { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceDetailTaxInfoRequestModel() : base()
        {

        }

        #endregion
    }
}