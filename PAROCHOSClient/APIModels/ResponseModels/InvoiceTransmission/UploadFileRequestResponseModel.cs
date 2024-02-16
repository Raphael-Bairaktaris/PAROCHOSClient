using System;

namespace PAROCHOSClient
{
    /// <summary>
    /// Represents an upload file request
    /// </summary>
    public class UploadFileRequestResponseModel : BasePAROCHOSResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Azure storage url
        /// </summary>
        public Uri? UploadUrl { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public UploadFileRequestResponseModel() : base()
        {

        }

        #endregion
    }
}
