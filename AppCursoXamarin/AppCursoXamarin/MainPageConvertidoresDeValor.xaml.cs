using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCursoXamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPageConvertidoresDeValor : ContentPage
	{
		public MainPageConvertidoresDeValor ()
		{
			InitializeComponent ();
		}
        private void OnClicked(object sender, EventArgs e)
        {
            //tomamos la referencia al objeto instanciado por xaml dentro del diccionario de recursos
            var datos1 = Resources["datos1"] as Datos;
            datos1.Discos.Add(new Disco() { Banda = "Nirvana", Titulo = "Nevermind" });
        }
    }
}