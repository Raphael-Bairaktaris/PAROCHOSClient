namespace PAROCHOSClient
{
    /// <summary>
    /// Provides enumeration over the PEPPOL allowance reason codes
    /// </summary>
    /// <remarks>
    /// https://docs.peppol.eu/poacc/billing/3.0/codelist/UNCL5189/
    /// </remarks>
    public enum PEPPOLAllowanceReasonCode
    {
        /// <summary>
        /// Bonus for works ahead of schedule (Code: 41)
        /// </summary>
        BonusForWorksAheadOfSchedule,

        /// <summary>
        /// Other bonus (Code: 42)
        /// </summary>
        OtherBonus,

        /// <summary>
        /// Manufacturer’s consumer discount (Code: 60)
        /// </summary>
        ManufacturersConsumerDiscount,

        /// <summary>
        /// Due to military status (Code: 62)
        /// </summary>
        DueToMilitaryStatus,

        /// <summary>
        /// Due to work accident (Code: 63)
        /// </summary>
        DueToWorkAccident,

        /// <summary>
        /// Special agreement (Code: 64)
        /// </summary>
        SpecialAgreement,

        /// <summary>
        /// Production error discount (Code: 65)
        /// </summary>
        ProductionErrorDiscount,

        /// <summary>
        /// New outlet discount (Code: 66)
        /// </summary>
        NewOutletDiscount,

        /// <summary>
        /// Sample discount (Code: 67)
        /// </summary>
        SampleDiscount,

        /// <summary>
        /// End-of-range discount (Code: 68)
        /// </summary>
        EndOfRangeDiscount,

        /// <summary>
        /// Incoterm discount (Code: 70)
        /// </summary>
        IncotermDiscount,

        /// <summary>
        /// Point of sales threshold allowance (Code: 71)
        /// </summary>
        PointOfSalesThresholdAllowance,

        /// <summary>
        /// Material surcharge/deduction (Code: 88)
        /// </summary>
        MaterialSurchargeOrdeduction,

        /// <summary>
        /// Discount (Code: 95)
        /// </summary>
        Discount,

        /// <summary>
        /// Special rebate (Code: 100)
        /// </summary>
        SpecialRebate,

        /// <summary>
        /// Fixed long term (Code: 102)
        /// </summary>
        FixedLongTerm,

        /// <summary>
        /// Temporary (Code: 103)
        /// </summary>
        Temporary,

        /// <summary>
        /// Standard (Code: 104)
        /// </summary>
        Standard,

        /// <summary>
        /// Yearly turnover (Code: 105)
        /// </summary>
        YearlyTurnover,
    }
}