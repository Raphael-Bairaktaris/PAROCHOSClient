using System.Collections.Generic;
using System.Linq;

namespace PAROCHOSClient
{
    /// <summary>
    /// Represents a download file response
    /// </summary>
    public class FilesResponseModel : BasePAROCHOSResponseModel
    {
        #region private Members

        /// <summary>
        /// The member of the <see cref="Files"/> property
        /// </summary>
        private IEnumerable<FileResponseModel>? mFiles;

        #endregion

        #region Public Properties

        /// <summary>
        /// The files
        /// </summary>
        public IEnumerable<FileResponseModel> Files
        {
            get => mFiles ?? Enumerable.Empty<FileResponseModel>();
            set => mFiles = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public FilesResponseModel() : base()
        {

        }

        #endregion
    }
}
