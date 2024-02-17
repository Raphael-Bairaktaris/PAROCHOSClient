// See https://aka.ms/new-console-template for more information

using PAROCHOSClient;

var credentials = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "PAROCHOSClientCredentials.txt")).Split(Environment.NewLine);

var client = new PAROCHOSClient.PAROCHOSClient(new PAROCHOSCredentials(credentials[0], credentials[1], credentials[2]));

var requestModel = new IncomeInvoiceRequestModel()
{
    Issuer = new InvoiceIssuerRequestModel()
    {
        VATNumber = "000000000",
        Country = CountryCode.GR,
        Branch = 1,
        City = "Patras",
        PostalCode = "26441",
        Street = "Marathonos",
        StreetNumber = 2
    },

    Counterpart = new InvoiceCounterpartRequestModel()
    {
        Name = "Dimitris Kalantzis",
        VATNumber = "802011000",
        Country = CountryCode.GR,
        Branch = 0,
        PostalCode = "22222",
        City = "IRAKLIO"
    },

    Header = new InvoiceHeaderRequestModel()
    {
        Series = "A",
        AA = 102,
        IssueDate = DateOnly.FromDateTime(DateTime.Now),
        InvoiceType = InvoiceType.SalesInvoice,
        PEPPOLInvoiceTypeCode = PEPPOLInvoiceTypeCode.CommercialInvoice,
        Currency = CurrencyCode.EUR
    },

    Details = new List<IncomeInvoiceDetailRequestModel>()
    {
        new IncomeInvoiceDetailRequestModel()
        {
            EntityName = "Νερό 500ml",
            Quantity = 10,
            Amount = 5,
            VATCategory = VATCategory.VATRate13,
            PEPPOLDutyOrTaxOfFeeCategoryCode = PEPPOLDutyOrTaxOfFeeCategoryCode.StandardRate,
            ClassificationType = IncomeClassificationType.E3_561_001,
            ClassificationCategory = IncomeClassificationCategory.Category1_2,
            LineComments = "Test comments",
            MeasurementUnit = MeasurementUnit.Pieces,
            PEPPOLRecommendationCode = PEPPOLRecommendationCode.ServiceUnit,
        }
    },
}
    .SetPayment(PaymentMethod.Cash);

var invoiceResult = await client.SendIncomeInvoiceAsync(requestModel);

var receipt = File.ReadAllBytes(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "1.pdf"));

var uploadFileToAzureResult = await client.UploadPDFFileAsync(new UploadFileRequestRequestModel()
{
    ExternalSystemId = invoiceResult.Result.ExternalSystemId,
    FileName = "receipt.pdf",
    FileSize = receipt.Length,
}, receipt);

Console.WriteLine();
