using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="PEPPOLRecommendationCode"/> to <see cref="string"/>
    /// </summary>
    public class PEPPOLRecommendationCodeToStringJsonConverter : BaseEnumToStringJsonConverter<PEPPOLRecommendationCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PEPPOLRecommendationCodeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PEPPOLRecommendationCode, string> GetMapper() => PAROCHOSClientConstants.UBLMeasurementUnitToStringMapper;

        #endregion
    }
}
