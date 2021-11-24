using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignmentWPF.Models.Calculator
{
    public interface ICalculatorFactory
    {
        ICalculator FullTimeCalculator(double value1, double value2, DateTime time);
        ICalculator AnnualTimeCalculator(double value1, double value2, DateTime time);
        ICalculator MounthTimeCalculator(double value1, double value2, DateTime time);
    }
}
