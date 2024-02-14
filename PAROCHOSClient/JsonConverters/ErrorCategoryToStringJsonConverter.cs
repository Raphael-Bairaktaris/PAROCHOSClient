using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts an <see cref="ErrorCategory"/> to <see cref="string"/> 
    /// </summary>
    public class ErrorCategoryToStringJsonConverter : BaseEnumToStringJsonConverter<ErrorCategory>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ErrorCategoryToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ErrorCategory, string> GetMapper() => PAROCHOSClientConstants.ErrorCategoryToStringMapper;

        #endregion
    }
}
