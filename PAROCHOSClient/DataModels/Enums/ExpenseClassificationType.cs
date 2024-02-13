namespace PAROCHOSClient
{
    /// <summary>
    /// Provides enumeration for the expenses classification type
    /// </summary>
    public enum ExpenseClassificationType
    {
        /// <summary>
        /// Launch merchandise
        /// </summary>
        E3_101,

        /// <summary>
        /// Purchases of consumer goods (net amount)/Wholesale
        /// </summary>
        E3_102_001,

        /// <summary>
        /// Purchases of consumer goods (net amount)/Retail
        /// </summary>
        E3_102_002,

        /// <summary>
        /// Purchases of consumer goods (net amount)/Goods of article 39a par.5 of the Code
        /// VAT (law 2859/2000)
        /// </summary>
        E3_102_003,

        /// <summary>
        /// Purchases of consumer goods (net amount)/Foreign Intra-Community
        /// </summary>
        E3_102_004,

        /// <summary>
        /// Purchases of goods for use (net amount)/Foreign Third Countries
        /// </summary>
        E3_102_005,

        /// <summary>
        /// Purchases of consumer goods (net amount) Other
        /// </summary>
        E3_102_006,

        /// <summary>
        /// Expiring goods
        /// </summary>
        E3_104,

        /// <summary>
        /// Raw materials and starting materials/Production
        /// </summary>
        E3_201,

        /// <summary>
        /// Purchases of raw materials and consumables (net amount)/Wholesale
        /// </summary>
        E3_202_001,

        /// <summary>
        /// Purchases of raw materials and consumables (net amount)/Retail
        /// </summary>
        E3_202_002,

        /// <summary>
        /// Purchases of raw materials and consumables (net amount)/Foreign Intra-Community
        /// </summary>
        E3_202_003,

        /// <summary>
        /// Purchases of raw materials and consumables (net amount)/Foreign Third Countries
        /// </summary>
        E3_202_004,

        /// <summary>
        /// Purchases of raw materials and consumables (net amount)/Other
        /// </summary>
        E3_202_005,

        /// <summary>
        /// Ending inventories of raw materials and materials/Production
        /// </summary>
        E3_204,

        /// <summary>
        /// Products and production in progress start/Production
        /// </summary>
        E3_207,

        /// <summary>
        /// Products and production in progress expiration/Production
        /// </summary>
        E3_209,

        /// <summary>
        /// Raw materials and starting materials/Agriculture
        /// </summary>
        E3_301,

        /// <summary>
        /// Purchases of raw materials and consumables (net amount)/Wholesale
        /// </summary>
        E3_302_001,

        /// <summary>
        /// Purchases of raw materials and consumables (net amount)/Retail
        /// </summary>
        E3_302_002,

        /// <summary>
        /// Purchases of raw materials and consumables (net amount)/Foreign Intra-Community
        /// </summary>
        E3_302_003,

        /// <summary>
        /// Purchases of raw materials and consumables (net amount)/Foreign Third Countries
        /// </summary>
        E3_302_004,

        /// <summary>
        /// Purchases of raw materials and consumables (net amount)/Other
        /// </summary>
        E3_302_005,

        /// <summary>
        /// Ending stocks of raw materials and materials/Agriculture
        /// </summary>
        E3_304,

        /// <summary>
        /// Products and production in progress start/Agriculture
        /// </summary>
        E3_307,

        /// <summary>
        /// Finishing products and production in progress/Agriculture
        /// </summary>
        E3_309,

        /// <summary>
        /// Starting stocks (animals - plants)
        /// </summary>
        E3_312,

        /// <summary>
        /// Purchases of animals - plants (net amount)/Wholesale
        /// </summary>
        E3_313_001,

        /// <summary>
        /// Purchases of animals - plants (net amount)/Retail
        /// </summary>
        E3_313_002,

        /// <summary>
        /// Purchases of animals - plants (net amount)/Foreign Intra-Community
        /// </summary>
        E3_313_003,

        /// <summary>
        /// Purchases of animals - plants (net amount)/Foreign Third Countries
        /// </summary>
        E3_313_004,

        /// <summary>
        /// Purchases of animals - plants (net amount)/Other
        /// </summary>
        E3_313_005,

        /// <summary>
        /// End stocks (animals - plants)/Agriculture
        /// </summary>
        E3_315,

        /// <summary>
        /// Employee benefits/Gross earnings
        /// </summary>
        E3_581_001,

        /// <summary>
        /// Employee benefits/Employer contributions
        /// </summary>
        E3_581_002,

        /// <summary>
        /// Employee benefits/Other benefits
        /// </summary>
        E3_581_003,

        /// <summary>
        /// Asset measurement losses
        /// </summary>
        E3_582,

        /// <summary>
        /// Debit exchange differences
        /// </summary>
        E3_583,

        /// <summary>
        /// Losses on disposal-withdrawal of non-current assets
        /// </summary>
        E3_584,

        /// <summary>
        /// Domestic - foreign management fees (management fees)
        /// </summary>
        E3_585_001,

        /// <summary>
        /// Expenses from affiliated businesses
        /// </summary>
        E3_585_002,

        /// <summary>
        /// Expenditure from non-cooperating states or from states with preferential tax status
        /// </summary>
        E3_585_003,

        /// <summary>
        /// Expenses for information days
        /// </summary>
        E3_585_004,

        /// <summary>
        /// Reception and hospitality expenses
        /// </summary>
        E3_585_005,

        /// <summary>
        /// Travel expenses
        /// </summary>
        E3_585_006,

        /// <summary>
        /// Self-Employed Insurance Contributions
        /// </summary>
        E3_585_007,

        /// <summary>
        /// Costs and commissions of consignee on behalf of farmers
        /// </summary>
        E3_585_008,

        /// <summary>
        /// Other Fees for domestic services
        /// </summary>
        E3_585_009,

        /// <summary>
        /// Other Fees for foreign services
        /// </summary>
        E3_585_010,

        /// <summary>
        /// Energy
        /// </summary>
        E3_585_011,

        /// <summary>
        /// Water supply
        /// </summary>
        E3_585_012,

        /// <summary>
        /// Telecommunications
        /// </summary>
        E3_585_013,

        /// <summary>
        /// Rentals
        /// </summary>
        E3_585_014,

        /// <summary>
        /// Advertising and display
        /// </summary>
        E3_585_015,

        /// <summary>
        /// Other Expenses
        /// </summary>
        E3_585_016,

        /// <summary>
        /// Debt interest and related costs
        /// </summary>
        E3_586,

        /// <summary>
        /// Depreciation
        /// </summary>
        E3_587,

        /// <summary>
        /// Unusual expenses, damages and fines
        /// </summary>
        E3_588,

        /// <summary>
        /// Provisions (except staff provisions)
        /// </summary>
        E3_589,

        /// <summary>
        /// Purchases of tangible assets for use/Wholesale
        /// </summary>
        E3_881_001,

        /// <summary>
        /// Purchases of tangible fixed assets/Retail
        /// </summary>
        E3_881_002,

        /// <summary>
        /// Purchases of tangible fixed assets for use/Foreign Intra-Community
        /// </summary>
        E3_881_003,

        /// <summary>
        /// Purchases of tangible fixed assets for use/Foreign Third Countries
        /// </summary>
        E3_881_004,

        /// <summary>
        /// Purchases of intangible fixed assets/Wholesale
        /// </summary>
        E3_882_001,

        /// <summary>
        /// Purchases of intangible fixed assets/Retail
        /// </summary>
        E3_882_002,

        /// <summary>
        /// Purchases of non-tangible fixed assets for use/Foreign Intra-Community
        /// </summary>
        E3_882_003,

        /// <summary>
        /// Purchases of intangible fixed assets for use/Foreign Third Countries
        /// </summary>
        E3_882_004,

        /// <summary>
        /// Purchases of intangible fixed assets/Wholesale
        /// </summary>
        E3_883_001,

        /// <summary>
        /// Purchases of intangible fixed assets/Retail
        /// </summary>
        E3_883_002,

        /// <summary>
        /// Purchases of non-tangible fixed assets for use/Foreign Intra-Community
        /// </summary>
        E3_883_003,

        /// <summary>
        /// Purchases of intangible fixed assets for use/Foreign Third Countries
        /// </summary>
        E3_883_004,

        /// <summary>
        /// Purchases and spending within the country
        /// </summary>
        VAT_361,

        /// <summary>
        /// Purchases and imports ind. Goods (fixed)
        /// </summary>
        VAT_362,

        /// <summary>
        /// Other non-expenditure imports Goods (fixed)
        /// </summary>
        VAT_363,

        /// <summary>
        /// Intra-Community acquisitions of goods
        /// </summary>
        VAT_364,

        /// <summary>
        /// Intra-community downloads of services art. 14.2.a
        /// </summary>
        VAT_365,

        /// <summary>
        /// Other actions of recipient
        /// </summary>
        VAT_366,

        /// <summary>
        /// Depreciation of goods
        /// </summary>
        E3_103,

        /// <summary>
        /// Impairment of raw materials and materials
        /// </summary>
        E3_203,

        /// <summary>
        /// Impairment of raw materials and materials
        /// </summary>
        E3_303,

        /// <summary>
        /// Impairment of products and production in progress
        /// </summary>
        E3_208,

        /// <summary>
        /// Impairment of products and production in progress
        /// </summary>
        E3_308,

        /// <summary>
        /// Impairment of animals - plants - goods
        /// </summary>
        E3_314,

        /// <summary>
        /// Own production of fixed assets - Self deliveries - Destruction of stocks
        /// </summary>
        E3_106,

        /// <summary>
        /// Own production of fixed assets - Self deliveries - Destruction of stocks
        /// </summary>
        E3_205,

        /// <summary>
        /// Own production of fixed assets - Self deliveries - Destruction of stocks
        /// </summary>
        E3_305,

        /// <summary>
        /// Own production of fixed assets - Self deliveries - Destruction of stocks
        /// </summary>
        E3_210,

        /// <summary>
        /// Own production of fixed assets - Self deliveries - Destruction of stocks
        /// </summary>
        E3_310,

        /// <summary>
        /// Own production of fixed assets - Self deliveries - Destruction of stocks
        /// </summary>
        E3_318,

        /// <summary>
        /// Purchases of goods subject to VAT
        /// </summary>
        E3_598_002
    }
}
