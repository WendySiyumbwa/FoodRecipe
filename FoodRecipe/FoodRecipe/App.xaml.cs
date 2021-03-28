using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FoodRecipe.Pages;


namespace FoodRecipe
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new Foods());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
