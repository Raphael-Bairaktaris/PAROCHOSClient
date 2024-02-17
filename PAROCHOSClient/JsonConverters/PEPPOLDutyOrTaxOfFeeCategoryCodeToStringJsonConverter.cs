using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="PEPPOLDutyOrTaxOfFeeCategoryCode"/> to <see cref="string"/>
    /// </summary>
    public class PEPPOLDutyOrTaxOfFeeCategoryCodeToStringJsonConverter : BaseEnumToStringJsonConverter<PEPPOLDutyOrTaxOfFeeCategoryCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PEPPOLDutyOrTaxOfFeeCategoryCodeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PEPPOLDutyOrTaxOfFeeCategoryCode, string> GetMapper() => PAROCHOSClientConstants.PEPPOLDutyOrTaxOfFeeCategoryCodeToStringMapper;

        #endregion
    }
}
