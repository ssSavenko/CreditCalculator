using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAssignmentWPF.Models.Calculator;

namespace TestAssignmentWPF.Models.PercentCounters
{
    public interface ICreditIncomeCalculator : ICalculator
    {

        int Mounthes { get; set; }
        double Summ { get; set; }
        double MounthPercent { get; set; } 

    }
}
