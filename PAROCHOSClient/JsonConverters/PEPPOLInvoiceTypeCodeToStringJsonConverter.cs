using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient.JsonConverters
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts an <see cref="PEPPOLInvoiceTypeCode"/> to <see cref="string"/>
    /// </summary>
    public class PEPPOLInvoiceTypeCodeToStringJsonConverter : BaseEnumToStringJsonConverter<PEPPOLInvoiceTypeCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PEPPOLInvoiceTypeCodeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PEPPOLInvoiceTypeCode, string> GetMapper() => PAROCHOSClientConstants.InvoiceTypeUBLToStringMapper;

        #endregion
    }
}
