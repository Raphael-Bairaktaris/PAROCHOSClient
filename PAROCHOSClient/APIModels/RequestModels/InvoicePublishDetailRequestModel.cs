using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Requests used for creating or updating a publish detail
    /// </summary>
    public class InvoicePublishDetailRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Public Authority Identifier (Required only for B2G) 
        /// </summary>
        [JsonProperty("contractingAuthorityID")]
        public string? ContractingAuthorityId { get; set; }

        /// <summary>
        /// The Identifier of the contract with the public Institution(Required only for B2G)
        /// </summary>
        [JsonProperty("contractIdentifier")]
        public string? ContractIdentifier { get; set; }

        /// <summary>
        /// The budget
        /// </summary>
        [JsonProperty("budget")]
        public InvoicePublishDetailBudgetRequestModel? Budget { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoicePublishDetailRequestModel() : base()
        {

        }

        #endregion
    }
}