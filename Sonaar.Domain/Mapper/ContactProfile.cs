using System;
using AutoMapper;
using Sonaar.Domain.Dto.CustomerDirectory;
using Sonaar.Domain.Entities.Contacts;

namespace Sonaar.Domain.Mapper
{
	public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<ConsumerDTO, ContactDetails>();
        }
	}
}
