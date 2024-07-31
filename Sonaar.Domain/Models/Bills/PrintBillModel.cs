using System;
using Sonaar.Common.Models.Products;

namespace Sonaar.Common.Bills
{
	public class PrintBillModel
	{
		public int Billid { get; set; }

		public required Consumer Consumer { get; set; }

        public required List<ProductModel> ProductList { get; set; }

		public required GSTAmount GSTAmount { get; set; }
	}
}

