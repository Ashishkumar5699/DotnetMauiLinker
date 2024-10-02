using System;
using Microsoft.Extensions.DependencyInjection;

namespace Sonaar.Domain.Mapper
{
	public static class MapperExtension
	{

        public static IServiceCollection AddAutoSetting(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ContactProfile));
            services.AddAutoMapper(typeof(QuotationProfile));
            return services;
        }

    }
}

