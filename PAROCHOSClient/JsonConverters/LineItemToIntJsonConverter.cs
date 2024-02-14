using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="LineItemType"/> to <see cref="string"/>
    /// </summary>
    public class LineItemToIntJsonConverter : BaseEnumToIntJsonConverter<LineItemType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public LineItemToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<LineItemType, int> GetMapper() => PAROCHOSClientConstants.LineItemTypeToIntMapper;

        #endregion
    }
}
