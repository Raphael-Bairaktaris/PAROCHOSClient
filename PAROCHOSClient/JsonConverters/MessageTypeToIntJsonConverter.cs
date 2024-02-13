using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="MessageType"/> to <see cref="string"/>
    /// </summary>
    public class MessageTypeToIntJsonConverter : BaseEnumToIntJsonConverter<MessageType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MessageTypeToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<MessageType, int> GetMapper() => PAROCHOSClientConstants.MessageTypeToIntMapper;

        #endregion
    }
}
