using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="IncomeClassificationCategory"/> to <see cref="string"/>
    /// </summary>
    public class IncomeClassificationCategoryToStringJsonConverter : BaseEnumToStringJsonConverter<IncomeClassificationCategory>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public IncomeClassificationCategoryToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<IncomeClassificationCategory, string> GetMapper() => PAROCHOSClientConstants.IncomeClassificationCategoryToStringMapper;

        #endregion
    }
}
