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
    public partial class ReporteLista : ContentPage
    {
        public ReporteLista()
        {
            InitializeComponent();
            webViewLink.Source = ResFull.urlbase + "consulta-formularios/"+Settings.IsIdIn;
        }
    }
}