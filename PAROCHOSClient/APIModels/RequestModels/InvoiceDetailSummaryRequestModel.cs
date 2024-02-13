﻿using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Requests used for creating or updating a detail summary 
    /// </summary>
    public class InvoiceDetailSummaryRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Total net amount of the invoice
        /// </summary>
        [JsonProperty("totalNetValue")]
        public decimal TotalNetValue { get; set; }

        /// <summary>
        /// Total VAT amount of the invoice
        /// </summary>
        [JsonProperty("totalVatAmount")]
        public decimal TotalVATAmount { get; set; }

        /// <summary>
        /// Invoice's payable amount
        /// </summary>
        [JsonRequired]
        [JsonProperty("totalValue")]
        public decimal TotalValue { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceDetailSummaryRequestModel() : base()
        {

        }

        #endregion
    }
}