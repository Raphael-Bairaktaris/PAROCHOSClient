using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="PEPPOLAllowanceReasonCode"/> to <see cref="string"/>
    /// </summary>
    public class TaxCategoryToStringJsonConverter : BaseEnumToStringJsonConverter<PEPPOLAllowanceReasonCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TaxCategoryToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PEPPOLAllowanceReasonCode, string> GetMapper() => PAROCHOSClientConstants.PEPPOLAllowanceReasonCodeToStringMapper;

        #endregion
    }
}
