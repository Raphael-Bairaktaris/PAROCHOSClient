using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="PublishType"/> to <see cref="int"/>
    /// </summary>
    public class PublishTypeToIntMapper : BaseEnumToIntJsonConverter<PublishType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PublishTypeToIntMapper() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PublishType, int> GetMapper() => PAROCHOSClientConstants.PublishTypeToIntMapper;

        #endregion
    }
}
