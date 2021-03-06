﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoPrueba
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListadoLocales : ContentPage
    {
        public IList<Locales> locales { get; private set; }
        public ListadoLocales()
        {
            InitializeComponent();
            locales = new List<Locales>();

            locales.Add(new Locales
            {
                Imagen = "Carro.png",
                Nombre ="Local Alameda",
                Descripcion="Local alameda"

            });
            locales.Add(new Locales
            {
                Imagen="Tienda.png",
                Nombre = "Local Alameda 2",
                Descripcion = "Local alameda 2"

            });
            BindingContext = this;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushModalAsync(new MainPage("InfoRutas"));
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}