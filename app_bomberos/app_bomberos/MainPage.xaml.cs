using app_bomberos.vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace app_bomberos
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            inciarAnimacion();
        }

        private async void inciarAnimacion()
        {
            await Task.Delay(200);
            await btnIniciar.FadeTo(0, 250);
            await Task.Delay(200);
            await btnIniciar.FadeTo(1, 250);
        }

       async private void Iniciar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }
    }
}
