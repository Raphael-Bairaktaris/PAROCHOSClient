using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="PEPPOLAllowanceReasonCode"/> to <see cref="string"/>
    /// </summary>
    public class PEPPOLAllowanceReasonCodeToStringJsonConverter : BaseEnumToStringJsonConverter<PEPPOLAllowanceReasonCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PEPPOLAllowanceReasonCodeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PEPPOLAllowanceReasonCode, string> GetMapper() => PAROCHOSClientConstants.TaxCategoryUBLToStringMapper;

        #endregion
    }
}
