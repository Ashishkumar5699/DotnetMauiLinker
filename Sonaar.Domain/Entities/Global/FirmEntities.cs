using System;
using System.ComponentModel.DataAnnotations;
using Sonaar.Domain.Models.Company;

namespace Sonaar.Domain.Entities.Global;

public class FirmEntities : FirmDetail
{
    [Key]
    public int FirmId { get; set; }
}
