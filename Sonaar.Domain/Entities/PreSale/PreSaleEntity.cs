using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sonaar.Domain.Entities.Contacts;
using Sonaar.Domain.Entities.Product;
using Sonaar.Domain.Entities.Quotations;
using Sonaar.Domain.Enum;
using Sonaar.Domain.Models.Company;

namespace Sonaar.Domain.Entities.PreSale;

public partial class PreSaleEntity 
{
    [Key]
    public int PreSaleId { get; set; }

    public int Billid { get; set; }

    public BillType BillType { get; set; }

    public DateTime DateofBill { get; set; }

    //public FirmDetail FirmDetail { get; set; }

    [ForeignKey("ContactId")]
    public required ContactDetails ContactDetails { get; set; }

    [ForeignKey("ProductId")]
    public required List<ProductEntity> ProductList { get; set; }

    [ForeignKey("GstAmountId")]
    public required GstAmountEntity GSTAmount { get; set; }
    
}
