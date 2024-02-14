using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="VATExemptionCategoryUBL"/> to <see cref="string"/>
    /// </summary>
    public class VATExemptionCategoryUBLToStringJsonConverter : BaseEnumToStringJsonConverter<VATExemptionCategoryUBL>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public VATExemptionCategoryUBLToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<VATExemptionCategoryUBL, string> GetMapper() => PAROCHOSClientConstants.VATExemptionCategoryUBLToStringMapper;

        #endregion
    }
}
