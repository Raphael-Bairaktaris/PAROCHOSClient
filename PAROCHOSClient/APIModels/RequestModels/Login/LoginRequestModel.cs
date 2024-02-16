using Newtonsoft.Json;

namespace PAROCHOSClient
{
    /// <summary>
    /// Requests used for login
    /// </summary>
    public class LogInRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Secret key of the user subscription. 
        /// </summary>
        [JsonProperty("subscriptionKey")]
        public string? SubscriptionKey { get; set; }

        /// <summary>
        /// User's email
        /// </summary>
        [JsonProperty("Email")]
        public string? Email { get; set; }

        /// <summary>
        /// User's password
        /// </summary>
        [JsonProperty("password")]
        public string? Password { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public LogInRequestModel() : base()
        {

        }

        #endregion
    }
}
