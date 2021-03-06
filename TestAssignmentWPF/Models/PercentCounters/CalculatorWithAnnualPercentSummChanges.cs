using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignmentWPF.Models.PercentCounters
{
    public class CalculatorWithAnnualPercentSummChanges : ICreditIncomeCalculator
    {
        private double mounthPercent;
        private double summ;
        private int mounthes;

        public CalculatorWithAnnualPercentSummChanges(double mounthPercent, double summ, int mounthes)
        {
            this.mounthPercent = mounthPercent;
            this.summ = summ;
            this.mounthes = mounthes;
        }

        public int Mounthes
        {
            get { return mounthes; }
            set { mounthes = value; }
        }

        public double Summ
        {
            get { return summ; }
            set { summ = value; }
        }

        public double MounthPercent
        {
            get { return mounthPercent; }
            set { mounthPercent = value; }
        }

        public double Calculte()
        {
            double recalculatedSumm = Summ;
            double payPerMounth = Summ / Mounthes;
            double resultValue = Summ;
            for (int i = mounthes; i > 0; i -= 12)
            { 
                resultValue += (i > 12 ? 12 : i) * recalculatedSumm / 100 * MounthPercent;
                recalculatedSumm = recalculatedSumm - payPerMounth * 12;
            }
            return resultValue;
        }
    }
}
