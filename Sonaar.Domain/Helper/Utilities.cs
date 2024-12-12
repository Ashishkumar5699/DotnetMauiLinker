using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sonaar.Domain.Helper
{
	public static class Utilities
	{
        public static decimal GetAmount(decimal rate, decimal making_charges, decimal weight)
        {
            var total_rate = rate + making_charges;
            return total_rate * weight;
        }

        public static string ConvertAmountToWords(int amount)
        {
            if (amount == 0)
                return "Zero";

            string[] units = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            string words = "";

            // Billion
            if (amount >= 1000000000)
            {
                words += ConvertAmountToWords(amount / 1000000000) + " Billion ";
                amount %= 1000000000;
            }

            // Million
            if (amount >= 1000000)
            {
                words += ConvertAmountToWords(amount / 1000000) + " Million ";
                amount %= 1000000;
            }

            // Thousand
            if (amount >= 1000)
            {
                words += ConvertAmountToWords(amount / 1000) + " Thousand ";
                amount %= 1000;
            }

            // Hundred
            if (amount >= 100)
            {
                words += ConvertAmountToWords(amount / 100) + " Hundred ";
                amount %= 100;
            }

            // Tens and Units
            if (amount >= 20)
            {
                words += tens[amount / 10] + " ";
                amount %= 10;
            }
            else if (amount >= 10)
            {
                words += teens[amount - 10] + " ";
                amount = 0;
            }

            if (amount > 0)
            {
                words += units[amount] + " ";
            }

            return words.Trim();
        }

    }
}

