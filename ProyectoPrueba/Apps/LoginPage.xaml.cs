using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPrueba.Apps;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoPrueba.Apps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
      
        public LoginPage()
        {
            InitializeComponent();
            btninciar.Clicked += Btninciar_Clicked1;

        }

        private void Btninciar_Clicked1(object sender, EventArgs e)
        {

            string usuario = txtUsuarios.Text;
            if (usuario != "")
            {
                Navigation.PushModalAsync(new MainPage("Ruta"));
            }
        }

       
    }
}