using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Sonaar.Domain.Bills;
using Sonaar.Domain.Entities.Quotations;

namespace Sonaar.Domain.Entities.Product
{
	public class ProductEntity : ProductModel
    {
        [Key]
        public int ProductId { get; set; }

        public int QuotationId { get; set; } // Foreign key for Quotation

        [JsonIgnore]
        public Quotation Quotation { get; set; } // Navigation property
    }
}

