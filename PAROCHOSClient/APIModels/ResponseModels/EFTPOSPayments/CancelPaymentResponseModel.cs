using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Represents a payment cancel
    /// </summary>
    public class CancelPaymentResponseModel : BasePaymentResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Signature"/> property
        /// </summary>
        private string? mSignature;

        #endregion

        #region Public Properties

        /// <summary>
        /// The signature
        /// </summary>
        [JsonProperty("signature")]
        public string Signature
        {
            get => mSignature ?? string.Empty;
            set => mSignature = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CancelPaymentResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => Signature;

        #endregion
    }
}
