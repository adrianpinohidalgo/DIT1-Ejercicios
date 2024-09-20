using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Abstraccion
{
    internal class CasaDelTerror : Atraccion
    {
        private int NivelDeMiedo { get; set; }

        public CasaDelTerror(string nombre, int edadMinima, int alturaMinima, decimal precio, int nivelDeMiedo) : base(nombre, edadMinima, alturaMinima, precio)
        {
            NivelDeMiedo = nivelDeMiedo;
        }

        public override bool AdmitirVisitante(int edad, int altura)
        {
            //if (edad < 14 || altura < 130)
            if (base.AdmitirVisitante(edad, altura))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No puede pasar");
                return false;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Puede pasar");
            return true;
        }


    }
}
