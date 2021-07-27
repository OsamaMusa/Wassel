using AutoMapper;
using Domain.Entities;
using Domain.Entities.Base;
using Domain.Model;
using Domain.Model.Base;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wassel.ServicesConfigurations
{
    public static class AutoMapperConfiguration
    {
        public static IServiceCollection ConfigureMapper(this IServiceCollection services)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Car, CarVM>().ReverseMap();
                cfg.CreateMap<Customer, CustomerVM>().ReverseMap();
                cfg.CreateMap<Item, ItemVM>().ReverseMap();
                cfg.CreateMap<Package, PackageVM>().ReverseMap();
                cfg.CreateMap<Location, LocationVM>().ReverseMap();
                cfg.CreateMap<Order, OrderVM>().ReverseMap();
                cfg.CreateMap<ParentEntityVM, EntityBase>().ReverseMap();
                cfg.CreateMap<PackageItemsVM, PackageItems>().ReverseMap();


            });
            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }

    }
}
