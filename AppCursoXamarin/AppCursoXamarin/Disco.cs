using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AppCursoXamarin
{
    public class Disco : NotificationObject
    {
        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set
            {
                titulo = value;
                //este método está implementado en la clase abstracta NotificationObject
                OnPropertyChanged();
            }
        }

        private string banda;

        public string Banda
        {
            get { return banda; }
            set
            {
                banda = value;
                //este método está implementado en la clase abstracta NotificationObject
                OnPropertyChanged();
            }
        }
        /*(luego del refactoring al finalizar el video de interfaces de notificación, todo el 
         * siguiente código quedó implementado en la clase abstracta NotificationObject)
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            /*Este código que comprueba si un valor es nulo se puede hacer
             * con una sola linea
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }*/
            /*
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }*/
    }
}
