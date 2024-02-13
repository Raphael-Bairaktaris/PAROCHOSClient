using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="VATCategory"/> to <see cref="int"/>
    /// </summary>
    public class VATCategoryToIntJsonConverter : BaseEnumToIntJsonConverter<VATCategory>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public VATCategoryToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<VATCategory, int> GetMapper() => PAROCHOSClientConstants.VATCategoryToIntMapper;

        #endregion
    }
}
