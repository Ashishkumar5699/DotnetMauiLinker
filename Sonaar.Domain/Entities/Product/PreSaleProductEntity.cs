using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Sonaar.Domain.Bills;
using Sonaar.Domain.Entities.PreSale;
using Sonaar.Domain.Entities.Quotations;

namespace Sonaar.Domain.Entities.Product
{
	public class PreSaleProductEntity : ProductModel
    {
        [Key]
        public int PreSaleProductId { get; set; }

        public int PreSaleId { get; set; } // Foreign key for Quotation

        [JsonIgnore]
        public PreSaleEntity PreSaleEntity { get; set; } // Navigation property
    }
}

