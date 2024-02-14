using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Requests used for creating or updating an invoice representative
    /// </summary>
    public class InvoiceRepresentativeRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Representative's TIN (Tax Identifier Number)
        /// </summary>
        [JsonProperty("vatNumber")]
        public string? VATNumber { get; set; }

        /// <summary>
        /// Representative's title
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceRepresentativeRequestModel() : base()
        {

        }

        #endregion
    }
}