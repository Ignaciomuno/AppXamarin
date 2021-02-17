using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoPrueba
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void btnRutas_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            Title = "Rutas";
            Navigation.PushModalAsync(new MainPage("Ruta"));
        }

        private void btnRutas2_Clicked(object sender, EventArgs e)
        {

        }
    }
}