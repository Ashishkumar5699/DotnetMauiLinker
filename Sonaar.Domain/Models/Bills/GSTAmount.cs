using System;
namespace Sonaar.Domain.Bills
{
    public class GSTAmount
    {
        
        public decimal Total { get; set; }

        public decimal CGSt { get; set; }

        public decimal SGST { get; set; }

        public decimal IGST { get; set; }

        public decimal GrandTotal { get; set; }

    }
}