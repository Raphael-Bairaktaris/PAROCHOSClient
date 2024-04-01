using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Request model used for creating an invoice delivery address
    /// </summary>
    public class InvoceDeliveryAddressRequestModel : BaseAddressRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The name of the party to which the goods and services are delivered.
        /// Required only for B2G Transmission.
        /// </summary>
        [JsonProperty("partyName")]
        public string? PartyName { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoceDeliveryAddressRequestModel() : base()
        {

        }

        #endregion
    }
}