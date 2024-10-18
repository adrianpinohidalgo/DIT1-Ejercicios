using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Gimnasio
{
    internal class Cliente
    {
        public int CodigoCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; }
        public int Telefono { get; set; }

        public Cliente() { }
        public Cliente(int codigoCliente, string nombre, string apellidos, DateTime fechaNacimiento, string ciudad, int telefono)
        {
            CodigoCliente = codigoCliente;
            Nombre = nombre;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            Ciudad = ciudad;
            Telefono = telefono;
        }
        public override string ToString()
        {
            return $"Código cliente: {CodigoCliente}. Nombre: {Nombre} {Apellidos}";
        }
    }
}
