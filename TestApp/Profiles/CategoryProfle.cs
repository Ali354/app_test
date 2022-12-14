using AppDbContext.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.Profiles
{
    public class CategoryProfle : Profile
    {
        public CategoryProfle()
        {
            CreateMap<Category, CategoryViewModel>();
            CreateMap<Category, CategoryViewModel>().ReverseMap();
        }
    }
}
