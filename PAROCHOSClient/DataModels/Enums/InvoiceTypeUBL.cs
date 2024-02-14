namespace PAROCHOSClient
{
    /// <summary>
    /// Provides enumeration over the UBL invoice types
    /// </summary>
    public enum InvoiceTypeUBL
    {
        /// <summary>
        /// Request for payment (Code: 71)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a creditor to a debtor to request payment of one or more invoices past due.
        /// </remarks>
        RequestForPayment,

        /// <summary>
        /// Debit note related to goods or services (Code: 80)
        /// </summary>
        /// <remarks>
        /// Debit information related to a transaction for goods or services to the relevant party. 
        /// </remarks>
        DebitNoteRelatedToGoodsOrServices,

        /// <summary>
        /// Metered services invoice (Code: 82)
        /// </summary>
        /// <remarks>
        /// Document/message claiming payment for the supply of metered services (e.g., gas, electricity, etc.) supplied to a fixed meter whose consumption is measured over a period of time. 
        /// </remarks>
        MeteredServicesInvoice,

        /// <summary>
        /// Debit note related to financial adjustments (Code: 84)
        /// </summary>
        /// <remarks>
        /// Document/message for providing debit information related to financial adjustments to the relevant party. 
        /// </remarks>
        DebitNoteRelatedToFinancialAdjustments,

        /// <summary>
        /// Tax notification (Code: 102)
        /// </summary>
        /// <remarks>
        /// Used to specify that the message is a tax notification.
        /// </remarks>
        TaxNotification,

        /// <summary>
        /// Final payment request based on completion of work (Code: 218)
        /// </summary>
        /// <remarks>
        /// The final payment request of a series of payment requests submitted upon completion of all the work.
        /// </remarks>
        FinalPaymentRequestBasedOnCompletionOfWork,

        /// <summary>
        /// Payment request for completed units (Code: 219)
        /// </summary>
        /// <remarks>
        ///  A request for payment for completed units.
        /// </remarks>
        PaymentRequestForCompletedUnits,

        /// <summary>
        /// Commercial invoice which includes a packing list (Code: 331)
        /// </summary>
        /// <remarks>
        /// Commercial transaction (invoice) will include a packing list.
        /// </remarks>
        CommercialInvoiceWhichIncludesAPackingList,

        /// <summary>
        /// Commercial invoice (Code: 380)
        /// </summary>
        /// <remarks>
        /// (1334) Document/message claiming payment for goods or services supplied under conditions agreed between seller and buyer. 
        /// </remarks>
        CommercialInvoice,

        /// <summary>
        /// Commission note (Code: 382)
        /// </summary>
        /// <remarks>
        /// Document/message in which a seller specifies the amount of commission, the percentage of the invoice amount, or some other basis for the calculation of the commission to which a sales agent is entitled.
        /// </remarks>
        CommissionNote,

        /// <summary>
        /// Debit note (Code: 383)
        /// </summary>
        /// <remarks>
        /// Document/message for providing debit information to the relevant party. 
        /// </remarks>
        DebitNote,

        /// <summary>
        /// Prepayment invoice (Code: 386)
        /// </summary>
        /// <remarks>
        /// An invoice to pay amounts for goods and services in advance; these amounts will be subtracted from the final invoice. 
        /// </remarks>
        PrepaymentInvoice,

        /// <summary>
        /// Tax invoice (Code: 388)
        /// </summary>
        /// <remarks>
        /// An invoice for tax purposes.
        /// </remarks>
        TaxInvoice,

        /// <summary>
        /// Factored invoice (Code: 393)
        /// </summary>
        /// <remarks>
        /// Invoice assigned to a third party for collection.
        /// </remarks>
        FactoredInvoice,

        /// <summary>
        /// Consignment invoice (Code: 395)
        /// </summary>
        /// <remarks>
        /// Commercial invoice that covers a transaction other than one involving a sale. 
        /// </remarks>
        ConsignmentInvoice,

        /// <summary>
        /// Forwarder's invoice discrepancy report (Code: 553)
        /// </summary>
        /// <remarks>
        /// Document/message reporting invoice discrepancies indentified by the forwarder.
        /// </remarks>
        ForwardersInvoiceDiscrepancyReport,

        /// <summary>
        /// Insurer's invoice (Code: 575)
        /// </summary>
        /// <remarks>
        /// Document/message issued by an insurer specifying the cost of an insurance which has been effected and claiming payment therefore. 
        /// </remarks>
        InsurersInvoice,

        /// <summary>
        /// Forwarder's invoice (Code: 623)
        /// </summary>
        /// <remarks>
        /// Invoice issued by a freight forwarder specifying services rendered and costs incurred and claiming payment therefore. 
        /// </remarks>
        ForwardersInvoice,

        /// <summary>
        /// Freight invoice (Code: 780)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a transport operation specifying freight costs and charges incurred for a transport operation and stating conditions of payment. 
        /// </remarks>
        FreightInvoice,

        /// <summary>
        /// Claim notification (Code: 817)
        /// </summary>
        /// <remarks>
        /// Document notifying a claim.
        /// </remarks>
        ClaimNotification,

        /// <summary>
        /// Consular invoice (Code: 870)
        /// </summary>
        /// <remarks>
        /// Document/message to be prepared by an exporter in his country and presented to a diplomatic representation of the importing country for endorsement and subsequently to be presented by the importer in connection with the import of the goods described therein.
        /// </remarks>
        ConsularInvoice,

        /// <summary>
        /// Partial construction invoice (Code: 875)
        /// </summary>
        /// <remarks>
        /// Partial invoice in the context of a specific construction project.
        /// </remarks>
        PartialConstructionInvoice,

        /// <summary>
        /// Partial final construction invoice (Code: 876)
        /// </summary>
        /// <remarks>
        /// Invoice concluding all previous partial construction invoices of a completed partial rendered service in the context of a specific construction project.
        /// </remarks>
        PartialFinalConstructionInvoice,

        /// <summary>
        /// Final construction invoice (Code: 877)
        /// </summary>
        /// <remarks>
        /// Invoice concluding all previous partial invoices and partial final construction invoices in the context of a specific construction project.
        /// </remarks>
        FinalConstructionInvoice,

    }
}