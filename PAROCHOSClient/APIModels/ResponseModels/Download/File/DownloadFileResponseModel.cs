using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// Represents a download file response
    /// </summary>
    public class DownloadFileResponseModel : BaseParochosResponseModel
    {
        #region private Members

        /// <summary>
        /// The member of the <see cref="Files"/> property
        /// </summary>
        private IEnumerable<DownloadFileDetailsResponseModel>? mFiles;

        #endregion

        #region Public Properties

        /// <summary>
        /// The file details
        /// </summary>
        public IEnumerable<DownloadFileDetailsResponseModel> Files 
        { 
            get => mFiles ?? Enumerable.Empty<DownloadFileDetailsResponseModel>();
            set => mFiles = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DownloadFileResponseModel() : base()
        {

        }

        #endregion
    }
}
