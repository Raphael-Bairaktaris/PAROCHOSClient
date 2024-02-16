using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Request model that is used as a wrapper for an invoice
    /// </summary>
    /// <typeparam name="T">The type of the invoice</typeparam>
    internal class InvoiceWrapperRequestModel<T>
    {
        #region Public Properties

        /// <summary>
        /// The invoice
        /// </summary>
        [JsonProperty("invoice")]
        public T? Invoice { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceWrapperRequestModel() : base()
        {

        }

        #endregion
    }
}
