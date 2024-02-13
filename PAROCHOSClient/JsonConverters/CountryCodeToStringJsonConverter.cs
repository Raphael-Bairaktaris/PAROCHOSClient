using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="CountryCode"/> to <see cref="string"/>
    /// </summary>
    public class CountryCodeToStringJsonConverter : BaseEnumToStringJsonConverter<CountryCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CountryCodeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<CountryCode, string> GetMapper() => PAROCHOSClientConstants.CountryCodeToStringMapper;

        #endregion
    }
}
