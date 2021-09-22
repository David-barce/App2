using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using App2.ViewModels;

namespace App2.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string nombrePropiedad)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nombrePropiedad));
        }
    }
}
