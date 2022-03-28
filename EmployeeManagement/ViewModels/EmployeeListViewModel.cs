using Business.Repositories;
using Core.Models;
using EmployeeManagement.Core;
using System.Collections.ObjectModel;

namespace EmployeeManagement.ViewModels
{
    public class EmployeeListViewModel : BaseViewModel
    {
        #region Binding Properties

        private ObservableCollection<Employee> _employees;
        public ObservableCollection<Employee> Employees
        {
            get { return _employees; }
            set
            {
                _employees = value;
                OnPropertyChanged(nameof(Employees));
            }
        }

        #endregion

        #region Commands

        public RelayCommand AddEmployeeCommand { get; set; }

        #endregion

        private readonly NavigationStore _navigationStore;

        public EmployeeListViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            AddEmployeeCommand = new RelayCommand(data => _navigationStore.CurrentViewModel = new AddEmployeeViewModel(navigationStore));

            Employees = new ObservableCollection<Employee>(EmployeeRepository.GetAll());
        }
    }
}
