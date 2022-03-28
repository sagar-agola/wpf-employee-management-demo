using Business.Repositories;
using Core.Enums;
using Core.Models;
using EmployeeManagement.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.ViewModels
{
    public class AddEmployeeViewModel : BaseViewModel
    {
        #region Binding Properties

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        private DepartmentTypeEnum _department;
        public DepartmentTypeEnum Department
        {
            get { return _department; }
            set
            {
                _department = value;
                OnPropertyChanged(nameof(Department));
            }
        }

        private string _salary;
        public string Salary
        {
            get { return _salary; }
            set
            {
                _salary = value;
                OnPropertyChanged(nameof(Salary));
            }
        }


        private List<KeyValuePair<DepartmentTypeEnum, string>> _departmentList;
        public List<KeyValuePair<DepartmentTypeEnum, string>> DepartmentList
        {
            get { return _departmentList; }
            set
            {
                _departmentList = value;
                OnPropertyChanged(nameof(DepartmentList));
            }
        }

        #endregion

        #region Commands

        public RelayCommand SaveCommand { get; set; }
        public RelayCommand CancelCommand { get; set; }

        #endregion

        private readonly NavigationStore _navigationStore;

        public AddEmployeeViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            SaveCommand = new RelayCommand(data => SaveEmployee());
            CancelCommand = new RelayCommand(data => RedirectToListPage());

            DepartmentList = Enum
                .GetValues(typeof(DepartmentTypeEnum))
                .Cast<DepartmentTypeEnum>()
                .Select(item => new KeyValuePair<DepartmentTypeEnum, string>(item, item.ToString()))
                .OrderBy(item => item.Value)
                .ToList();
        }

        private void SaveEmployee()
        {
            EmployeeRepository.Add(new Employee(0, _firstName, _lastName, _department, _salary));
            RedirectToListPage();
        }

        private void RedirectToListPage()
        {
            _navigationStore.CurrentViewModel = new EmployeeListViewModel(_navigationStore);
        }
    }
}
