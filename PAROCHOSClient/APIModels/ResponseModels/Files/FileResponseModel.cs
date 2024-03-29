﻿using Newtonsoft.Json;
using System;

namespace PAROCHOSClient
{
    /// <summary>
    /// Represents a downloaded file details
    /// </summary>
    public class FileResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="FileName"/> property
        /// </summary>
        private string? mFileName;

        #endregion

        #region Public Properties

        /// <summary>
        /// Azure storage url
        /// </summary>
        [JsonProperty("downloadUrl")]
        public Uri? DownloadUrl { get; set; }

        /// <summary>
        /// Name of the file uploaded
        /// </summary>
        [JsonProperty("fileName")]
        public string FileName
        {
            get => mFileName ?? string.Empty;
            set => mFileName = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public FileResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods 

        /// <inheritdoc/>
        public override string ToString() => FileName;

        #endregion
    }
}