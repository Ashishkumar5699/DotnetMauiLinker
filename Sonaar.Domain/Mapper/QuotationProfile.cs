using System;
using AutoMapper;
using Sonaar.Domain.Bills;
using Sonaar.Domain.Dto.ReportGeneration;
using Sonaar.Domain.Entities.Product;
using Sonaar.Domain.Entities.Quotations;

namespace Sonaar.Domain.Mapper
{
	public class QuotationProfile : Profile
    {
		public QuotationProfile()
		{
			CreateMap<PrintBillDto, Quotation> ();
			CreateMap<ProductModel, ProductEntity>();
			CreateMap<GSTAmount, GstAmountEntity>();
		}
	}
}

