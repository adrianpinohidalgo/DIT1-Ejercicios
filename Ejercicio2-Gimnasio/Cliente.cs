using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Gimnasio
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int CodigoCliente { get; set; }

        public Cliente() { }
        public Cliente(string nombre, string apellidos, int codigoCliente)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            CodigoCliente = codigoCliente;
        }
        public override string ToString()
        {
            return $"Código cliente: {CodigoCliente}. Nombre: {Nombre} {Apellidos}";
        }
    }
}
