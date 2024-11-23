using System;
using Sonaar.Domain.Bills;
using Sonaar.Domain.Enum;

namespace Sonaar.Domain.Dto.ReportGeneration;

public class GenerateQuotationDTO
{      
    public int Billid { get; set; }
    public BillType BillType { get; set; }
    public required int Firmid { get; set; }
    public required int ConsumerID { get; set; }
    public required List<ProductModel> ProductList { get; set; }
    public required GSTAmount GSTAmount { get; set; }
}