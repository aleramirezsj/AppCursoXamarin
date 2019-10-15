using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppCursoXamarin
{
    public class Datos : NotificationObject
    {
        private ObservableCollection<Disco> discos;
        //agregamos esta propiedad para registrar cual es el disco seleccionado en la lista
        private Disco discoSeleccionado;
        //agregamos una propiedad que implemente la interfaz ICommand para colocar código de 
        //ejecución de un comando
        public MyComand agregarDiscoCommand { get; set; }



        public ObservableCollection<Disco> Discos
        {
            get { return discos; }
            set
            {
                discos = value;
                OnPropertyChanged();
            }
        }


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
                Portada ="help.jpg",
                Precio=(decimal)4.5});
            Discos.Add(new Disco() {
                Banda = "The beatles",
                Titulo = "Resolver!",
                Genero = "Rock&Roll",
                FechaLanzamiento = new DateTime(1966, 8, 6),
                Portada ="revolver.jpg",
                Precio=(decimal)5});
            Discos.Add(new Disco() {
                Banda = "The beatles",
                Titulo = "Let it be!",
                Genero = "Rock&Roll",
                FechaLanzamiento = new DateTime(1970, 5, 6),
                Portada ="letitbe.jpg",
                Precio=(decimal)8});

            agregarDiscoCommand = new MyComand(agregarDiscoCommandExecute,agregarDiscoCommandCanExecute);
        }

        private bool agregarDiscoCommandCanExecute()
        {
            return Discos.Count<10;
        }

        private void agregarDiscoCommandExecute()
        {
            Discos.Add(new Disco() { Banda = "Nirvana", Titulo = "Nevermind" });
            agregarDiscoCommand.ReEvaluateCanExecute();

        }



       

    }
}
