using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DemoObjetoNegocio
{
    internal partial class Persona : ObservableObject
    {
        //public string Nombre { get; set; }
        //public int Edad { get; set; }

        //Genera al compilar el código de la propiedad Nombre y Edad, y además implementa INotifyPropertyChanged
        [ObservableProperty]
        private string? _nombre;
        //public string? Nombre
        //{
        //    get { return _nombre; }
        //    set { SetProperty(ref _nombre, value); }
        //}

        //Cuando implementaba INotifyPropertyChanged, el código era así:
        //    set
        //    {
        //        if (_nombre != value)
        //        {
        //            _nombre = value;
        //            NotifyPropertyChanged("Nombre"); //Notificar el cambio de propiedad
        //        }
        //    }
        //}

        [ObservableProperty]
        private int _edad;
        //public int Edad
        //{
        //    get { return _edad; }
        //    set { SetProperty(ref _edad, value); }

            //Cuando implementaba INotifyPropertyChanged, el código era así:
            //set
            //{
            //    if (_edad != value)
            //    {
            //        _edad = value;
            //        NotifyPropertyChanged("Edad"); //Notificar el cambio de propiedad
            //    }
            //}
        

        public Persona()
        {
            Nombre = string.Empty;
            Edad = 0;
        }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        //public event PropertyChangedEventHandler? PropertyChanged;

        //public void NotifyPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}


    }
}
