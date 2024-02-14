using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// The base for all the parochos request models
    /// </summary>
    public class BaseParochosRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Unique processId as returned by api/send. 
        /// </summary>
        [JsonProperty("processId")]
        public string ProcessId { get; set; }

        /// <summary>
        /// The external identifier provided as input to api/send method 
        /// </summary>
        [JsonProperty("externalSystemId")]
        public string ExternalSystemId { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseParochosRequestModel() : base()
        {

        }

        #endregion
    }
}
