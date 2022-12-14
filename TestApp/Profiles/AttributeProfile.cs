using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Models;
using AppDbContext.Models;
namespace TestApp.Profiles
{
    public class AttributeProfile :Profile
    {
        public AttributeProfile()
        {
            CreateMap<AppDbContext.Models.Attribute, AttributeViewModel>();
            CreateMap<AppDbContext.Models.Attribute, AttributeViewModel>().ReverseMap();
        }
    }
}
