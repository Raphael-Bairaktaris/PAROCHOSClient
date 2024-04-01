using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Request model used for creating a publish detail budget
    /// </summary>
    public class InvoicePublishDetailBudgetRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Type of the budget
        /// </summary>
        [JsonProperty("budgetType")]
        [JsonConverter(typeof(BudgetTypeToIntJsonConverter))]
        public BudgetType BudgetType { get; set; }

        /// <summary>
        /// Identifier number of the budget
        /// </summary>
        [JsonProperty("identifier")]
        public double Identifier { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoicePublishDetailBudgetRequestModel() : base()
        {

        }

        #endregion
    }
}