using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts an <see cref="InvoiceType"/> to <see cref="string"/>
    /// </summary>
    public class InvoiceTypeToStringJsonConverter : BaseEnumToStringJsonConverter<InvoiceType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<InvoiceType, string> GetMapper() => PAROCHOSClientConstants.InvoiceTypeToStringMapper;

        #endregion
    }
}
