using System;
using Sonaar.Domain.Models.Products;
using Sonaar.Domain.Enum;
using Sonaar.Domain.Models.Company;
using Sonaar.Domain.Bills;

namespace Sonaar.Domain.Dto
{
	public class PrintBillDto
	{
        public int Billid { get; set; }

        public BillType BillType { get; set; }

        public DateTime DateofBill { get; set; }

        public FirmDetail FirmDetail { get; set; }

        public required Consumer Consumer { get; set; }

        public required List<ProductModel> ProductList { get; set; }

        public required GSTAmount GSTAmount { get; set; }
    }
}

