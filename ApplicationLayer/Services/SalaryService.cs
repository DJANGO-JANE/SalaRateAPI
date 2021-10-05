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
        public async Task<Salary> GET_GROSS_SALARY(float basic, float? allowances)
        {
            Salary salary = new Salary();
            salary.BasicSalary = basic;
            _salary = salary;

            _salary.GrossSalary = _salary.BasicSalary + _salary.Allowances;

            Tax taxMan = new Tax();

            _salary.Taxable = taxMan.Taxify(_salary);
            return _salary;
        }

        public async Task<Salary> GET_NET_SALARY(float basic)
        {
            Salary salary = new Salary();
            salary.BasicSalary = basic;
            _salary = salary;

            Tax taxMan = new Tax();
            Pension pension = new();

            _salary.BasicSalary = basic;

            var temp = await GET_GROSS_SALARY(basic, null);
            _salary.GrossSalary = temp.GrossSalary;

            _salary.Taxable = taxMan.Taxify(_salary);
            _salary.NetSalary = _salary.Taxable;

            foreach (var tier in pension.EmployeeRate)
            {
                salary.Pension = tier.Value;
            }
            var tax_deductions = taxMan.Calculate_Tax_Deductions(_salary);

            foreach(var deduction in tax_deductions)
            {
                _salary.NetSalary -= deduction;
                _salary.PayE += deduction;
            }
            return _salary;
        }

    }
}
