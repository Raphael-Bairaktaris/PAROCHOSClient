using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="MessageType"/> to <see cref="string"/>
    /// </summary>
    public class MessageTypeToIntMapper : BaseEnumToIntJsonConverter<MessageType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MessageTypeToIntMapper() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<MessageType, int> GetMapper() => PAROCHOSClientConstants.MessageTypeToIntMapper;

        #endregion
    }
}
