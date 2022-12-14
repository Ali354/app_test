using AppDbContext.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.Profiles
{
    public class ProductAttrProfile : Profile
    {
        public ProductAttrProfile()
        {
            CreateMap<ProductAttr, ProductAttrViewModel>();
            CreateMap<ProductAttr, ProductAttrViewModel>().ReverseMap();
        }
    }
}
