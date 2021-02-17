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
    public partial class ListadoRutas : ContentPage
    {
        public IList<Rutas> Rutas { get; private set; }
        public ListadoRutas()
        {
            InitializeComponent();
            Rutas = new List<Rutas>();

            Rutas.Add(new Rutas
            {
                Imagen = "Estado.png",
                NombreRuta = "RUTA 001",
                Descripcion = "RUTA DE REPOSICION"


            });
            Rutas.Add(new Rutas
            {
                Imagen = "Estado.png",
                NombreRuta = "RUTA 002",
                Descripcion = "RUTA DE REPOSICION"


            });
            Rutas.Add(new Rutas
            {
                Imagen = "Estado.png",
                NombreRuta = "RUTA 003",
                Descripcion = "RUTA DE REPOSICION"


            });
            BindingContext = this;
        }


        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushModalAsync(new MainPage("Locales"));
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
      
}