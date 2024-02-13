namespace PAROCHOSClient
{
    /// <summary>
    /// The invoice type enum
    /// </summary>
    public enum InvoiceType
    {
        // Sale invoices (1)

        /// <summary>
        /// Invoice type 1.1
        /// </summary>
        SalesInvoice = 11,

        /// <summary>
        /// Invoice type 1.2
        /// </summary>
        SalesInvoiceForIntraCommunity = 12,

        /// <summary>
        /// Invoice type 1.3
        /// </summary>
        SalesInvoiceForThirdPartyCountries = 13,

        /// <summary>
        /// Invoice type 1.4
        /// </summary>
        SalesInvoiceForThirdParty = 14,

        /// <summary>
        /// Invoice type 1.5
        /// </summary>
        SalesInvoiceForThirdPartySalesAndClearance = 15,

        /// <summary>
        /// Invoice type 1.6
        /// </summary>
        SalesInvoiceForAdditionalCases = 16,

        // Provision of service invoices (2)

        /// <summary>
        /// Invoice type 2.1
        /// </summary>
        ProvisionOfServicesInvoice = 21,

        /// <summary>
        /// Invoice type 2.2
        /// </summary>
        ProvisionOfServicesInvoiceForIntraCommunity = 22,

        /// <summary>
        /// Invoice type 2.3
        /// </summary>
        ProvisionOfServicesInvoiceForThirdCountries = 23,

        /// <summary>
        /// Invoice type 2.4
        /// </summary>
        ProvisionOfServicesInvoiceForAdditionalCases = 24,

        // Deeds of ownership (3)

        /// <summary>
        /// Invoice type 3.1
        /// </summary>
        DeedOfOwnershipForNonObligatoryIssuer = 31,

        /// <summary>
        /// Invoice type 3.2
        /// </summary>
        DeedOfOwnershipWithDenialFromObligatoryIssuer = 32,

        // Debit invoices (5)

        /// <summary>
        /// Invoice type 5.1
        /// </summary>
        CorrelatedDebitInvoice = 51,

        /// <summary>
        /// Invoice type 5.2
        /// </summary>
        NonCorrelatedDebitInvoice = 52,


        // Self delivery invoices (6)

        /// <summary>
        /// Invoice type 6.1
        /// </summary>
        SelfDeliveryReceipt = 61,

        /// <summary>
        /// Invoice type 6.2
        /// </summary>
        SelfUseReceipt = 62,

        // Contract - Income (7)

        /// <summary>
        /// Invoice type 7.1
        /// </summary>
        ContractIncome = 71,

        // Special item (income) – Receive receipt (8)

        /// <summary>
        /// Invoice type 8.1
        /// </summary>
        RentIncome = 81,

        /// <summary>
        /// Invoice type 8.2
        /// </summary>
        ReceiptOfAccommodationTaxCollection = 82,

        // Retail receipts (11)

        /// <summary>
        /// Invoice type 11.1
        /// </summary>
        SalesReceipt = 111,

        /// <summary>
        /// Invoice type 11.2
        /// </summary>
        ProvisionOfServicesReceipt = 112,

        /// <summary>
        /// Invoice type 11.3
        /// </summary>
        SimplifiedInvoice = 113,

        /// <summary>
        /// Invoice type 11.4
        /// </summary>
        SalesDebitReceipt = 114,

        /// <summary>
        /// Invoice type 11.5
        /// </summary>
        SalesReceiptForThirdParty = 115,

        // Obtaining retail receipts (13)

        /// <summary>
        /// Invoice type 13.1
        /// </summary>
        ExpensesPurchasesAndRetailTransactionsForDomesticAndNonDomestic = 131,

        /// <summary>
        /// Invoice type 13.2
        /// </summary>
        RetailTransactionsSubmissionForDomesticAndNonDomestic = 132,

        /// <summary>
        /// Invoice type 13.3
        /// </summary>
        SharedCommonExpenses = 133,

        /// <summary>
        /// Invoice type 13.4
        /// </summary>
        Subscriptions = 134,

        /// <summary>
        /// Invoice type 13.30
        /// </summary>
        EntityReceiptAsSpecifiedByTheOriginator = 1330,

        /// <summary>
        /// Invoice type 13.31
        /// </summary>
        SalesDebitReceiptForDomesticAndNonDomestic = 1331,

        // Exemption documents of domestic / foreign entities (14)

        /// <summary>
        /// Invoice type 14.1
        /// </summary>
        SalesInvoiceForIntraCommunityAcquisitions = 141,

        /// <summary>
        /// Invoice type 14.2
        /// </summary>
        SalesInvoiceForThirdCountriesAcquisitions = 142,

        /// <summary>
        /// Invoice type 14.3
        /// </summary>
        ProvisionOfServicesInvoiceForIntraCommunityAcquisitions = 143,

        /// <summary>
        /// Invoice type 14.4
        /// </summary>
        ProvisionOfServicesInvoiceForThirdCountriesAcquisitions = 144,

        /// <summary>
        /// Invoice type 14.5
        /// </summary>
        EFKAAndInsuranceOrganizations = 145,

        /// <summary>
        /// Invoice type 14.31
        /// </summary>
        DebitInvoiceForDomesticAndNonDomestic = 1431,

        // Contract - Expense (15)

        /// <summary>
        /// Invoice type 15.1
        /// </summary>
        ContractExpense = 151,

        // Special item (expense) – Payment receipt (16)

        /// <summary>
        /// Invoice type 16.1
        /// </summary>
        RentExpense = 161,

        // Entity records (17)

        /// <summary>
        /// Invoice type 17.1
        /// </summary>
        Payroll = 171,

        /// <summary>
        /// Invoice type 17.2
        /// </summary>
        Deprecations = 172,

        /// <summary>
        /// Invoice type 17.3
        /// </summary>
        VariousIncomeArrangementsForAccountingBase = 173,

        /// <summary>
        /// Invoice type 17.4
        /// </summary>
        VariousIncomeArrangementsForTaxBase = 174,

        /// <summary>
        /// Invoice type 17.5
        /// </summary>
        VariousExpenseArrangementsForAccountingBase = 175,

        /// <summary>
        /// Invoice type 17.6
        /// </summary>
        VariousExpenseArrangementsForTaxBase = 176,
    }
}
