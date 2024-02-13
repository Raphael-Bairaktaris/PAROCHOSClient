﻿using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Requests used for creating or updating the invoice details
    /// </summary>
    public class InvoiceDetailRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Invoice Line N/A
        /// </summary>
        [JsonProperty("lineNumber")]
        public double? LineNumber { get; set; }

        /// <summary>
        /// Line type according to Tax Authorities' documentation
        /// </summary>
        [JsonProperty("recType")]
        [JsonConverter(typeof(LineItemToIntMapper))]
        public LineItemType? RecType { get; set; }

        /// <summary>
        /// Line quantity
        /// </summary>
        [JsonRequired]
        [JsonProperty("quantity")]
        public double? Quantity { get; set; }

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
        /// TODO
        /// </summary>
        [JsonProperty("invoiceDetailType")]
        [JsonConverter(typeof(InvoiceTypeToStringJsonConverter))]
        public InvoiceType? InvoiceDetailType { get; set; }

        /// <summary>
        /// Fuel Code according to Tax Authorities' documentation
        /// </summary>
        [JsonProperty("fuelCode")]
        [JsonConverter(typeof(FuelCodeCategoryTypeToIntMapper))]
        public FuelCodeCategoryType? FuelCode { get; set; }

        /// <summary>
        /// Line net amount
        /// </summary>
        [JsonRequired]
        [JsonProperty("netValue")]
        public decimal? NetValue { get; set; }

        /// <summary>
        /// Line total amount
        /// </summary>
        [JsonProperty("totalValue")]
        public decimal? TotalValue { get; set; }

        /// <summary>
        /// VAT (Value Added Tax) Category according to Tax Authorities' documentation 
        /// </summary>
        [JsonRequired]
        [JsonProperty("`vatCategory")]
        [JsonConverter(typeof(VATCategoryToIntMapper))]
        public VATCategory? VATCategory { get; set; }

        /// <summary>
        /// VAT (Value Added Tax) Category according to UBL 2.1 documentation
        /// TODO
        /// </summary>
        [JsonRequired]
        [JsonProperty("vatCategoryUbl")]
        public string? VatCategoryUbl { get; set; }

        /// <summary>
        /// VAT (Value Added Tax) exemption category according to Tax Authorities' documentation 
        /// </summary>
        [JsonProperty("vatExemption")]
        [JsonConverter(typeof(VATExemptionCategoryToIntMapper))]
        public VATExemptionCategory? VATExemption { get; set; }

        /// <summary>
        /// VAT (Value Added Tax) Exemption category according to UBL 2.1 documentation
        /// </summary>
        [JsonProperty("vatExemptionUbl")]
        public string? VATExemptionUbl { get; set; }

        /// <summary>
        /// VAT amount
        /// </summary>
        [JsonRequired]
        [JsonProperty("vatAmount")]
        public decimal? VATAmount { get; set; }

        /// <summary>
        /// VAT Percent
        /// </summary>
        [JsonRequired]
        [JsonProperty("vatPercent")]
        public decimal? VATPercent { get; set; }

        /// <summary>
        /// Measurement Unit according to Tax Authorities' documentation 
        /// </summary>
        [JsonRequired]
        [JsonProperty("measurementUnit")]
        [JsonConverter(typeof(MeasurementUnitToIntMapper))]
        public MeasurementUnit? MeasurementUnit { get; set; }

        /// <summary>
        /// Measurement Unit according to UBL 2.1 documentation
        /// TODO
        /// </summary>
        [JsonRequired]
        [JsonProperty("measurementUnitUbl")]
        public string? MeasurementUnitUbl { get; set; }

        /// <summary>
        /// Comments of line 
        /// </summary>
        [JsonProperty("lineComments")]
        public string? LineComments { get; set; }

        /// <summary>
        /// Classification category according to Tax Authorities' documentation (The system 
        /// automatically resolves whether it represents income or expense classification) 
        /// TODO: Classification category from bratnet are presented as a list, PAROCHOS requires them as a string
        /// Proper documentation is missing
        /// </summary>
        [JsonProperty("classificationCategory")]
        public ExpenseClassificationCategory? ClassificationCategory { get; set; }

        /// <summary>
        /// Classification type according to Tax Authorities' documentation (The system 
        /// automatically resolves whether it represents income or expense classification) 
        /// TODO: Classification category from bratnet are presented as a list, PAROCHOS requires them as a string
        /// Proper documentation is missing
        /// </summary>
        [JsonProperty("classificationType")]
        public ExpenseClassificationType? ClassificationType { get; set; }

        /// <summary>
        /// VAT classification type of in case of expense classification 
        /// according to Tax Authorities' documentation
        /// TODO: Classification vat type might be an enum
        /// </summary>
        [JsonProperty("classificationVatType")]
        public string? ClassificationVATType { get; set; }

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

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceDetailRequestModel() : base()
        {

        }

        #endregion
    }
}