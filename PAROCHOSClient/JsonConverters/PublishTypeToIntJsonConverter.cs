using Newtonsoft.Json;

using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="PublishType"/> to <see cref="int"/>
    /// </summary>
    public class PublishTypeToIntJsonConverter : BaseEnumToIntJsonConverter<PublishType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PublishTypeToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PublishType, int> GetMapper() => PAROCHOSClientConstants.PublishTypeToIntMapper;

        #endregion
    }
}
