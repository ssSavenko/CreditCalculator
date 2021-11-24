using Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestAssignmentWPF.Models.Calculator;
using TestAssignmentWPF.Models.PercentCounters;

namespace TestAssignmentWPF.ViewModels
{
    public class DeptReturnEncounterViewModel : INotifyPropertyChanged
    {
        private DateTime agreementDate = DateTime.Now;

        private int currentYearCount = 1;
        private int maxYearCount = 10;

        private decimal x = 0;
        private double r = 0;
        private string resultData = "";

        private ICommand calculateCommand;
        private ICalculatorFactory calculatorFactory; 

        public DeptReturnEncounterViewModel()
        {
            InitCommands();
            InitFactories();
        }

        public DeptReturnEncounterViewModel(int maxYearCount)
        {
            this.maxYearCount = maxYearCount;

            InitCommands();
            InitFactories();
        }

        #region initBase

        private void InitCommands()
        {
            calculateCommand = new DelegateCommand(CalculateIncome); 
        }


        private void InitFactories()
        {
            calculatorFactory = new CreditIncomeFactory();
        }

        #endregion initBase
         

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }


        public int MaxYearCount
        {
            get => maxYearCount;
        }

        public int CurrentYearCount
        {
            get { return currentYearCount; }
            set
            {
                currentYearCount = value;
                ResultData = "";
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentYearCount)));
            }
        }

        public string R
        {
            get => r.ToString();
            set
            {
                if (!double.TryParse(value, out r))
                {
                    r = 0;
                }
                ResultData = "";
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(R)));
            }
        }

        public string X
        {
            get => x.ToString();
            set
            {
                if (!decimal.TryParse(value, out x))
                {
                    x = 0;
                }
                ResultData = "";
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(X)));
            }
        }

        public DateTime AgreementDate
        {
            get => agreementDate;
            set
            {
                agreementDate = value;
                ResultData = "";
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(X)));
            }
        }

        public string ResultData
        {
            get { return resultData; }
            set {
                resultData = "";
                if (value != "")
                    resultData = $"you will receive {value} on {agreementDate.AddYears(CurrentYearCount).ToString()}";

                OnPropertyChanged(new PropertyChangedEventArgs(nameof(ResultData))); 
            }
        }

        public ICommand Calculate => calculateCommand;

        public void CalculateIncome()
        {
            ICalculator currentCalculator = calculatorFactory.FullTimeCalculator(double.Parse(X), double.Parse(R) / 12, DateTime.Now.AddMonths(CurrentYearCount * 12));
                
            ResultData = ((decimal)currentCalculator.Calculte()).ToString();
        }

    }
}
