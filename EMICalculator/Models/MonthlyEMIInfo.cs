
namespace EMICalculator.Models
{
    /// <summary>
    /// Attributes for a month
    /// </summary>
    public class MonthlyEMIInfo
    {        
        public int emiNumber { get; set; }
        public decimal principalEMiAmount { get; set; }
        public decimal interestEMiAmount { get; set; }
        public decimal totalEMiAmount { get; set; }
        public string emiDate { get; set; }
        public decimal pendingAmount { get; set; }

    }
}