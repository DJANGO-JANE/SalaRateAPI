using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Salary
    {
        public float BasicSalary { get; set; }
        public static float PensionFund { get; set; } = 5;
        public float GrossSalary { get; set; } = 0.0f;
        public float ConveyanceAllowance { get; set; } = 0.0f;
        public float HouseRentAllowance { get; set; } = 0.0f;
        public float Taxable { get; set; } = 0.0f;
        public float NetSalary { get; set; } = 0.0f;
        public float TaxPaid { get; set; }

    }
}
