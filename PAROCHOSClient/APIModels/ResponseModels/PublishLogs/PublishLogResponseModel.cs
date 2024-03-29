﻿using Newtonsoft.Json;
using System;

namespace PAROCHOSClient
{
    /// <summary>
    /// Represents a publish log detail response
    /// </summary>
    public class PublishLogResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Message"/> property
        /// </summary>
        private string? mMessage;

        #endregion

        #region Public Properties

#pragma warning disable CS1570 // XML comment has badly formed XML
        /// <summary>
        /// Publish log entry detailed message. Possible error messages described in
        /// </summary>
        /// <remarks>
        /// https://parochos.gr/files/API_Documentation_Provider.pdf#page=34&zoom=100,69,589
        /// </remarks>
        [JsonProperty("message")]
#pragma warning restore CS1570 // XML comment has badly formed XML
        public string Message
        {
            get => mMessage ?? string.Empty;
            set => mMessage = value;
        }

        /// <summary>
        /// Publish log entry status.
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(EntryStatusTypeToIntJsonConverter))]
        public EntryStatusType Status { get; set; }

        /// <summary>
        /// The log entry timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public DateTime TimeStamp { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PublishLogResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Message {Message}, Status {Status}, Timestamp {TimeStamp}";

        #endregion
    }
}