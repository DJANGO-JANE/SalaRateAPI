using DomainLayer.Models;
using InfrastructureLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services
{
    public class SalaryService : ISalary
    {

        public SalaryService()
        {

        }
        public float GET_GROSS_SALARY(float basic)
        {
            float allowances = 0.0f, gross_salary;
            gross_salary = basic + allowances;
            return gross_salary;
        }

        public float GET_NET_SALARY(float basic)
        {

            return GET_GROSS_SALARY(basic) - GET_INCOME_TAX(basic);
        }

        public float GET_INCOME_TAX(float basic)
        {

            return ((Salary.PensionFund / 100 * basic) + ((Salary.IncomeTax / 100) * basic));
        }

        public float EMPLOYEE_PENSION_AMOUNT(float basic)
        {
            return (Salary.PensionFund / 100) * basic;
        }
    }
}
