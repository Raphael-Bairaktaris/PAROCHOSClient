using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Requests used for canceling a payment
    /// </summary>
    public class CancelPaymentRequestModel : BasePAROCHOSRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The signature
        /// </summary>
        [JsonProperty("signature")]
        public string? Signature { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CancelPaymentRequestModel() : base()
        {

        }

        #endregion
    }
}
