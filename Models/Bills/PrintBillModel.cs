using System;
using Sonaar.Common.Models.Products;

namespace Sonaar.Common.Bills
{
	public class PrintBillModel
	{
		public int Billid { get; set; }

		public Consumer Consumer { get; set; }

        public List<ProductModel> ProductList { get; set; }
		public GSTAmount GSTAmount { get; set; }
	}
}

