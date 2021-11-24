using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignmentWPF.Models.PercentCounters
{
    public class CalculatorWithoutPercentChanges: ICreditIncomeCalculator 
    {
        private double mounthPercent;
        private double summ;
        private int mounthes;

        public CalculatorWithoutPercentChanges(double mounthPercent , double summ, int mounthes)
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
            double resultValue = Summ + Mounthes * Summ / 100 * MounthPercent;
            return resultValue;
        }
    }
}
