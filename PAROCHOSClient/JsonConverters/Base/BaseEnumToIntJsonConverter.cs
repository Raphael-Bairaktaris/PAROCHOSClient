using Newtonsoft.Json;
using System;

namespace PAROCHOSClient
{
    /// <summary>
    /// The base for all the <see cref="JsonConverter{T}"/>s that are used for converting between an <see cref="Enum"/> and a <see cref="int"/>.
    /// </summary>
    public abstract class BaseEnumToIntJsonConverter<T> : BaseEnumToValueJsonConverter<T, int?, int>
        where T : Enum
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseEnumToIntJsonConverter()
        {

        }

        #endregion
    }
}