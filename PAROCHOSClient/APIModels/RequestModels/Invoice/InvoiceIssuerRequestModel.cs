using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Request model used for creating an invoice issuer
    /// </summary>
    public class InvoiceIssuerRequestModel : BaseAddressRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Issuer's TIN (Tax Identification Number)
        /// </summary>
        [JsonRequired]
        [JsonProperty("vatNumber")]
        public string? VATNumber { get; set; }

        /// <summary>
        /// Issuer’s Company Branch N/A as registered in Tax Authorities' platform
        /// </summary>
        [JsonProperty("branch")]
        public int? Branch { get; set; }

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