﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Productum.Desktop.UI.Core
{
    internal abstract class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(name));
        }

        protected virtual bool Set<T> (ref T field, T value, [CallerMemberName] string name =null)
        {
            if(Equals(field,value))
            {
                return false;
            }

            field = value;
            OnPropertyChanged(name);
            return true;
        }
    }
}
