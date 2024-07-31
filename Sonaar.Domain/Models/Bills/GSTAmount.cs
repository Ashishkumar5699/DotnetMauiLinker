using System;
namespace Sonaar.Domain.Bills
{
	public class GSTAmount
    {
        public decimal TotalBeforeDiscount { get; set; }

        public decimal Discount { get; set; }

        public decimal TotalAfterDiscount { get; set; }

        public decimal CGSt { get; set; }

        public decimal SGST { get; set; }

        public decimal IGST { get; set; }

        public decimal GrandTotal { get; set; }
    }
}

