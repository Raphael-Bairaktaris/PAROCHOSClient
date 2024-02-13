using Newtonsoft.Json;
using System.Net.Mail;
using System.Text;

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
        [JsonConverter(typeof(MessageTypeToIntMapper))]
        public MessageType MessageType { get; set; }

        /// <summary>
        /// Email or mobile number of the recipients separated by “;”
        /// TODO
        /// </summary>
        [JsonProperty("recipients")]
        public StringBuilder Recipients { get; set; }

        /// <summary>
        /// Cc emails separated by “;”
        /// TODO
        /// </summary>
        [JsonProperty("cc")]
        public StringBuilder CC { get; set; }

        /// <summary>
        /// Identifier of message template, when not included the default message template is applied.
        /// </summary>
        [JsonProperty("templateIdentifier")]
        public string TemplateIdentifier { get; set; }

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