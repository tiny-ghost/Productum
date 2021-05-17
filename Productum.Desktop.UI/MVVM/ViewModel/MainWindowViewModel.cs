using Productum.Desktop.UI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productum.Desktop.UI.MVVM.ViewModel
{
    class MainWindowViewModel: ObservableObject
    {
        private string _title = "Productum - Home";

        public string Title
        {
            get => _title; 
            set => Set(ref _title, value);
        }

    }
}
