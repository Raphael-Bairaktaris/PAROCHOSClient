namespace PAROCHOSClient
{
    /// <summary>
    /// The credentials used for the PAROCHOS API
    /// </summary>
    public record PAROCHOSCredentials
    {
        #region Public Properties

        /// <summary>
        /// Secret key of the user subscription. 
        /// </summary>
        public string SubscriptionKey { get; }

        /// <summary>
        /// User’s email. 
        /// </summary>
        public string Email { get; }

        /// <summary>
        /// User’s password.
        /// </summary>
        public string Password { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="subscriptionKey">Secret key of the user subscription.</param>
        /// <param name="email">User’s email.</param>
        /// <param name="password">User’s password.</param>
        public PAROCHOSCredentials(string subscriptionKey, string email, string password) : base()
        {
            SubscriptionKey = subscriptionKey.NotNullOrEmpty();
            Email = email.NotNullOrEmpty();
            Password = password.NotNullOrEmpty();
        }

        #endregion
    }
}
