using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPrueba
{
   public  class Rutas
    {
        public string NombreRuta { get; set; }
        public string Descripcion { get; set; }
        public string  Estado { get; set; }
        public string Imagen { get; set; }

        public override string ToString()
        {
            return NombreRuta;
        }
    }
}
