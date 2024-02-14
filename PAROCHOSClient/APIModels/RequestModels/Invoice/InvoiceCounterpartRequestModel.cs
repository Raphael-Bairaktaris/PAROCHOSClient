using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Requests used for creating or updating an invoice counterpart
    /// </summary>
    public class InvoiceCounterpartRequestModel : BaseAddressRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Counterpart's VAT (Value Added Tax) number 
        /// </summary>
        [JsonProperty("vatNumber")]
        public double VATNumber { get; set; }

        /// <summary>
        /// Counterpart's branch
        /// </summary>
        [JsonProperty("branch")]
        public double Branch { get; set; }

        /// <summary>
        /// Counterpart's name
        /// </summary>
        [JsonRequired]
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Counterpart's company contact email
        /// </summary>
        [JsonProperty("email")]
        public string? Email { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceCounterpartRequestModel() : base()
        {

        }

        #endregion
    }
}