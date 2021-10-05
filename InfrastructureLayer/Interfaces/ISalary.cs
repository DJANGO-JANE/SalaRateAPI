using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Interfaces
{
    public interface ISalary
    {
        public Task<Salary> GET_GROSS_SALARY(float basic, float? allowances);
        public Task<Salary> GET_NET_SALARY(float basic);
        //public Task<Salary> DetailsFromNetSalary(float net,float allowances);
    }
}
