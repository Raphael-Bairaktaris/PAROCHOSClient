using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts between a <see cref="string"/> and an <see cref="IEnumerable{string}"/>
    /// using a ';' as the delimiter
    /// </summary>
    public class StringEnumerableToSemiColonSeparatedString : JsonConverter<IEnumerable<string>?>
    {
        #region Constants

        /// <summary>
        /// The delimiter
        /// </summary>
        public const string Delimeter = ";";

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public StringEnumerableToSemiColonSeparatedString() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override IEnumerable<string>? ReadJson(JsonReader reader, Type objectType, IEnumerable<string>? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string?>(reader);

            if (value is null)
                return null;

            return value.Split(Delimeter, StringSplitOptions.RemoveEmptyEntries);
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, IEnumerable<string>? value, JsonSerializer serializer)
        {
            if (value.IsNullOrEmpty())
                return;

            writer.WriteValue(value.AggregateString(Delimeter));
        }

        #endregion
    }
}
