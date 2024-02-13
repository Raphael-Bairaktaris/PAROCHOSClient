using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="VATCategory"/> to <see cref="int"/>
    /// </summary>
    public class VATCategoryToIntMapper : BaseEnumToIntJsonConverter<VATCategory>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public VATCategoryToIntMapper() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<VATCategory, int> GetMapper() => PAROCHOSClientConstants.VATCategoryToIntMapper;

        #endregion
    }
}
