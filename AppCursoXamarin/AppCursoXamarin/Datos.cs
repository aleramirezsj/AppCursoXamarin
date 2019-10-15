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
        //agregamos esta propiedad para registrar cual es el disco seleccionado en la lista
        private Disco discoSeleccionado;

        public Disco DiscoSeleccionado
        {
            get { return discoSeleccionado; }
            set
            {
                discoSeleccionado = value;
                OnPropertyChanged();
            }
        }


        //en el constructor de la clase instanciamos la colección y le agregamos 3 discos
        public Datos()
        {
            Discos = new ObservableCollection<Disco>();
            Discos.Add(new Disco() {
                Banda = "The beatles",
                Titulo = "Help!",
                Genero ="Rock&Roll",
                FechaLanzamiento =new DateTime(1965,8,6),
                Portada ="help.jpg" });
            Discos.Add(new Disco() {
                Banda = "The beatles",
                Titulo = "Resolver!",
                Genero = "Rock&Roll",
                FechaLanzamiento = new DateTime(1966, 8, 6),
                Portada ="revolver.jpg" });
            Discos.Add(new Disco() {
                Banda = "The beatles",
                Titulo = "Let it be!",
                Genero = "Rock&Roll",
                FechaLanzamiento = new DateTime(1970, 5, 6),
                Portada ="letitbe.jpg" });
        }

    }
}
