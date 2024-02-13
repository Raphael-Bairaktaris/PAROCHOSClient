using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="LineItemType"/> to <see cref="string"/>
    /// </summary>
    public class LineItemToIntMapper : BaseEnumToIntJsonConverter<LineItemType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public LineItemToIntMapper() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<LineItemType, int> GetMapper() => PAROCHOSClientConstants.LineItemTypeToIntMapper;

        #endregion
    }
}
