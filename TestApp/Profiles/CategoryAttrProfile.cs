using AppDbContext.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.Profiles
{
    public class CategoryAttrProfile : Profile
    {
        public CategoryAttrProfile()
        {
            CreateMap<CategoryAttr, CategoryAttrViewModel>();
            CreateMap<CategoryAttr, CategoryAttrViewModel>().ReverseMap();
        }
    }
}
