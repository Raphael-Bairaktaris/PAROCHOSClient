using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts an <see cref="EntryStatusType"/> to <see cref="int"/>
    /// </summary>
    public class EntryStatusTypeToIntJsonConverter : BaseEnumToIntJsonConverter<EntryStatusType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public EntryStatusTypeToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<EntryStatusType, int> GetMapper() => PAROCHOSClientConstants.EntryStatusTypeTointMapper;

        #endregion
    }
}
