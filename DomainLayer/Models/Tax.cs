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
        /// <param name="gross">goss salary</param>
        /// <returns>funds remaining after pension deductions.</returns>
        public float Taxify(float gross)
        {
            return gross - (Salary.PensionFund/100);

        }
        public float[] Calculate_Tax(float taxable)
        {
            float[] taxes = new float[thresholds.Length];
            float remaining_funds = taxable, dummy = taxable;

            float minimum = thresholds[1];

            for(int i =0; i < thresholds.Length; i++)
            {
                float rate = rates[i];
                float tax = rate / 100;

                dummy = remaining_funds - thresholds[i];
                
                if(dummy > minimum)
                {

                    if(thresholds[i] == thresholds[thresholds.Length-1])
                    {
                        remaining_funds -= ((rates[rates.Length-1] / 100) * thresholds[i]);
                        taxes[i] = ((rates[rates.Length - 1] / 100) * thresholds[i]);

                    }
                    else
                    {
                        remaining_funds -= (tax * thresholds[i]);
                        taxes[i] = tax * thresholds[i];

                    }
                    continue;
                }

            }
            return taxes;
            //return total_taxable;
        }
    }
}
