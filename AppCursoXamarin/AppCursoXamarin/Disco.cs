using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AppCursoXamarin
{
    public class Disco : INotifyPropertyChanged
    {
        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set
            {
                titulo = value;
                OnPropertyChanged("Titulo");
            }
        }

        private string banda;

        public string Banda
        {
            get { return banda; }
            set
            {
                banda = value;
                OnPropertyChanged("Banda");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            /*Este código que comprueba si un valor es nulo se puede hacer
             * con una sola linea
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }*/
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
