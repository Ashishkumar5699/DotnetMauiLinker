using System;
using PunjabOrnaments.Common.Models.Products;

namespace PunjabOrnaments.Common.Bills
{
	public class PrintBillModel
	{
		public int Billid { get; set; }

		public Consumer Consumer { get; set; }

        public List<ProductModel> ProductList { get; set; }
		public GSTAmount GSTAmount { get; set; }
	}
}

