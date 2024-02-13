using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="VATExemptionCategory"/> to <see cref="int"/>
    /// </summary>
    public class VATExemptionCategoryToIntJsonConverter : BaseEnumToIntJsonConverter<VATExemptionCategory>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public VATExemptionCategoryToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<VATExemptionCategory, int> GetMapper() => PAROCHOSClientConstants.VATExemptionCategoryToIntMapper;

        #endregion
    }
}
