using EmployeeManagement.Core;

namespace EmployeeManagement.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly NavigationStore _navigationStore;

        public BaseViewModel CurrentView => _navigationStore.CurrentViewModel;

        public MainViewModel()
        {
            _navigationStore = new NavigationStore();
            _navigationStore.CurrentViewModelChanged += () => OnPropertyChanged(nameof(CurrentView));
            _navigationStore.CurrentViewModel = new EmployeeListViewModel(_navigationStore);
        }
    }
}
