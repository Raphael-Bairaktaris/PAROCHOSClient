using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="VATExemptionCategory"/> to <see cref="int"/>
    /// </summary>
    public class VATExemptionCategoryToIntMapper : BaseEnumToIntJsonConverter<VATExemptionCategory>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public VATExemptionCategoryToIntMapper() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<VATExemptionCategory, int> GetMapper() => PAROCHOSClientConstants.VATExemptionCategoryToIntMapper;

        #endregion
    }
}
