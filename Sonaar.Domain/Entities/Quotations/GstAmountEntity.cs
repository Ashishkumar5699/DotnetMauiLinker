using System;
using System.ComponentModel.DataAnnotations;
using Sonaar.Domain.Bills;

namespace Sonaar.Domain.Entities.Quotations
{
	public class GstAmountEntity : GSTAmount
    {
        [Key]
        public int GstAmountId { get; set; }
    }
}

