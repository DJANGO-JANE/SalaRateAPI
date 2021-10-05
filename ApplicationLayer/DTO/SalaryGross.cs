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
        public float? Allowances { get; set; }
    }
}
