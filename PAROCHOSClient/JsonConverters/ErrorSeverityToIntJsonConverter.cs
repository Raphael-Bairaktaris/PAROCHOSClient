using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts an <see cref="ErrorSeverity"/> to <see cref="int"/>
    /// </summary>
    public class ErrorSeverityToIntJsonConverter : BaseEnumToIntJsonConverter<ErrorSeverity>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ErrorSeverityToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ErrorSeverity, int> GetMapper() => PAROCHOSClientConstants.ErrorSeverityToIntMapper;

        #endregion
    }
}
