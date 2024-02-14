// See https://aka.ms/new-console-template for more information

using PAROCHOSClient;

var credentials = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "PAROCHOSClientCredentials.txt")).Split(Environment.NewLine);

var client = new PAROCHOSClient.PAROCHOSClient(new PAROCHOSCredentials(credentials[0], credentials[1], credentials[2]));

var logInResponse = await client.LogInAsync();

var requestModel = new InvoiceRequestModel()
{
    Issuer = new InvoiceIssuerRequestModel()
    {
        VatNumber = "113223052",
        Country = CountryCode.GR,
        Branch = 1,
    },

    Counterpart = new InvoiceCounterpartRequestModel()
    {
        VATNumber = "021496512",
        Country = CountryCode.GR,
        Branch = 0,
        PostalCode = "22222",
        City = "IRAKLIO"
    },

    InvoiceHeader = new InvoiceHeaderRequestModel()
    {
        Series = "A",
        AA = 101,
        IssueDate = new DateOnly(2020, 4, 8),
        InvoiceType = InvoiceType.SalesInvoice,
        Currency = CurrencyCode.EUR
    },

    PaymentMethods = new List<InvoicePaymentMethodRequestModel>()
    {
        new InvoicePaymentMethodRequestModel()
        {
            Type = PaymentMethod.POSOrEPOS,
            Amount = 5.00m
        },

    },

    InvoiceDetails = new List<InvoiceDetailRequestModel>()
    {
        new InvoiceDetailRequestModel()
        {
            LineNumber = 1,
            Quantity = 1,
            EntityName = "Νερό 50ml",
            VATCategory = VATCategory.VATRate13,
            VatCategoryUbl = VATCategoryUBL.StandardRate,
            NetValue = 5.00m,
            VATAmount = 1m,
            VATPercent = 13,
            TotalValue = 6,
            ClassificationType = IncomeClassificationType.E3_561_001,
            ClassificationCategory = IncomeClassificationCategory.Category1_2,
            LineComments = "Test comments",
            MeasurementUnit = MeasurementUnit.Pieces,
            MeasurementUnitUbl = UBLMeasurementUnit.ServiceUnit,
        }

    },

    InvoiceSummary = new InvoiceDetailSummaryRequestModel()
    {
        TotalNetValue = 5m,
        TotalVATAmount = 1m,
        TotalValue = 6m
    },
};

Console.WriteLine();
