namespace PAROCHOSClient
{

    /// <summary>
    /// Provides enumeration over the UBL VAT categories
    /// </summary>
    public enum VATCategoryUBL
    {
        /// <summary>
        /// Vat Reverse Charge (Code: AE)
        /// </summary>
        /// <remarks>
        /// Code specifying that the standard VAT rate is levied from the invoice.
        /// </remarks>
        VatReverseCharge,

        /// <summary>
        /// Exempt from Tax (Code: E)
        /// </summary>
        /// <remarks>
        /// Code specifying that taxes are not applicable.
        /// </remarks>
        ExemptFromTax,

        /// <summary>
        /// Standard rate (Code: S)
        /// </summary>
        /// <remarks>
        /// Code specifying the standard rate.
        /// </remarks>
        StandardRate,

        /// <summary>
        /// Zero rated goods (Code: Z)
        /// </summary>
        /// <remarks>
        /// Code specifying that the goods are at a zero rate.
        /// </remarks>
        ZeroRatedGoods,

        /// <summary>
        /// Free export item, VAT not charged (Code: G)
        /// </summary>
        /// <remarks>
        /// Code specifying that the item is free export and taxes are not charged.
        /// </remarks>
        FreeExportItem_VATNotCharged,

        /// <summary>
        /// Services outside scope of tax (Code: O)
        /// </summary>
        /// <remarks>
        /// Code specifying that taxes are not applicable to the services.
        /// </remarks>
        ServicesOutsideScopeOfTax,

        /// <summary>
        /// VAT exempt for EEA intra-community supply of goods and services (Code: K)
        /// </summary>
        /// <remarks>
        /// A tax category code indicating the item is VAT exempt due to an intra-community supply in the European Economic Area.
        /// </remarks>
        VATExemptForEEAIntraCommunitySupplyOfGoodsAndServices,

        /// <summary>
        /// Canary Islands general indirect tax (Code: L)
        /// </summary>
        /// <remarks>
        /// Impuesto General Indirecto Canario (IGIC) is an indirect tax levied on goods and services supplied in the Canary Islands (Spain) by traders and professionals, as well as on import of goods.
        /// </remarks>
        CanaryIslandsGeneralIndirectTax,

        /// <summary>
        /// Tax for production, services and importation in Ceuta and Melilla (Code: M)
        /// </summary>
        /// <remarks>
        /// Impuesto sobre la Producción, los Servicios y la Importación (IPSI) is an indirect municipal tax, levied on the production, processing and import of all kinds of movable tangible property, the supply of services and the transfer of immovable property located in the cities of Ceuta and Melilla.
        /// </remarks>
        TaxForProduction_ServicesAndImportationInCeutaAndMelilla,

        /// <summary>
        /// Transferred (VAT), In Italy (Code: B)
        /// </summary>
        /// <remarks>
        /// VAT not to be paid to the issuer of the invoice but directly to relevant tax authority. This code is allowed in the EN 16931 for Italy only based on the Italian A-deviation.
        /// </remarks>
        Transferred_VAT_InItaly,
    }
}