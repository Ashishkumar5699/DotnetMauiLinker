using System;
using AutoMapper;
using Sonaar.Domain.Bills;
using Sonaar.Domain.Dto.CustomerDirectory;
using Sonaar.Domain.Dto.ReportGeneration;
using Sonaar.Domain.Entities.Contacts;
using Sonaar.Domain.Entities.Product;
using Sonaar.Domain.Entities.Quotations;

namespace Sonaar.Domain.Mapper
{
	public class QuotationProfile : Profile
    {
		public QuotationProfile()
		{
			CreateMap<PrintBillDto, Quotation> ()
					.ForMember(dest => dest.ContactDetails, opt => opt.MapFrom(src => src.Consumer));
			CreateMap<ProductModel, ProductEntity>();
			CreateMap<GSTAmount, GstAmountEntity>();

			CreateMap<ProductModel, PreSaleProductEntity>();


		}
	}
}

