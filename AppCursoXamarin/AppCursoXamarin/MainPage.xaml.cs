using AppCursoXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCursoXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //btnAgregar.TextColor = Color.Blue;

            MessagingCenter.Subscribe<MainPageViewModel>(this, "AddSurvey", async (a) =>
            {
                await Navigation.PushModalAsync(new SurveyDetailsView());
            });
            //EJEMPLO 2 DE MANEJO DE EVENTOS - CON CÓDIGO
            //boton.Clicked += OnClicked;

            //EJEMPLO 3 DE MANEJO DE EVENTOS - CON EXPRESIONES LAMBDA
            /*boton.Clicked += (s, a) =>
            {
                etiqueta.Text = "Hola " + DateTime.Now.ToString();
            };*/

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //recibimos la referencia al botón que fue pulsado
            var boton = sender as Button;
            /*var columna = (int)boton.GetValue(Grid.ColumnProperty);
            if (columna == 0)
            {
                boton.SetValue(Grid.ColumnProperty, 1);
            }
            else
            {
                boton.SetValue(Grid.ColumnProperty, 0);
            }*/
            var columna = (int)Grid.GetColumn(boton);
            if (columna == 0)
            {
                Grid.SetColumn(boton, 1);
            }
            else
            {
                Grid.SetColumn(boton, 0);
            }


        }

        private async void OnClicked(object sender, EventArgs e)
        {
            // etiqueta.Text += "La hora es " + DateTime.Now.ToString();
            //código del video 30
            //boton1.ScaleTo(2, 2000, Easing.BounceOut); 
            //await Navigation.PushAsync(new Pagina2());
            //await Navigation.PushModalAsync(new Pagina2());
            var resultado = await DisplayActionSheet("Opciones", null, null, "Argentina", "Chile", "Uruguay");
            await DisplayAlert("País seleccionado", "Es:"+resultado, "Aceptar");
        }
    }
}
