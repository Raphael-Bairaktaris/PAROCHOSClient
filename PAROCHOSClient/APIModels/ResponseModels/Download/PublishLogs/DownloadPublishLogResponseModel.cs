using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// Represents a publish log response
    /// </summary>
    public class DownloadPublishLogResponseModel : BaseParochosResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="PublishLogs"/> property
        /// </summary>
        private IEnumerable<PublishLogDetailResponseModel>? mPublishLogs;

        #endregion

        #region Public Properties

        /// <summary>
        /// The publish log details
        /// </summary>
        [JsonProperty("publishLogs")]
        public IEnumerable<PublishLogDetailResponseModel> PublishLogs 
        { 
            get => mPublishLogs ?? Enumerable.Empty<PublishLogDetailResponseModel>();
            set => mPublishLogs = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DownloadPublishLogResponseModel() : base()
        {

        }

        #endregion
    }
}
