using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.DTO
{
    public class SalaryGross
    {
        public float BasicSalary { get; set; }
        public float Taxable { get; set; }
        public float ConveyanceAllowance { get; set; }
        public float HouseRentAllowance { get; set; }
        public float TaxPaid { get; set; }
    }
}
