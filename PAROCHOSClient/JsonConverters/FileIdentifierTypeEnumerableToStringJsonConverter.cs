using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="FileIdentifierType"/> to <see cref="string"/>
    /// </summary>
    public class FileIdentifierTypeEnumerableToStringJsonConverter : BaseEnumEnumerableJsonConverter<FileIdentifierType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public FileIdentifierTypeEnumerableToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<FileIdentifierType, string> GetMapper() => PAROCHOSClientConstants.FileIdentifierToStringJsonConverter;

        #endregion
    }
}
