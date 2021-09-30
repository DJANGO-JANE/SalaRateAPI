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
            Tax taxMan = new Tax();
            float net = 0.0f;
            float gross_salary = GET_GROSS_SALARY(basic);

            float tax_deductible = taxMan.Taxify(gross_salary);

            var tax_deductions = taxMan.Calculate_Tax(tax_deductible);

            foreach(var deduction in tax_deductions)
            {
                net -= deduction;
            }
            return net;
        }

        public float GET_INCOME_TAX(float basic)
        {

            throw new NotImplementedException();
        }

        public float EMPLOYEE_PENSION_AMOUNT(float basic)
        {
            throw new NotImplementedException();
        }
    }
}
