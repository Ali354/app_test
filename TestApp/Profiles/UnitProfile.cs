using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDbContext.Models;
using TestApp.Models;

namespace TestApp.Profiles
{
    public class UnitProfile:Profile
    {
        public UnitProfile()
        {
            CreateMap<Unit, UnitViewModel>();
            CreateMap<Unit, UnitViewModel>().ReverseMap();
        }
    }
}
