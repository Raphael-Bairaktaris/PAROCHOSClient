using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// Requests used for downloading file
    /// </summary>
    public class DownloadFileRequestModel : BaseParochosRequestModel
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
        public DownloadFileRequestModel() : base()
        {

        }

        #endregion
    }
}
