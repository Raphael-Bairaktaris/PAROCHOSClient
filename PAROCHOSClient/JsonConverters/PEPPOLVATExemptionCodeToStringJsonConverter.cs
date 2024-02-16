using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="PEPPOLVATExemptionCode"/> to <see cref="string"/>
    /// </summary>
    public class PEPPOLVATExemptionCodeToStringJsonConverter : BaseEnumToStringJsonConverter<PEPPOLVATExemptionCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PEPPOLVATExemptionCodeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PEPPOLVATExemptionCode, string> GetMapper() => PAROCHOSClientConstants.VATExemptionCategoryUBLToStringMapper;

        #endregion
    }
}
