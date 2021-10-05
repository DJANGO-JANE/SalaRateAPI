using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.DTO
{
    public class SalaryNet
    {
        public float BasicSalary { get; set; }
        public float Pension { get; set; }
        public float PensionAmount { get; set; }
        public float Taxable { get; set; }
        public float NetSalary { get; set; }
        public float PayE { get; set; }
        public Dictionary<int, float> EPCA { get; set; }

    }
}
