using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Interfaces
{
    public interface ISalary
    {
        public float GET_GROSS_SALARY(float basic);
        public float GET_NET_SALARY(float basic);
        public float EMPLOYEE_PENSION_AMOUNT(float basic);
    }
}
