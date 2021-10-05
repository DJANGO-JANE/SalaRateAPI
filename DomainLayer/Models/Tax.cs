using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Tax
    {
        public string Name { get; set; }
        public float[] rates = { 0, 5, 10, 17.5f, 25,30 };
        public float[] thresholds = { 319, 100, 120, 3000, 16461,20000 };

        /// <summary>
        /// Deduct all pension funds and another funds that need to be deducted before the funds are taxed
        /// </summary>
        /// <param name="salary">The salary to perform calculations on.</param>
        /// <returns>Funds remaining after pension deductions.</returns>
        public float Taxify(Salary salary)
        {
            salary.PensionAmount = (salary.BasicSalary * (salary.Pension/100));
            return salary.GrossSalary - salary.PensionAmount;
        }
        /// <summary>
        /// Calculates the tax for each chargeable income GH Cedi
        /// </summary>
        /// <param name="salary"></param>
        /// <returns></returns>
        public float[] Calculate_Tax_Deductions(Salary salary)
        {
            float[] taxes = new float[thresholds.Length];
            float remaining_funds = salary.Taxable;
            float open_wallet = 0.0f ;

            float minimum = thresholds[1];

            for(int i = 0; i < thresholds.Length; i++)
            {
                float rate = rates[i], tax = rate / 100;

                open_wallet = remaining_funds - thresholds[i];

                if (open_wallet > minimum)
                {
                    if (thresholds[i] >= thresholds[^1])
                    {
                        tax = rates[^1] / 100;

                        //remaining_funds -= (tax * (remaining_funds - thresholds[i]));
                        taxes[i] = tax * (remaining_funds);

                    }
                    else
                    {
                        remaining_funds -= (tax * thresholds[i]);
                        taxes[i] = tax * thresholds[i];
                    }
                }
            }
            return taxes;
        }

    
    }
}
