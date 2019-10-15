using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppCursoXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new MainPage());
            //MainPage = new MainPage();
            //MainPage = new MainPageInterfacesDeNotificacion();
            //MainPage = new MainPageObservableCollection();
            //MainPage = new MainPageContextoDeEnlaceDeDatos();
            //MainPage = new MainPageReto3();
            //MainPage = new MainPageEnlaceEntreElementos();
            //MainPage = new MainPageStringFormat();
            //MainPage = new MainPagePlantillaDeDatos();
            //MainPage = new MainPageConvertidoresDeValor();
            MainPage = new MainPageImplementacionComandos();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
