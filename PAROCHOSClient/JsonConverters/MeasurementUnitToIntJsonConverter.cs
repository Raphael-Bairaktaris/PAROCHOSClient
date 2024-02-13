using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="MeasurementUnit"/> to <see cref="int"/>
    /// </summary>
    public class MeasurementUnitToIntJsonConverter : BaseEnumToIntJsonConverter<MeasurementUnit>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MeasurementUnitToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<MeasurementUnit, int> GetMapper() => PAROCHOSClientConstants.MeasurementUnitToIntMapper;

        #endregion
    }
}
