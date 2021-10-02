using ApplicationLayer.DTO;
using AutoMapper;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Profiles
{
    public class SalaryProfile : Profile
    {
        public SalaryProfile()
        {
            CreateMap<Salary, SalaryView>();
            CreateMap<Salary, SalaryGross>();
            CreateMap<Salary, SalaryNet>();
        }
    }
}
