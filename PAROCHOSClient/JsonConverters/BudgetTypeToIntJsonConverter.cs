using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="BudgetType"/> to <see cref="string"/>
    /// </summary>
    public class BudgetTypeToIntJsonConverter : BaseEnumToIntJsonConverter<BudgetType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BudgetTypeToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<BudgetType, int> GetMapper() => PAROCHOSClientConstants.BudgetTypeToIntMapper;

        #endregion
    }
}
