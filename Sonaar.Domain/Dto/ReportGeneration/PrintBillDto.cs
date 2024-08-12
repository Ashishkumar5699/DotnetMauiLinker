using Sonaar.Domain.Enum;
using Sonaar.Domain.Models.Company;
using Sonaar.Domain.Bills;
using Sonaar.Domain.Dto.CustomerDirectory;

namespace Sonaar.Domain.Dto.ReportGeneration
{
    public class PrintBillDto
	{
        public int Billid { get; set; }

        public BillType BillType { get; set; }

        public DateTime DateofBill { get; set; }

        public FirmDetail FirmDetail { get; set; }

        public required ConsumerDTO Consumer { get; set; }

        public required List<ProductModel> ProductList { get; set; }

        public required GSTAmount GSTAmount { get; set; }
    }
}

