using System;

namespace PAROCHOSClient
{
    /// <summary>
    /// Helpers related to numbers
    /// </summary>
    public static class NumericHelpers
    {
        #region Constants

        public const uint DefaultDecimalPrecision = 2;

        public const MidpointRounding DefaultMode = MidpointRounding.AwayFromZero;

        #endregion

        #region Public Methods

        /// <summary>
        /// Calculates the rate based on the <paramref name="amount"/> and the <paramref name="netAmount"/>.
        /// Ex.: 24% -> 24.
        /// </summary>
        /// <param name="amount">The amount</param>
        /// <param name="netAmount">The net amount</param>
        /// <param name="decimals">The number of decimals that the result should get rounded to</param>
        /// <param name="mode">The midpoint rounding mode</param>
        /// <returns></returns>
        public static decimal CalculateRateFromAmountAndNetAmount(decimal amount, decimal netAmount, uint decimals, MidpointRounding mode)
        {
            if (netAmount == 0)
                return 0;

            return Math.Round(100 * ((amount / netAmount) - 1), (int)decimals, mode);
        }

        /// <summary>
        /// Calculates the rate based on the <paramref name="amount"/> and the <paramref name="netAmount"/>
        /// </summary>
        /// <param name="amount">The amount</param>
        /// <param name="netAmount">The net amount</param>
        /// <returns></returns>
        public static decimal CalculateRateFromAmountAndNetAmount(decimal amount, decimal netAmount)
            => CalculateRateFromAmountAndNetAmount(amount, netAmount, DefaultDecimalPrecision, DefaultMode);

        /// <summary>
        /// Calculates the amount based on the <paramref name="netAmount"/> and the tax <paramref name="rate"/>
        /// </summary>
        /// <param name="netAmount">The net amount</param>
        /// <param name="rate">
        /// The tax rate.
        /// The tax rate isn't passed as the percentage representation!
        /// Ex.: 24% -> 24
        /// </param>
        /// <param name="decimals">The number of decimals that the result should get rounded to</param>
        /// <param name="mode">The midpoint rounding mode</param>
        /// <returns></returns>
        public static decimal CalculateAmountFromNetAmount(decimal netAmount, decimal rate, uint decimals, MidpointRounding mode)
            => Math.Round(netAmount * ((rate / 100) + 1), (int)decimals, mode);

        /// <summary>
        /// Calculates the amount based on the <paramref name="netAmount"/> and the tax <paramref name="rate"/>
        /// </summary>
        /// <param name="netAmount">The net amount</param>
        /// <param name="rate">
        /// The tax rate.
        /// The tax rate isn't passed as the percentage representation!
        /// Ex.: 24% -> 24
        /// </param>
        /// <returns></returns>
        public static decimal CalculateAmountFromNetAmount(decimal netAmount, decimal rate)
            => CalculateAmountFromNetAmount(netAmount, rate, DefaultDecimalPrecision, DefaultMode);

        /// <summary>
        /// Calculates the net amount based on the <paramref name="amount"/> and the tax <paramref name="rate"/>
        /// </summary>
        /// <param name="amount">The amount</param>
        /// <param name="rate">
        /// The tax rate.
        /// The tax rate isn't passed as the percentage representation!
        /// Ex.: 24% -> 24
        /// </param>
        /// <param name="decimals">The number of decimals that the result should get rounded to</param>
        /// <param name="mode">The midpoint rounding mode</param>
        /// <returns></returns>
        public static decimal CalculateNetAmountFromAmount(decimal amount, decimal rate, uint decimals, MidpointRounding mode)
            => Math.Round(amount / ((rate / 100) + 1), (int)decimals, mode);

        /// <summary>
        /// Calculates the net amount based on the <paramref name="amount"/> and the tax <paramref name="rate"/>
        /// </summary>
        /// <param name="amount">The amount</param>
        /// <param name="rate">
        /// The tax rate.
        /// The tax rate isn't passed as the percentage representation!
        /// Ex.: 24% -> 24
        /// </param>
        /// <returns></returns>
        public static decimal CalculateNetAmountFromAmount(decimal amount, decimal rate)
            => CalculateNetAmountFromAmount(amount, rate, DefaultDecimalPrecision, DefaultMode);

        /// <summary>
        /// Calculates the net amount based on the <paramref name="taxAmount"/> and the tax <paramref name="rate"/>
        /// </summary>
        /// <param name="taxAmount">The tax amount</param>
        /// <param name="rate">
        /// The tax rate.
        /// The tax rate isn't passed as the percentage representation!
        /// Ex.: 24% -> 24
        /// </param>
        /// <param name="decimals">The number of decimals that the result should get rounded to</param>
        /// <param name="mode">The midpoint rounding mode</param>
        /// <returns></returns>
        public static decimal CalculateNetAmountFromTaxAmount(decimal taxAmount, decimal rate, uint decimals, MidpointRounding mode)
        {
            if (rate == 0)
                return 0;

            return Math.Round(taxAmount / (rate / 100), (int)decimals, mode);
        }

        /// <summary>
        /// Calculates the net amount based on the <paramref name="taxAmount"/> and the tax <paramref name="rate"/>
        /// </summary>
        /// <param name="taxAmount">The tax amount</param>
        /// <param name="rate">
        /// The tax rate.
        /// The tax rate isn't passed as the percentage representation!
        /// Ex.: 24% -> 24
        /// </param>
        /// <returns></returns>
        public static decimal CalculateNetAmountFromTaxAmount(decimal taxAmount, decimal rate)
            => CalculateNetAmountFromTaxAmount(taxAmount, rate, DefaultDecimalPrecision, DefaultMode);

        /// <summary>
        /// Calculates the commission amount based on the <paramref name="amount"/> and
        /// the <paramref name="percentCommission"/>
        /// </summary>
        /// <param name="amount">The amount</param>
        /// <param name="percentCommission">
        /// The percent commission.
        /// NOTE: That's a value from 0 to 100!
        /// </param>
        /// <returns></returns>
        public static decimal CalculatePercentCommissionAmount(decimal amount, decimal percentCommission)
            => amount * (percentCommission / 100);

        /// <summary>
        /// Calculates the flat rate commission amount based on the <paramref name="amount"/>
        /// and the <paramref name="flatRateCommission"/>
        /// </summary>
        /// <param name="amount">The amount</param>
        /// <param name="flatRateCommission">The flat rate commission</param>
        /// <returns></returns>
        public static decimal CalculateFlatRateCommissionAmount(decimal amount, decimal flatRateCommission)
            => flatRateCommission;

        /// <summary>
        /// Rounds the specified <paramref name="amount"/> using the specified options
        /// </summary>
        /// <param name="amount">The amount</param>
        /// <param name="decimalsPrecision">The decimals precision</param>
        /// <param name="mode">The midpoint rounding mode</param>
        /// <returns></returns>
        public static decimal Round(decimal amount, uint decimalsPrecision, MidpointRounding mode)
        {
            return Math.Round(amount, (int)decimalsPrecision, mode);
        }

        /// <summary>
        /// Rounds the specified <paramref name="amount"/> using the specified options
        /// </summary>
        /// <param name="amount">The amount</param>
        /// <returns></returns>
        public static decimal Round(decimal amount)
            => Round(amount, DefaultDecimalPrecision, DefaultMode);

        #endregion
    }
}
