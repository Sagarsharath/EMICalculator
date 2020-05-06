using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMICalculator.Models;

namespace EMICalculator.BusinessCalc
{
    interface ICalculator
    {
        /// <summary>
        /// Method to return emi details as whole after calculation
        /// </summary>
        /// <param name="principal"></param>
        /// <param name="tenure"></param>
        /// <returns> EMIInfo </returns>
        EMIInfo getEmiDetails(decimal principal, int tenure);        
    }
}
