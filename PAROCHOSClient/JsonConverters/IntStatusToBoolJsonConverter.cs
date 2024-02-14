using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts an <see cref="int"/> that represents a status to <see cref="bool"/>
    /// </summary>
    public class IntStatusToBoolJsonConverter : JsonConverter<bool>
    {
        #region Constants

        /// <summary>
        /// The integer that represents the successful status
        /// </summary>
        public const int SuccessStatus = 1;

        /// <summary>
        /// The integer that represents the failed status
        /// </summary>
        public const int FailureStatus = 2;

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public IntStatusToBoolJsonConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<int>(reader);

            if (value == FailureStatus)
                return false;
            else
                return true;
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer)
        {
            writer.WriteValue(value ? SuccessStatus : FailureStatus);
        }

        #endregion
    }
}
