using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// Requests used for downloading file
    /// </summary>
    public class FilesRequestModel : BasePAROCHOSRequestModel
    {
        #region Public Properties

        /// <summary>
        /// List of file identifiers. If empty, all files are returned.
        /// </summary>
        [JsonProperty("fileIdentifiers")]
        [JsonConverter(typeof(FileIdentifierTypeEnumerableToStringJsonConverter))]
        public IEnumerable<FileIdentifierType>? FileIdentifiers { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public FilesRequestModel() : base()
        {

        }

        #endregion
    }
}
