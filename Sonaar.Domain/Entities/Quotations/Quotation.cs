using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sonaar.Domain.Entities.Contacts;
using Sonaar.Domain.Entities.Product;
using Sonaar.Domain.Enum;

namespace Sonaar.Domain.Entities.Quotations
{
    public class Quotation
    {
        [Key]
        public int QuotationId { get; set; }

        public int Billid { get; set; }//random

        public BillType BillType { get; set; } //emun

        public DateTime DateofBill { get; set; }

        //public FirmDetail FirmDetail { get; set; }

        [ForeignKey("ContactId")]
        public required ContactDetails ContactDetails { get; set; }

        [ForeignKey("ProductId")]
        public required List<ProductEntity> ProductList { get; set; }

        [ForeignKey("GstAmountId")]
        public required GstAmountEntity GSTAmount { get; set; }
    }
}