using BratnetProvider;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="PaymentMethod"/> to <see cref="string"/>
    /// </summary>
    public class PaymentMethodToIntMapper : BaseEnumToIntJsonConverter<PaymentMethod>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PaymentMethodToIntMapper() : base()
        {

        }

        #endregion

        #region Public Properties

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PaymentMethod, int> GetMapper() => PAROCHOSClientConstants.PaymentTypeToIntMapper;

        #endregion
    }
}
