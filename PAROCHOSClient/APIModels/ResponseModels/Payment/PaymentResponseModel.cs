using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// Represents a payment
    /// </summary>
    public class PaymentResponseModel : BasePAROCHOSResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Payments"/> property
        /// </summary>
        private IEnumerable<PaymentDetailResponseModel>? mPayments;

        #endregion

        #region Public Properties

        /// <summary>
        /// The payment details
        /// </summary>
        public IEnumerable<PaymentDetailResponseModel> Payments 
        { 
            get => mPayments ?? Enumerable.Empty<PaymentDetailResponseModel>();
            set => mPayments = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PaymentResponseModel() : base()
        {

        }

        #endregion
    }
}
