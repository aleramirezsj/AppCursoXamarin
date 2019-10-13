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
    public partial class MainPageInterfacesDeNotificacion : ContentPage
    {
        public MainPageInterfacesDeNotificacion()
        {
            InitializeComponent();
        }

    private void OnClicked(object sender, EventArgs e)
    {
        var disco1 = Resources["disco1"] as Disco;
        disco1.Titulo = "Resolver";

    }
}
}