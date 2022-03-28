﻿using EmployeeManagement.ViewModels;
using System;

namespace EmployeeManagement.Core
{
    public class NavigationStore
    {
        public event Action CurrentViewModelChanged;

        private BaseViewModel _currentViewModel;

        public BaseViewModel CurrentViewModel
        {
            get { return _currentViewModel; }
            set
            {
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        public void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
