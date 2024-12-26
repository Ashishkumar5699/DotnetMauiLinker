using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sonaar.Domain.Dto.Rate;
using Sonaar.Domain.Entities.Authentication;

namespace Sonaar.Domain.Entities.Rate;

public class RateEntity : RateDto
{
    [ForeignKey("Id")]
    public required AppUser AddedBy { get; set; }
    
    [Key]
    public int RateId { get; set; }
}
