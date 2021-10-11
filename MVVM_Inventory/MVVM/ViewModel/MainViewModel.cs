using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_Inventory.Core;

namespace MVVM_Inventory.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public AuthViewModel AuthVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            AuthVM = new AuthViewModel();
            CurrentView = AuthVM;
        }

    }
}
