using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDbContext.Models;
using AutoMapper;
using TestApp.Models;

namespace TestApp.Profiles
{
    public class ValueAttrProfile: Profile
    {
        public ValueAttrProfile()
        {
            CreateMap<ValueAttr, ValueAttrViewModel>();
            CreateMap<ValueAttr, ValueAttrViewModel>().ReverseMap();
        }
    }
}
