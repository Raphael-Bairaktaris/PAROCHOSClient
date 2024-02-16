using Newtonsoft.Json;
using System;

namespace PAROCHOSClient
{
    /// <summary>
    /// Represents a refresh response
    /// </summary>
    public class RefreshResponseModel
    {
        #region Private Region

        /// <summary>
        /// The member of the <see cref="JWT"/> property
        /// </summary>
        private string? mJWT;

        /// <summary>
        /// The member of the <see cref="JWTRefreshToken"/> property
        /// </summary>
        private string? mJWTRefreshToken;

        #endregion

        #region Public Properties

        /// <summary>
        /// The new access token
        /// </summary>
        [JsonProperty("jwt")]
        public string JWT
        {
            get => mJWT ?? string.Empty;
            set => mJWT = value;
        }

        /// <summary>
        /// The expiration DateTime of the jwt (JSON Web Token)
        /// </summary>
        [JsonProperty("jwtExpiration")]
        public DateTimeOffset JWTExpiration { get; set; }

        /// <summary>
        /// The new refresh token
        /// </summary>
        [JsonProperty("jwtRefreshToken")]
        public string JWTRefreshToken
        {
            get => mJWTRefreshToken ?? string.Empty;
            set => mJWTRefreshToken = value;
        }

        /// <summary>
        /// The expiration DateTime of the refresh token.
        /// </summary>
        [JsonProperty("jwtRefreshTokenExpiration")]
        public DateTimeOffset JWTRefreshTokenExpiration { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RefreshResponseModel() : base()
        {

        }

        #endregion
    }
}
