using System;

namespace Mozzeno.API.Calculators
{
    public static class InstalmentAmountCalculator
    {
        /// <summary>
        ///     Calculates the monthly instalment amount.
        /// </summary>
        /// <param name="amount">The amount of the loan.</param>
        /// <param name="rate">The nominal rate expressed as a decimal (e.g. 5.10% is 0.051).</param>
        /// <param name="months">The number of months.</param>
        /// <returns>The monthly instalment amount.</returns>
        public static decimal Calculate(decimal amount, decimal rate, int months)
        {
            double calculatedAmount;
            var monthlyRate = (double)rate / 12;
            if (monthlyRate <= 0)
            {
                calculatedAmount = (double)amount / months;
                return Convert.ToDecimal(calculatedAmount);
            }

            var exponent = Math.Pow(1 + monthlyRate, months);
            var instalmentAmount = (double)amount * monthlyRate * exponent / (exponent - 1);
            return Convert.ToDecimal(instalmentAmount);
        }
    }
}