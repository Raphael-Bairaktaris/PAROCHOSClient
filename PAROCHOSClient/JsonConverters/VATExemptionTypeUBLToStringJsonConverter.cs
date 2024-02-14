using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="VATExemptionTypeUBL"/> to <see cref="string"/>
    /// </summary>
    public class VATExemptionTypeUBLToStringJsonConverter : BaseEnumToStringJsonConverter<VATExemptionTypeUBL>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public VATExemptionTypeUBLToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<VATExemptionTypeUBL, string> GetMapper() => PAROCHOSClientConstants.VATExemptionTypeUBLToStringMapper;

        #endregion
    }
}
