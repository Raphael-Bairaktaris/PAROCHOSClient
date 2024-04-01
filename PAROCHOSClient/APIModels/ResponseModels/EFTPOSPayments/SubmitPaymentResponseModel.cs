using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Represents a payment submission
    /// </summary>
    public class SubmitPaymentResponseModel : BasePaymentResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The payment mark
        /// </summary>
        [JsonProperty("paymentMark")]
        public long PaymentMark { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SubmitPaymentResponseModel() : base()
        {

        }

        #endregion
    }
}
