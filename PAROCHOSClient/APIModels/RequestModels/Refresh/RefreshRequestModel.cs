using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Requests used for refresh
    /// </summary>
    public class RefreshRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The expired jwt.
        /// </summary>
        [JsonProperty("token")]
        public string? Token { get; set; }

        /// <summary>
        /// A valid refresh token
        /// </summary>
        [JsonProperty("refreshToken")]
        public string? RefreshToken { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RefreshRequestModel() : base()
        {

        }

        #endregion
    }
}
