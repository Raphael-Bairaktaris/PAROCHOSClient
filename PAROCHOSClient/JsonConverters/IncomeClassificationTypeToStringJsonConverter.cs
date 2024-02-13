using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts an <see cref="IncomeClassificationType"/> to <see cref="string"/>
    /// </summary>
    public class IncomeClassificationTypeToStringJsonConverter : BaseEnumToStringJsonConverter<IncomeClassificationType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public IncomeClassificationTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<IncomeClassificationType, string> GetMapper() => PAROCHOSClientConstants.IncomeClassificationTypeToStringMapper;

        #endregion
    }
}
