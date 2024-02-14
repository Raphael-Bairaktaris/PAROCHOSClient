using Newtonsoft.Json;
using System;

namespace PAROCHOSClient
{
    /// <summary>
    /// Represents a login response
    /// </summary>
    public class LoginResponseModel : RefreshResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The base url (Uniform Resource Locator) of API.
        /// </summary>
        [JsonProperty("url1")]
        public Uri? URL1 { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginResponseModel() : base()
        {

        }

        #endregion
    }
}
