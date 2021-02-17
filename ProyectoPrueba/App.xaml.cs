using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProyectoPrueba.Apps;

namespace ProyectoPrueba
{
    public partial class App : Application
    {
        public static MasterDetailPage MasterD { get; set; }

        public App()
        {
            InitializeComponent();
            MainPage = new LoginPage();
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
