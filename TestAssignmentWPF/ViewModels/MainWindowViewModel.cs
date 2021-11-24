//using Mvvm.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TestAssignmentWPF.Views;

namespace TestAssignmentWPF.ViewModels
{
    public sealed class MainWindowViewModel : INotifyPropertyChanged
    {

        private UserControl debtReturnEncounterControlPanel;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowViewModel()
        {
            debtReturnEncounterControlPanel = new DeptReturnEncounter(new DeptReturnEncounterViewModel(15));
        }


        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }


        public UserControl CurrentControlPanel { get { return debtReturnEncounterControlPanel; } }
    }
}