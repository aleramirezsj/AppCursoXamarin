using AppCursoXamarin.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppCursoXamarin.ViewModels
{
    public class SurveyDetailsViewModel : NotificationObject
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        private string favoriteFood;

        public string FavoriteFood
        {
            get { return favoriteFood; }
            set {
                favoriteFood = value;
                OnPropertyChanged();
            }
        }

        public ICommand SaveCommand
        { get; set; }

        public SurveyDetailsViewModel()
        {
            SaveCommand = new Command(() =>
             {
                 var newSurvey = new Survey() { Name = this.name, FavoriteFood = this.FavoriteFood };
                 MessagingCenter.Send(this, "SaveSurvey", newSurvey);
             });
        }


    }
}
