using Newtonsoft.Json;
using System;

namespace PAROCHOSClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that is used for converting between a value that supports string based formatting
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    public abstract class BaseFormattableValueToStringJsonConverter<T> : JsonConverter<T>
        where T : IParsable<T>, IFormattable
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseFormattableValueToStringJsonConverter()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override sealed T ReadJson(JsonReader reader, Type objectType, T? existingValue, bool hasExistingValue, JsonSerializer serializer)
            => T.Parse(serializer.Deserialize<string>(reader)!, new FormatProvider(GetFormat()));

        /// <inheritdoc/>
        public override sealed void WriteJson(JsonWriter writer, T? value, JsonSerializer serializer)
            => writer.WriteValue(value?.ToString(GetFormat(), null));

        #endregion

        #region Protected Methods

        /// <summary>
        /// Gets the format that is used for serializing and deserializing the value
        /// </summary>
        /// <returns></returns>
        protected abstract string GetFormat();

        #endregion

        #region Private Classes

        private class FormatProvider : IFormatProvider
        {
            #region Public Properties

            /// <summary>
            /// The format
            /// </summary>
            public string Format { get; }

            #endregion

            #region Constructors

            /// <summary>
            /// Default constructor
            /// </summary>
            public FormatProvider(string format)
            {
                Format = format;
            }

            #endregion

            #region Public Methods

            /// <inheritdoc/>
            public object? GetFormat(Type? formatType)
            {
                return Format;
            }

            #endregion
        }

        #endregion
    }
}
