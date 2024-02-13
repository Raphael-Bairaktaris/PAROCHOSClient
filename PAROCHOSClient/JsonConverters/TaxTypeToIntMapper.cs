using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="TaxType"/> to <see cref="string"/>
    /// </summary>
    public class TaxTypeToIntMapper : BaseEnumToIntJsonConverter<TaxType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TaxTypeToIntMapper() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<TaxType, int> GetMapper() => PAROCHOSClientConstants.TaxCategoryToIntMapper;

        #endregion
    }
}
