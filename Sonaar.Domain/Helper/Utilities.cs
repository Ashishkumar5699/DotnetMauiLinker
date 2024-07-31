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
    }
}

