using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="MeasurementUnit"/> to <see cref="int"/>
    /// </summary>
    public class MeasurementUnitToIntMapper : BaseEnumToIntJsonConverter<MeasurementUnit>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MeasurementUnitToIntMapper() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<MeasurementUnit, int> GetMapper() => PAROCHOSClientConstants.MeasurementUnitToIntMapper;

        #endregion
    }
}
