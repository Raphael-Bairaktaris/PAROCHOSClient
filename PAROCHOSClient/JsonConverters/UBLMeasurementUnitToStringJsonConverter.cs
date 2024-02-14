using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="UBLMeasurementUnit"/> to <see cref="string"/>
    /// </summary>
    public class UBLMeasurementUnitToStringJsonConverter : BaseEnumToStringJsonConverter<UBLMeasurementUnit>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public UBLMeasurementUnitToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<UBLMeasurementUnit, string> GetMapper() => PAROCHOSClientConstants.UBLMeasurementUnitToStringMapper;

        #endregion
    }
}
