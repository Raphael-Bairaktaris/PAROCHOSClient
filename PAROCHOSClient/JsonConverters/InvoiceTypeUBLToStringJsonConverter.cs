using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient.JsonConverters
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts an <see cref="InvoiceTypeUBL"/> to <see cref="string"/>
    /// </summary>
    public class InvoiceTypeUBLToStringJsonConverter : BaseEnumToStringJsonConverter<InvoiceTypeUBL>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceTypeUBLToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<InvoiceTypeUBL, string> GetMapper() => PAROCHOSClientConstants.InvoiceTypeUBLToStringMapper;

        #endregion
    }
}
