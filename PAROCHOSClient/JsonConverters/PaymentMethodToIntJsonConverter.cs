using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="PaymentMethod"/> to <see cref="string"/>
    /// </summary>
    public class PaymentMethodToIntJsonConverter : BaseEnumToIntJsonConverter<PaymentMethod>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PaymentMethodToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Public Properties

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PaymentMethod, int> GetMapper() => PAROCHOSClientConstants.PaymentTypeToIntMapper;

        #endregion
    }
}
