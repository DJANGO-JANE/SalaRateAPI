using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Salary
    {
        private float BasicSalary { get; set; }
        public static float PensionFund = 5;
        public float GrossSalary { get; set; }


        public static float pensionFund
        {
            get { return PensionFund; }
            set { PensionFund = value; }
        }

        public float basicSalary
        {
            get { return BasicSalary; }
            set { BasicSalary = value; }
        }
    }
}
