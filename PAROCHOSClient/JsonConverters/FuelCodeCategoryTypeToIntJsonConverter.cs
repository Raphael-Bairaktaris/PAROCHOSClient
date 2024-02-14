using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="FuelCodeCategoryType"/> to <see cref="int"/>
    /// </summary>
    public class FuelCodeCategoryTypeToIntJsonConverter : BaseEnumToIntJsonConverter<FuelCodeCategoryType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public FuelCodeCategoryTypeToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<FuelCodeCategoryType, int> GetMapper() => PAROCHOSClientConstants.FuelCodeCategoryTypeToIntMapper;

        #endregion
    }
}
