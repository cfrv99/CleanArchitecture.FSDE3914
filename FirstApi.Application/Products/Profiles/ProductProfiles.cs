using AutoMapper;
using FirstApi.Application.Products.Requests;
using FirstApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Application.Products.Profiles
{
    public class ProductProfiles : Profile
    {
        public ProductProfiles()
        {
            CreateMap<AddProductRequest, Product>().ForMember(x => x.Price, y => y.MapFrom(i => i.Amount));
        }
    }
}
