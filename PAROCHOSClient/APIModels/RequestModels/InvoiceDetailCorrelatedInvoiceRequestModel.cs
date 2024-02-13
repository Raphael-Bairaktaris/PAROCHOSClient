using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Requests used for creating or updating a correlated invoice
    /// </summary>
    public class InvoiceDetailCorrelatedInvoiceRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Original Invoice id as defined in your ERP System
        /// </summary>
        [JsonProperty("extSystemId")]
        public string ExitSystemId { get; set; }

        /// <summary>
        /// Original Invoice transmission M.AR.K
        /// </summary>
        [JsonProperty("mark")]
        public long Mark { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceDetailCorrelatedInvoiceRequestModel() : base()
        {

        }

        #endregion
    }
}