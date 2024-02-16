using Newtonsoft.Json;

using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="TransmissionType"/> to <see cref="int"/>
    /// </summary>
    public class TransmissionTypeToIntJsonConverter : BaseEnumToIntJsonConverter<TransmissionType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TransmissionTypeToIntJsonConverter() : base()
        {

        }

        #endregion

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<TransmissionType, int> GetMapper() => PAROCHOSClientConstants.TransmissionTypeToIntMapper;
    }
}
