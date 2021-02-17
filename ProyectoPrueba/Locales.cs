using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPrueba
{
    public class Locales
    {
        public string Nombre { get; set; }
        public string  Descripcion { get; set; }
        public string Imagen { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
