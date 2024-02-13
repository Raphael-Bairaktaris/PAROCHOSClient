namespace PAROCHOSClient
{
    /// <summary>
    /// Provides enumeration over the vat categories
    /// </summary>
    public enum VATCategory
    {
        /// <summary>
        /// VAT rate 24%
        /// </summary>
        VATRate24,

        /// <summary>
        /// VAT rate 13%
        /// </summary>
        VATRate13,

        /// <summary>
        /// VAT rate 6%
        /// </summary>
        VATRate6,

        /// <summary>
        /// VAT rate 17%
        /// </summary>
        VATRate17,

        /// <summary>
        /// VAT rate 9%
        /// </summary>
        VATRate9,

        /// <summary>
        /// VAT rate 4%
        /// </summary>
        VATRate4,

        /// <summary>
        /// VAT excluded
        /// </summary>
        ExcludingVAT,

        /// <summary>
        /// Registrations without VAT
        /// </summary>
        /// <example>
        /// Payroll, Depreciation etc.
        /// </example>
        EntriesWithoutVAT
    }
}
