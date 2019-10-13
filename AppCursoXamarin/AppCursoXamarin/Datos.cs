using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppCursoXamarin
{
    public class Datos : NotificationObject
    {
        private ObservableCollection<Disco> discos;

        public ObservableCollection<Disco> Discos
        {
            get { return discos; }
            set
            {
                discos = value;
                OnPropertyChanged();
            }
        }
        //en el constructor de la clase instanciamos la colección y le agregamos 3 discos
        public Datos()
        {
            Discos = new ObservableCollection<Disco>();
            Discos.Add(new Disco() { Banda = "The beatles", Titulo = "Help!" });
            Discos.Add(new Disco() { Banda = "The beatles", Titulo = "Resolver!" });
            Discos.Add(new Disco() { Banda = "The beatles", Titulo = "Let it be!" });
        }

    }
}
