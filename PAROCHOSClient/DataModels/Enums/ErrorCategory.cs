namespace PAROCHOSClient
{
    /// <summary>
    /// Provides enumeration over the error categories
    /// </summary>
    public enum ErrorCategory
    {
        /// <summary>
        /// Provider Technical Error (TED)
        /// </summary>
        ProviderTechnicalError = 0,

        /// <summary>
        /// Provider Business Error (BED)
        /// </summary>
        ProviderBusinessError = 1,

        /// <summary>
        /// Technical error by Tax Authorities (TTA)
        /// </summary>
        TechnicalErrorByTaxAuthorities = 2,

        /// <summary>
        /// Business error by Tax Authorities (BTA)
        /// </summary>
        BusinessErrorByTaxAuthorities = 3
    }
}
