using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Represents a payment response
    /// </summary>
    public class RequestPaymentResponseModel : BasePaymentResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="UId"/> property
        /// </summary>
        private string? mUId;

        /// <summary>
        /// The member of the <see cref="PaymentToken"/> property
        /// </summary>
        private PaymentTokenResponseModel? mPaymentToken;

        #endregion

        #region Public Properties

        /// <summary>
        /// The uid
        /// </summary>
        [JsonProperty("uid")]
        public string UId
        {
            get => mUId ?? string.Empty;
            set => mUId = value;
        }

        /// <summary>
        /// The payment token details
        /// </summary>
        [JsonProperty("paymentToken")]
        public PaymentTokenResponseModel PaymentToken
        {
            get => mPaymentToken ??= new PaymentTokenResponseModel();
            set => mPaymentToken = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RequestPaymentResponseModel() : base()
        {

        }

        #endregion
    }
}
