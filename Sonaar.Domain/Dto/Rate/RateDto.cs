using System;
using System.ComponentModel.DataAnnotations.Schema;
using Sonaar.Domain.Entities.Authentication;

namespace Sonaar.Domain.Dto.Rate;

public class RateDto
{
    public decimal Gold24K { get; set; } 

    public decimal Gold22K { get; set; } 

    public decimal Gold18K { get; set; } 
    
    public decimal Gold14K { get; set; }     
    
    public decimal Silver70 { get; set; }

    public decimal Silver925 { get; set; } 

    [ForeignKey("Id")]
    public required AppUser AddedBy { get; set; }

    public DateTime AddedOn { get; set; } 

    public DateTime Expireon { get; set; } 
}
