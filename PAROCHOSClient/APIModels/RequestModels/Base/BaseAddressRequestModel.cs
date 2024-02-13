using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// The base for all the address request models
    /// </summary>
    public class BaseAddressRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Issuer's country
        /// </summary>
        /// <remarks>https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2</remarks>
        [JsonRequired]
        [JsonProperty("country")]
        public CountryCode Country { get; set; }

        /// <summary>
        /// Issuer's city
        /// </summary>
        [JsonProperty("city")]
        public string? City { get; set; }

        /// <summary>
        /// Issuer's street address
        /// </summary>
        [JsonProperty("street")]
        public string? Street { get; set; }

        /// <summary>
        /// Issuer's street address number
        /// </summary>
        [JsonProperty("streetNumber")]
        public double? StreetNumber { get; set; }

        /// <summary>
        /// Issuer's address postal code
        /// </summary>
        [JsonProperty("postalCode")]
        public string? PostalCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseAddressRequestModel() : base()
        {

        }

        #endregion
    }
}
