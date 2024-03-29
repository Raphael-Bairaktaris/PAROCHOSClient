using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// Requests used for a submitting a payment
    /// </summary>
    public class SubmitPaymentRequestModel : BasePAROCHOSRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The mark
        /// </summary>
        [JsonProperty("mark")]
        public long? Mark { get; set; }

        /// <summary>
        /// The payment info
        /// </summary>
        [JsonProperty("paymentInfo")]
        public IEnumerable<PaymentInfoRequestModel>? PaymentInfo { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SubmitPaymentRequestModel() : base()
        {

        }

        #endregion
    }
}
