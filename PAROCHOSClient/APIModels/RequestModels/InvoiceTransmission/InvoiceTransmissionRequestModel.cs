﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace PAROCHOSClient
{
    /// <summary>
    /// Requests used for invoice transmission
    /// </summary>
    public class InvoiceTransmissionRequestModel
    {
        #region Public Properties

        /// <summary>
        /// An identifier of the invoice specified by the client. Each invoice is validated based its status and this external ID. For
        /// example a signed invoice with the same external ID is not allowed to resend.
        /// </summary>
        [JsonRequired]
        [JsonProperty("externalSystemId")]
        public string? ExternalSystemId { get; set; }

        /// <summary>
        /// Json serialized object that contains the data to be send. 
        /// </summary>
        [JsonRequired]
        [JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        /// The identifier of the template used to map the incoming invoice data to the model required by AADE Provider.
        /// This value is specified through UI configuration.
        /// </summary>
        [JsonProperty("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        /// Resolves the required type of transmission. Default value 0
        /// </summary>
        [JsonProperty("transmissionType")]
        public TransmissionType? TransmissionType { get; set; }

        /// <summary>
        /// Base64 encoded binary data. A draft .txt file of the invoice. 
        /// It is the base64 representation string of the byte array of the file.
        /// </summary>
        [JsonProperty("attachments")]
        public IEnumerable<InvoiceTransmissionAttachmentRequestModel>? Attachments { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceTransmissionRequestModel() : base()
        {

        }

        #endregion
    }
}
