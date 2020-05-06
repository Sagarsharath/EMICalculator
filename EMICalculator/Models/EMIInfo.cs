using System.Collections.Generic;

namespace EMICalculator.Models
{
    /// <summary>
    /// Basic EMI Details
    /// </summary>
    public class EMIInfo
    {
        public decimal principalAmount { get; set; }
        public string disbursalDate { get; set; }
        public int noOfMonths { get; set; }
        public List<MonthlyEMIInfo> eachEmi { get; set; }
        public decimal totalPayableAmount { get; set; }
    }
}