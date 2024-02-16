using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// The base for all the enum to value json converters
    /// </summary>
    public abstract class BaseEnumToValueJsonConverter<T, TJsonValue, TValue> : JsonConverter<T>
        where T : Enum
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseEnumToValueJsonConverter()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override sealed T? ReadJson(JsonReader reader, Type objectType, T? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<TJsonValue?>(reader)!;

            if (readerValue is null)
                return existingValue;

            foreach (var pair in GetMapper())
            {
                if (Equals(pair.Value, readerValue))
                    return pair.Key;
            }

            return default!;
        }

        /// <inheritdoc/> 
        public override sealed void WriteJson(JsonWriter writer, T? value, JsonSerializer serializer)
        {
            writer.WriteValue(GetMapper()[value!]);
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Gets a <see cref="IReadOnlyDictionary{TKey, TValue}"/> that maps the values of the <typeparamref name="T"/>
        /// to <see cref="string"/>s
        /// </summary>
        /// <returns></returns>
        protected abstract IReadOnlyDictionary<T, TValue> GetMapper();

        #endregion
    }
}
