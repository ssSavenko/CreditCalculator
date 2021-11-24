using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAssignmentWPF.Models.Calculator;

namespace TestAssignmentWPF.Models.PercentCounters
{
    public class CreditIncomeFactory : ICalculatorFactory
    {
        public ICalculator AnnualTimeCalculator(double summ , double percent, DateTime time)
        {
            return new CalculatorWithAnnualPercentSummChanges(percent, summ,(time - DateTime.Now).Days/30 );
        }

        public ICalculator FullTimeCalculator(double summ, double percent, DateTime time)
        {
            return new CalculatorWithAnnualPercentSummChanges(percent, summ, (time - DateTime.Now).Days/30);
        }

        public ICalculator MounthTimeCalculator(double summ, double percent, DateTime time)
        {
            return new CalculatorWithAnnualPercentSummChanges(percent, summ, (time - DateTime.Now).Days/30);
        }
    }
}
