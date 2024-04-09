using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace PAROCHOSClient
{
    /// <summary>
    /// Represents a publish log download 
    /// </summary>
    public class DownloadPublishLogsResponseModel : BasePAROCHOSResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="PublishLogs"/> property
        /// </summary>
        private IEnumerable<DownloadPublishLogsDetailResponseModel>? mPublishLogs;

        #endregion

        #region Public Properties

        /// <summary>
        /// The published logs
        /// </summary>
        [JsonProperty("publishLogs")]
        public IEnumerable<DownloadPublishLogsDetailResponseModel> PublishLogs
        {
            get => mPublishLogs ?? Enumerable.Empty<DownloadPublishLogsDetailResponseModel>();
            set => mPublishLogs = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DownloadPublishLogsResponseModel() : base()
        {

        }

        #endregion
    }
}
