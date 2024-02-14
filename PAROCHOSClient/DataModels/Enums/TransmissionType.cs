namespace PAROCHOSClient
{
    /// <summary>
    /// Provides enumeration over the transmission types
    /// </summary>
    public enum TransmissionType
    {
        /// <summary>
        /// Transmits invoice to Tax Authorities platform
        /// </summary>
        TransmitInvoice = 0,

        /// <summary>
        /// Transmits invoice to Tax Authorities platform
        /// and generates invoice pdf file
        /// </summary>
        TransmitInvoiceAndGeneratePDF = 1
    }
}
