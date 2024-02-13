using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="CurrencyCode"/> to <see cref="string"/>
    /// </summary>
    public class CurrencyCodeToStringJsonConverter : BaseEnumToStringJsonConverter<CurrencyCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CurrencyCodeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<CurrencyCode, string> GetMapper() => PAROCHOSClientConstants.CurrencyCodeToStringMapper;

        #endregion
    }
}
