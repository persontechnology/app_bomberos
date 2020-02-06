using app_bomberos.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app_bomberos.vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

         async private void ListaEmergencia(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReporteLista());
        }

       async private void EmergenciasHoy(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReporteHoy());
        }

       async private void Salir(object sender, EventArgs e)
        {
            Settings.IsEmailIn = "";
            Settings.IsPerfilIn = "";
            Settings.IsUserdIn = "";
            Settings.IsIdIn = 0;
            Settings.IsLoggedIn = false;
            Application.Current.MainPage = new NavigationPage(new MainPage());
            await Navigation.PushAsync(new Login());
        }
    }
}