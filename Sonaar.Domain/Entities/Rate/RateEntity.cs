using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sonaar.Domain.Dto.Rate;
using Sonaar.Domain.Entities.Authentication;

namespace Sonaar.Domain.Entities.Rate;

public class RateEntity : RateDto
{
    [Key]
    public int RateId { get; set; }
}
