using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Gimnasio
{
    internal class Program
    {

        public static List<Cliente> clientes = new List<Cliente>();
        public static string password = "1234";
        static void Main(string[] args)
        {
            int opt = 0;
            while (opt != 8)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Menú del Gimnasio");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("1. Dar de alta cliente.");
                Console.WriteLine("2. Mostrar clientes.");
                Console.WriteLine("3. Modificar clientes.");
                Console.WriteLine("4. Eliminar clientes.");
                Console.WriteLine("5. Borrar todos los clientes (Administrador).");
                Console.WriteLine("6. Guardar clientes en un archivo JSON.");
                Console.WriteLine("7. Cargar clientes de un archivo JSON.");
                Console.WriteLine("8. Salir.");
                Console.WriteLine("---------------------------------------------");
                Console.Write("Seleccione una opción: ");
                opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Funciones.AltaCliente(clientes);
                        break;

                    case 2:
                        Funciones.MostrarClientes(clientes);
                        break;
                    case 3:
                        Funciones.ModificarCliente(clientes);
                        break;
                    case 4:
                        Funciones.EliminarCliente(clientes);
                        break;
                    case 5:
                        Funciones.BorrarClientes(clientes, password);
                        break;
                    case 6:
                        Funciones.GuardarClientes(clientes);
                        break;
                    case 7:
                        Funciones.CargarClientes(clientes);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }
                Console.ResetColor();
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
