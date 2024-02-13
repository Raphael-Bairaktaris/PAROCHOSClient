namespace PAROCHOSClient
{
    /// <summary>
    /// The payment type enum
    /// </summary>
    public enum PaymentMethod
    {
        /// <summary>
        /// Home Payments Professional Account
        /// </summary>
        BusinessHomePaymentAccount = 1,

        /// <summary>
        /// Foreigner's Professional Payment Account
        /// </summary>
        BusinessForeignPaymentAccount = 2,

        /// <summary>
        /// Cash payment
        /// </summary>
        Cash = 3,

        /// <summary>
        /// Bank check payment
        /// </summary>
        Check = 4,

        /// <summary>
        /// On credit payment
        /// </summary>
        OnCredit = 5,

        /// <summary>
        /// Online deposit
        /// </summary>
        WebBanking = 6,

        /// <summary>
        /// POS terminal
        /// </summary>
        POSOrEPOS = 7
    }
}
