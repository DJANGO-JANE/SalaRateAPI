using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Salary
    {
        public float BasicSalary { get; set; } = 0.0f;
        public float Pension { get; set; } = 5;
        public float GrossSalary { get; set; } = 0.0f;
        public float PensionAmount { get; set; } = 0.0f;
        public float Allowances { get; set; } = 0.0f;
        public float Taxable { get; set; } = 0.0f;
        public float NetSalary { get; set; } = 0.0f;
        public float PayE { get; set; }
        public float EPA { get; set; }
        public Dictionary<int, float> EPCA = new();
        public void MakePensionContributions()
        {
            Pension pen = new();


            foreach (var rate in pen.EmployeeRate)
            {
                PensionAmount = (BasicSalary * (rate.Value / 100));
                EPCA.Add(rate.Key, PensionAmount);
            }
        }
    }
}
