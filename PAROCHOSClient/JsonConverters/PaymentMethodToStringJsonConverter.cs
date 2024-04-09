using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="BaseEnumToStringJsonConverter{T}"/> that is used for converting a <see cref="PaymentMethod"/> to <see cref="string"/>
    /// </summary>
    public class PaymentMethodToStringJsonConverter : BaseEnumToStringJsonConverter<PaymentMethod>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PaymentMethodToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PaymentMethod, string> GetMapper() => PAROCHOSClientConstants.PaymentMethodToStringMapper;

        #endregion
    }
}
