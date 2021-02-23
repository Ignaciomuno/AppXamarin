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
    public partial class InformacionRuta : ContentPage
    {
        public IList<Rutas> Rutas { get; private set; }
        public InformacionRuta()
        {
            InitializeComponent();
            Rutas = new List<Rutas>();

            Rutas.Add(new Rutas
            {
                Imagen = "Agregar.png",
                NombreRuta = "AGREGAR PRODUCTOS",
                Descripcion = "AGREGAR MENBLA001 FILA 3 PO..."



            });
            Rutas.Add(new Rutas
            {
                Imagen = "Reponer.png",
                NombreRuta = "REPONER PRODUCTOS",
                Descripcion = "AGREGAR PRODUCTOS EN FILA 5 ..."


            });
            Rutas.Add(new Rutas
            {
                Imagen = "Otros.png",
                NombreRuta = "OTROS",
                Descripcion = "REVISAR INSTALACION DE JEFE A.."


            });
            BindingContext = this;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushModalAsync(new MainPage("InfoTrabajos"));
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}