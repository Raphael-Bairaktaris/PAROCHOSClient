using Newtonsoft.Json;
using System;

namespace PAROCHOSClient
{
    /// <summary>
    /// Represents a publish log detail download
    /// </summary>
    public class DownloadPublishLogsDetailResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Message"/> property
        /// </summary>
        private string? mMessage;

        #endregion

        #region Public Properties

        /// <summary>
        /// Publish log entry detailed message. 
        /// </summary>
        /// <example>Το Ηλεκτρονικό Τιμολόγιο έχει δρομολογηθεί προς αποστολή στην Αναθέτουσα αρχή</example>
        [JsonProperty("message")]
        public string Message
        {
            get => mMessage ?? string.Empty;
            set => mMessage = value;
        }

        /// <summary>
        /// Publish log entry status
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(EntryStatusTypeToIntJsonConverter))]
        public EntryStatusType Status { get; set; }

        /// <summary>
        /// The log entry timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DownloadPublishLogsDetailResponseModel() : base()
        {

        }

        #endregion
    }
}