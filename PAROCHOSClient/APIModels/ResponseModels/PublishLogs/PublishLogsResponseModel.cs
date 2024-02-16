using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace PAROCHOSClient
{
    /// <summary>
    /// Represents a publish logs
    /// </summary>
    public class PublishLogsResponseModel : BasePAROCHOSResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="PublishLogs"/> property
        /// </summary>
        private IEnumerable<PublishLogResponseModel>? mPublishLogs;

        #endregion

        #region Public Properties

        /// <summary>
        /// The publish logs
        /// </summary>
        [JsonProperty("publishLogs")]
        public IEnumerable<PublishLogResponseModel> PublishLogs
        {
            get => mPublishLogs ?? Enumerable.Empty<PublishLogResponseModel>();
            set => mPublishLogs = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PublishLogsResponseModel() : base()
        {

        }

        #endregion
    }
}
