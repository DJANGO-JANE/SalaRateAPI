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
        private Salary _salary;



        public SalaryService()
        {

        }
        public async Task<Salary> GET_GROSS_SALARY(float basic)
        {
            Salary salary = new Salary();
            salary.BasicSalary = basic;
            _salary = salary;

            float gross_salary;
            gross_salary = _salary.BasicSalary + _salary.ConveyanceAllowance + _salary.HouseRentAllowance;
            _salary.GrossSalary = gross_salary;
            return _salary;
        }

        public async Task<Salary> GET_NET_SALARY(float basic)
        {
            Salary salary = new Salary();
            salary.BasicSalary = basic;
            _salary = salary;


            Tax taxMan = new Tax();

            _salary.BasicSalary = basic;
            var temp = await GET_GROSS_SALARY(basic);
            _salary.GrossSalary = temp.GrossSalary;

            _salary.Taxable = taxMan.Taxify(_salary);

            var tax_deductions = taxMan.Calculate_Tax_Deductions(_salary);

            foreach(var deduction in tax_deductions)
            {
                _salary.Taxable -= deduction;
                _salary.TaxPaid += deduction;
            }
            _salary.NetSalary = _salary.Taxable;
            return _salary;
        }

        public Task<float> GET_INCOME_TAX(float basic)
        {

            throw new NotImplementedException();
        }

        public Task<float> EMPLOYEE_PENSION_AMOUNT(float basic)
        {
            throw new NotImplementedException();
        }
    }
}
