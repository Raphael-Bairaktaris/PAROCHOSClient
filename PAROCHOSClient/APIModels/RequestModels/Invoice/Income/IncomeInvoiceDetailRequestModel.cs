using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Requests used for creating or updating the invoice details
    /// </summary>
    public class IncomeInvoiceDetailRequestModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Quantity"/> property
        /// </summary>
        private double mQuantity = 1;

        #endregion

        #region Public Properties

        /// <summary>
        /// Line type according to Tax Authorities' documentation
        /// </summary>
        [JsonProperty("recType")]
        [JsonConverter(typeof(LineItemToIntJsonConverter))]
        public LineItemType? RecType { get; set; }

        /// <summary>
        /// Line quantity
        /// </summary>
        [JsonRequired]
        [JsonProperty("quantity")]
        public double Quantity
        {
            get => mQuantity;

            set
            {
                if (value <= 0)
                    mQuantity = 1;
                else
                    mQuantity = value;
            }
        }

        /// <summary>
        /// Used only for Fuel Invoices and represents fuel quantity in 15oC
        /// </summary>
        [JsonProperty("quantity15")]
        public double? Quantity15 { get; set; }

        /// <summary>
        /// Item's description
        /// </summary>
        [JsonRequired]
        [JsonProperty("entityName")]
        public string? EntityName { get; set; }

        /// <summary>
        /// Invoice Detail Type when necessary according Tax Authorities' documentation
        /// </summary>
        [JsonProperty("invoiceDetailType")]
        [JsonConverter(typeof(InvoiceDetailTypeToIntJsonConverter))]
        public InvoiceDetailType? InvoiceDetailType { get; set; }

        /// <summary>
        /// Fuel Code according to Tax Authorities' documentation
        /// </summary>
        [JsonProperty("fuelCode")]
        [JsonConverter(typeof(FuelCodeCategoryTypeToIntJsonConverter))]
        public FuelCodeCategoryType? FuelCode { get; set; }

        /// <summary>
        /// Line total amount
        /// </summary>
        [JsonProperty("totalValue")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// VAT (Value Added Tax) Category according to Tax Authorities' documentation 
        /// </summary>
        [JsonRequired]
        [JsonProperty("vatCategory")]
        [JsonConverter(typeof(VATCategoryToIntJsonConverter))]
        public VATCategory? VATCategory { get; set; }

        /// <summary>
        /// VAT (Value Added Tax) Category according to UBL 2.1 documentation
        /// </summary>
        [JsonRequired]
        [JsonProperty("vatCategoryUbl")]
        [JsonConverter(typeof(VATCategoryUBLToStringJsonConverter))]
        public VATCategoryUBL? VatCategoryUBL { get; set; }

        /// <summary>
        /// VAT (Value Added Tax) exemption category according to Tax Authorities' documentation 
        /// </summary>
        [JsonProperty("vatExemption")]
        [JsonConverter(typeof(VATExemptionCategoryToIntJsonConverter))]
        public VATExemptionCategory? VATExemption { get; set; }

        /// <summary>
        /// VAT (Value Added Tax) Exemption category according to UBL 2.1 documentation
        /// </summary>
        [JsonProperty("vatExemptionUbl")]
        [JsonConverter(typeof(VATExemptionCategoryUBLToStringJsonConverter))]
        public VATExemptionCategoryUBL? VATExemptionUBL { get; set; }

        /// <summary>
        /// Measurement Unit according to Tax Authorities' documentation 
        /// </summary>
        [JsonRequired]
        [JsonProperty("measurementUnit")]
        [JsonConverter(typeof(MeasurementUnitToIntJsonConverter))]
        public MeasurementUnit? MeasurementUnit { get; set; }

        /// <summary>
        /// Measurement Unit according to UBL 2.1 documentation
        /// </summary>
        [JsonRequired]
        [JsonProperty("measurementUnitUbl")]
        [JsonConverter(typeof(UBLMeasurementUnitToStringJsonConverter))]
        public UBLMeasurementUnit? MeasurementUnitUBL { get; set; }

        /// <summary>
        /// Comments of line 
        /// </summary>
        [JsonProperty("lineComments")]
        public string? LineComments { get; set; }

        /// <summary>
        /// Classification category according to Tax Authorities' documentation (The system 
        /// automatically resolves whether it represents income or expense classification) 
        /// </summary>
        [JsonProperty("classificationCategory")]
        [JsonConverter(typeof(IncomeClassificationCategoryToStringJsonConverter))]
        public IncomeClassificationCategory? ClassificationCategory { get; set; }

        /// <summary>
        /// Classification type according to Tax Authorities' documentation (The system 
        /// automatically resolves whether it represents income or expense classification) 
        /// </summary>
        [JsonProperty("classificationType")]
        [JsonConverter(typeof(IncomeClassificationTypeToStringJsonConverter))]
        public IncomeClassificationType? ClassificationType { get; set; }

        ///// <summary>
        ///// VAT classification type of in case of expense classification 
        ///// according to Tax Authorities' documentation
        ///// TODO: Classification vat type might be an enum
        ///// </summary>
        //[JsonProperty("classificationVatType")]
        //public string? ClassificationVATType { get; set; }

        /// <summary>
        /// Classification code for public procurement. 
        /// Required only for B2G Transmission. 
        /// </summary>
        /// <example>publishType = 2</example>
        [JsonProperty("cpvCode")]
        public string? CPVCode { get; set; }

        /// <summary>
        /// Charge/allowance applied on line level or charge 
        /// with VAT in correspondence with “recType”
        /// </summary>
        [JsonProperty("taxInfo")]
        public InvoiceDetailTaxInfoRequestModel? TaxInfo { get; set; }

        #endregion

        #region Internal Properties

        /// <summary>
        /// Invoice Line N/A
        /// </summary>
        [JsonProperty("lineNumber")]
        internal int? LineNumber { get; set; }

        /// <summary>
        /// VAT amount
        /// </summary>
        [JsonRequired]
        [JsonProperty("vatAmount")]
        internal decimal? TaxAmount { get => Amount is null ? null : Amount - NetAmount; set { } }

        /// <summary>
        /// Line net amount
        /// </summary>
        [JsonRequired]
        [JsonProperty("netValue")]
        internal decimal? NetAmount { get => Amount is null ? null : NumericHelpers.CalculateNetAmountFromAmount(Amount.Value, Rate ?? 0); set { } }

        /// <summary>
        /// VAT Percent
        /// </summary>
        [JsonRequired]
        [JsonProperty("vatPercent")]
        internal decimal? Rate
        {
            get
            {
                if (VATCategory is null)
                    return null;

                return PAROCHOSClientConstants.VATCategoryToRateMapper[VATCategory.Value];
            }

            set { }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public IncomeInvoiceDetailRequestModel() : base()
        {

        }

        #endregion
    }
}