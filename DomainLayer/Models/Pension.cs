using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Pension
    {
        public Dictionary<int, float> EmployeeRate = new();
        public Dictionary<int, float> EmployerRate = new();

        public Pension()
        {
            EmployeeRate.Add(1, 0.0f);
            EmployeeRate.Add(2, 5.5f);
            EmployeeRate.Add(3, 5.0f);

            EmployerRate.Add(1, 13f);
            EmployerRate.Add(2, 0.0f);
            EmployerRate.Add(3, 5.0f);

        }
    }
}
