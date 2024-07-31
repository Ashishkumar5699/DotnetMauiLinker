using System;
using Sonaar.Domain.Bills;
using Sonaar.Domain.Models.Bills;
using Sonaar.Domain.Models.Company;
using Sonaar.Domain.Models.Products;

namespace Sonaar.Common.Bills
{
	public class PrintBillModel
	{
		public int Billid { get; set; }

		public required DateTime DateofBill { get; set; }

        public required BillTypeEnum BillType { get; set; }

        public required Consumer Consumer { get; set; }

        public required List<ProductModel> ProductList { get; set; }

		public required GSTAmount GSTAmount { get; set; }

		public required FirmDetail FirmDetail { get; set; }
	}
}

