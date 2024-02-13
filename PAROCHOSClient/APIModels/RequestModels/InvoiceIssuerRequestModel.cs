using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Requests used for creating or updating an invoice issuer
    /// </summary>
    public class InvoiceIssuerRequestModel : BaseAddressRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Issuer's TIN (Tax Identification Number)
        /// </summary>
        [JsonRequired]
        [JsonProperty("vatNumber")]
        public double? VatNumber { get; set; }

        /// <summary>
        /// Issuer’s Company Branch N/A as registered in Tax Authorities' platform
        /// </summary>
        [JsonProperty("branch")]
        public double? Branch { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceIssuerRequestModel() : base()
        {

        }

        #endregion
    }
}