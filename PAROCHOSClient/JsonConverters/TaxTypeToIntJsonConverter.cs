using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="TaxType"/> to <see cref="string"/>
    /// </summary>
    public class TaxTypeToIntJsonConverter : BaseEnumToIntJsonConverter<TaxType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TaxTypeToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<TaxType, int> GetMapper() => PAROCHOSClientConstants.TaxCategoryToIntMapper;

        #endregion
    }
}
