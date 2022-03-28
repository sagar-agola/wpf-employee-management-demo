using Business.Repositories;
using EmployeeManagement.Core;

namespace EmployeeManagement.ViewModels
{
    public class EmployeeListViewModel : BaseViewModel
    {
        #region Commands

        public RelayCommand AddEmployeeCommand { get; set; }

        #endregion

        private readonly NavigationStore _navigationStore;

        public EmployeeListViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            AddEmployeeCommand = new RelayCommand(data => _navigationStore.CurrentViewModel = new AddEmployeeViewModel(navigationStore));

            var x = EmployeeRepository.GetAll();
        }
    }
}
