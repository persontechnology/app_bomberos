using app_bomberos.Helpers;
using app_bomberos.vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app_bomberos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (Settings.IsLoggedIn == true)
            {
                MainPage = new NavigationPage(new Inicio());
            }
            else
            {
                MainPage = new NavigationPage(new MainPage());
            }
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
