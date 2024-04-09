
namespace PAROCHOSClient
{
    /// <summary>
    /// Provides enumeration over the publish types
    /// </summary>
    public enum PublishStatus
    {
        /// <summary>
        /// Pending 
        /// </summary>
        Pending = 0,

        /// <summary>
        /// Sending
        /// </summary>
        Sending = 1,

        /// <summary>
        /// Transmitted
        /// </summary>
        Transmitted = 2,

        /// <summary>
        /// Processing
        /// </summary>
        Processing = 3,

        /// <summary>
        /// Paid
        /// </summary>
        Paid = 4,

        /// <summary>
        /// Rejected
        /// </summary>
        Rejected = 5,

        /// <summary>
        /// Under query
        /// </summary>
        UnderQuery = 6,

        /// <summary>
        /// Failed
        /// </summary>
        Failed = 7
    }
}
