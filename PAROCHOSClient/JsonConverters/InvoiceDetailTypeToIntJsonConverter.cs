using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="InvoiceDetailType"/> to <see cref="int"/>
    /// </summary>
    public class InvoiceDetailTypeToIntJsonConverter : BaseEnumToIntJsonConverter<InvoiceDetailType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceDetailTypeToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<InvoiceDetailType, int> GetMapper() => PAROCHOSClientConstants.InvoiceDetailTypeToIntMapper;

        #endregion
    }
}
