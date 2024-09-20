using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Abstraccion
{
    internal class Atraccion
    {
        private string Nombre { get; set; }
        private int EdadMinima { get; set; }
        private int AlturaMinima { get; set; }
        private decimal Precio { get; set; }

        public Atraccion(string nombre, int edadMinima, int alturaMinima, decimal precio)
        {
            Nombre = nombre;
            EdadMinima = edadMinima;
            AlturaMinima = alturaMinima;
            Precio = precio;
        }

        public virtual bool AdmitirVisitante(int edad, int altura)
        {
            if (edad > EdadMinima && altura > AlturaMinima) return false;

            return true;
        }


    }
}
