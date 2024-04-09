using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="BaseEnumToIntJsonConverter{T}"/> that is used to convert a <see cref="PublishStatus"/> to <see cref="int"/>
    /// </summary>
    public class PublishStatusToIntJsonConverter : BaseEnumToIntJsonConverter<PublishStatus>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PublishStatusToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PublishStatus, int> GetMapper() => PAROCHOSClientConstants.PublishStatusToIntMapper;

        #endregion
    }
}
