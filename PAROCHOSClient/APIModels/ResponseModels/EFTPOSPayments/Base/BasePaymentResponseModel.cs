using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// The base for all the PAROCHOS payment models
    /// </summary>
    public class BasePaymentResponseModel : BasePAROCHOSResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ProcessId"/> property
        /// </summary>
        private string? mProcessId;

        /// <summary>
        /// The member of the <see cref="ExternalSystemId"/> property
        /// </summary>
        private string? mExternalSystemId;

        #endregion

        #region Public Properties

        /// <summary>
        /// The process id
        /// </summary>
        /// <example>3fa85f64-5717-4562-b3fc-2c963f66afa6</example>
        [JsonProperty("processId")]
        public string ProcessId
        {
            get => mProcessId ?? string.Empty;
            set => mProcessId = value;
        }

        /// <summary>
        /// The external system id
        /// </summary>
        [JsonProperty("externalSystemId")]
        public string ExternalSystemId
        {
            get => mExternalSystemId ?? string.Empty;
            set => mExternalSystemId = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BasePaymentResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Error category: {ErrorCategory}, Error message: {ErrorMessage}, Status: {Status}";

        #endregion
    }
}
