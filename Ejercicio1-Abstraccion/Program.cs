using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Abstraccion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CASA DEL TERROR DE LA FERIA DE MONTILLA");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Ingresa la edad del visitante: ");
            try
            {
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la altura del visitante: ");
                int altura = int.Parse(Console.ReadLine());

                CasaDelTerror casaDelTerror = new CasaDelTerror("Casa del Terror", 14, 130, 100, 10);

                casaDelTerror.AdmitirVisitante(edad, altura);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingresa una edad valida");
            }

            Console.ResetColor();
        }
    }
}
