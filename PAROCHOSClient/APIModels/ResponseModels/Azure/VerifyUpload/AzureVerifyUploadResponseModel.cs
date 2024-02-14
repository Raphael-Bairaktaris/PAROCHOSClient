using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// Represents an azure verification upload response
    /// </summary>
    public class AzureVerifyUploadResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ErrorCode"/> property
        /// </summary>
        private string? mErrorCode;

        /// <summary>
        /// The member of the <see cref="ErrorMessage"/> property
        /// </summary>
        private string? mErrorMessage;

        #endregion

        #region Public Properties

        /// <summary>
        /// Status of the verify request. Success =1, Failed =2 
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(IntStatusToBoolJsonConverter))]
        public bool IsSuccessful { get; set; }

        /// <summary>
        /// In case verify request fails, errorCode indicates the type of the error.
        /// </summary>
        [JsonProperty("errorCode")]
        public string ErrorCode 
        { 
            get => mErrorCode ?? string.Empty;
            set => mErrorCode = value;
        }

        /// <summary>
        /// Detailed description of the error.
        /// </summary>
        [JsonProperty("errorMessage")]
        public string ErrorMessage 
        { 
            get => mErrorMessage ?? string.Empty;
            set => mErrorMessage = value;
        }

        /// <summary>
        /// Indicates the category of the error. 
        /// </summary>
        [JsonProperty("errorCategory")]
        [JsonConverter(typeof(ErrorCategoryToStringJsonConverter))]
        public ErrorCategory ErrorCategory { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AzureVerifyUploadResponseModel() : base()
        {

        }

        #endregion
    }
}
