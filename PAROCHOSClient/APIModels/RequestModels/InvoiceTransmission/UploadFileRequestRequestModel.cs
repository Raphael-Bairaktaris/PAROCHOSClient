﻿using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Request model used for creating an upload file request
    /// </summary>
    public class UploadFileRequestRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Unique processId as returned by api/send. 
        /// </summary>
        [JsonProperty("processId")]
        public string? ProcessId { get; set; }

        /// <summary>
        /// The external identifier provided as input to api/send method
        /// </summary>
        [JsonProperty("externalSystemId")]
        public string? ExternalSystemId { get; set; }

        /// <summary>
        /// The name of the PDF file.
        /// </summary>
        [JsonProperty("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        /// The size in bytes of the PDF file.
        /// </summary>
        [JsonProperty("fileSize")]
        public long? FileSize { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public UploadFileRequestRequestModel() : base()
        {

        }

        #endregion
    }
}
