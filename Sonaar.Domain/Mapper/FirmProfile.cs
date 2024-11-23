using System;
using Sonaar.Domain.Entities.Global;
using Sonaar.Domain.Models.Company;
using AutoMapper;

namespace Sonaar.Domain.Mapper;

public class FirmProfile : Profile
{
    public FirmProfile()
    {
        CreateMap<FirmDetail, FirmEntities>();
    }
}
