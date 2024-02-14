using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="VATCategoryUBL"/> to <see cref="string"/>
    /// </summary>
    public class VATCategoryUBLToStringJsonConverter : BaseEnumToStringJsonConverter<VATCategoryUBL>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public VATCategoryUBLJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<VATCategoryUBL, string> GetMapper() => PAROCHOSClientConstants.VATCategoryUBLToStringMapper;

        #endregion
    }
}
