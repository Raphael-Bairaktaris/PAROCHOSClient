using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="TaxCategoryUBL"/> to <see cref="string"/>
    /// </summary>
    public class TaxCategoryUBLToStringJsonConverter : BaseEnumToStringJsonConverter<TaxCategoryUBL>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TaxCategoryUBLToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<TaxCategoryUBL, string> GetMapper() => PAROCHOSClientConstants.TaxCategoryUBLToStringMapper;

        #endregion
    }
}
