using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ProyectoPrueba.Apps;

namespace ProyectoPrueba
{
    public partial class MainPage : MasterDetailPage
    {
        
        public MainPage(string ruta)
        {

            InitializeComponent();
            this.Master = new Master();
            switch (ruta) {
                case "Uno":
                    this.Title = "Pagina Uno";
                    this.Detail = new NavigationPage(new Detalle());
                break;
                case "Ruta":
                    this.Title = "Rutas Asignadas";
                    this.Detail = new NavigationPage(new ListadoRutas ());
                    break;
                case "Locales":
                    this.Detail = new NavigationPage(new ListadoLocales());
                    break;
                case "InfoRutas":
                    this.Detail = new NavigationPage(new InformacionRuta());
                    break;
                case "InfoTrabajos":
                    this.Detail = new NavigationPage(new InformacionTrabajo());
                    break;
            }
            
            App.MasterD = this;
           
        }

       
    }
}
