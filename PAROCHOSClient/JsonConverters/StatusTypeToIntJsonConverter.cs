using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="StatusType"/> to <see cref="string"/>
    /// </summary>
    public class StatusTypeToIntJsonConverter : BaseEnumToIntJsonConverter<StatusType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public StatusTypeToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<StatusType, int> GetMapper() => PAROCHOSClientConstants.StatusTypeToIntMapper;

        #endregion
    }
}
