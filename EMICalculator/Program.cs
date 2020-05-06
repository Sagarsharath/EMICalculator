using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMICalculator.Models;
using EMICalculator.BusinessCalc;

namespace EMICalculator
{
    class Program
    {
        private ICalculator _calculator = new Calculator();
        private static int months = 0;
        private static decimal principal = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Loan Amount");
            principal = getAmount();
            Console.WriteLine("Enter tenure in months");
            months = getMonths();
            if(principal>0 && months > 0)
            {
                var mainClass = new Program();
                mainClass.showDetails(principal, months);
            }
            else
            {
                Console.WriteLine("Loan Amount and tenure both should be greater than zero");
            }            
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();

        }
        /// <summary>
        /// Method to recieve proper input format from console for months
        /// </summary>
        /// <returns> no of months (int) </returns>
        private static int getMonths()
        {
            try
            {
              months = Convert.ToInt16(Console.ReadLine());
            }
            catch (System.FormatException fe)
            {
                Console.WriteLine("Please enter only integer numbers (No decimal values are allowed)");
                getMonths();
            }
            return months;
        }

        /// <summary>
        /// Method to recieve proper input format from console for Loan Amount
        /// </summary>
        /// <returns> Loan Amount (decimal) </returns>
        private static decimal getAmount()
        {
            try
            {
                principal = Convert.ToDecimal(Console.ReadLine());
            }
            catch (System.FormatException fe)
            {
                Console.WriteLine("Please enter only numbers");
                getAmount();
            }
            return principal;
        }
        /// <summary>
        /// Method to print the required details of EMI
        /// </summary>
        /// <param name="principal"></param>
        /// <param name="months"></param>
        private void showDetails(decimal principal, int months)
        {
            var response = _calculator.getEmiDetails(principal, months); // Business method to get all calculated details of EMI
            Console.WriteLine("1. Loan Creation Date : " + response.disbursalDate);
            Console.WriteLine("2. Principal Amount : " + response.principalAmount);
            Console.WriteLine("3. No of EMI's : " + response.noOfMonths);
            Console.WriteLine("4. Total Payable Amount : " + response.totalPayableAmount);
            Console.WriteLine("5. EMI Details : ");
            for(int i = 1; i <= months; i++)
            {
                // To print each month emi details
                var monthDetail = response.eachEmi[i - 1];
                Console.WriteLine("--> EMI No : " + monthDetail.emiNumber +
                    "Principal EMI  : " + monthDetail.principalEMiAmount+
                    "Intyerest EMI  : " + monthDetail.interestEMiAmount +
                    "Total EMI's : " + monthDetail.totalEMiAmount+
                    "EMI Date : " + monthDetail.emiDate+
                    "Principal Remaining : "+monthDetail.principalEMiAmount
                    );
            }
        }
    }
}
