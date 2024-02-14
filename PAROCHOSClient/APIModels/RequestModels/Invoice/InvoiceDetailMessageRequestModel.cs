using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// Requests used for creating or updating an invoice detail message
    /// </summary>
    public class InvoiceDetailMessageRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Type of message to be sent
        /// </summary>
        [JsonRequired]
        [JsonProperty("messageType")]
        [JsonConverter(typeof(MessageTypeToIntJsonConverter))]
        public MessageType? MessageType { get; set; }

        /// <summary>
        /// Email or mobile number of the recipients separated by “;”
        /// </summary>
        [JsonProperty("recipients")]
        [JsonConverter(typeof(StringEnumerableToSemiColonSeparatedString))]
        public IEnumerable<string>? Recipients { get; set; }

        /// <summary>
        /// Cc emails separated by “;”
        /// </summary>
        [JsonProperty("cc")]
        [JsonConverter(typeof(StringEnumerableToSemiColonSeparatedString))]
        public IEnumerable<string>? CC { get; set; }

        /// <summary>
        /// Identifier of message template, when not included the default message template is applied.
        /// </summary>
        [JsonProperty("templateIdentifier")]
        public string? TemplateIdentifier { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceDetailMessageRequestModel() : base()
        {

        }

        #endregion
    }
}