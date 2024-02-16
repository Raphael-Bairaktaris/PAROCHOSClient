namespace PAROCHOSClient
{
    /// <summary>
    /// provides enumeration over the entry status types
    /// </summary>
    public enum EntryStatusType
    {
        /// <summary>
        /// Pending
        /// </summary>
        Pending = 0,

        /// <summary>
        /// E invoice received by KE.D. (AB)
        /// </summary>
        EInvoiceReceived = 1,

        /// <summary>
        /// Accepted (AP)
        /// </summary>
        Accepted = 2,

        /// <summary>
        /// Rejected (RE)
        /// </summary>
        Rejected = 3,

        /// <summary>
        /// In process (IP)
        /// </summary>
        InProcess = 4,

        /// <summary>
        /// Under query (UQ)
        /// </summary>
        UnderQuery = 5,

        /// <summary>
        /// Conditionally accepted (CA)
        /// </summary>
        ConditionallyAccepted = 6,

        /// <summary>
        /// Paid (PD)
        /// </summary>
        Paid = 7
    }
}
