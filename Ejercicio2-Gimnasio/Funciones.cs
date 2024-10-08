using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Ejercicio2_Gimnasio
{
    internal class Funciones
    {
        public static void AltaCliente(List<Cliente> clientes)
        {
            Random r = new Random();
            Console.Write("Introduzca su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduzca sus apellidos: ");
            string apellidos = Console.ReadLine();
            int codigo = r.Next(1000);

            Cliente cliente = new Cliente(nombre, apellidos, codigo);

            try
            {
                clientes.Add(cliente);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Cliente dado de alta correctamente.");
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No se ha podido dar de alta el cliente.");
            }
        }

        public static void MostrarClientes(List<Cliente> clientes)
        {
            //foreach (var cliente in clientes)
            //{
            //    cliente.ToString();
            //}

            for (int i = 0; i < clientes.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {clientes[i].ToString()}");
            }
        }

        public static void ModificarCliente(List<Cliente> clientes)
        {
            MostrarClientes(clientes);
            Console.Write("Seleccione un cliente: ");
            int opt = int.Parse(Console.ReadLine());

            Console.Write("Introduzca el nuevo nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduzca los nuevos apellidos: ");
            string apellidos = Console.ReadLine();

            clientes[opt - 1].Nombre = nombre;
            clientes[opt - 1].Apellidos = apellidos;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cliente modificado correctamente.");
        }

        public static void EliminarCliente(List<Cliente> clientes)
        {
            MostrarClientes(clientes);
            Console.Write("Seleccione un cliente: ");
            int opt = int.Parse(Console.ReadLine());
            Console.WriteLine("¿ESTAS SEGUR@ DE QUE QUIERES BORRAR ESTE CLIENTE? y/n");
            string res = Console.ReadLine();

            if (res.Equals("y"))
            {
                clientes.RemoveAt(opt - 1);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Cliente eliminado.");
            }
        }

        public static void BorrarClientes(List<Cliente> clientes, string password)
        {
            Console.Write("Introduce la contraseña de administrador: ");
            string pass = Console.ReadLine();

            if (pass.Equals(password))
            {
                clientes.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Todos los clientes han sido borrados.");
            }
        }

        public static void GuardarClientes(List<Cliente> clientes)
        {
            MostrarClientes(clientes);
            Console.Write("Introduce el nombre del archivo: ");
            string file = Console.ReadLine();
            string fileName = $"{file}.json";
            string jsonString = JsonSerializer.Serialize(clientes);
            Console.WriteLine($"Clientes: {jsonString}");
            File.WriteAllText(fileName, jsonString);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Cliente guardados en {fileName}.");
        }

        public static void CargarClientes(List<Cliente> clientes)
        {
            Console.Write("Introduce el nombre del archivo: ");
            string file = Console.ReadLine();
            string fileName = $"{file}.json";

            string jsonString = File.ReadAllText(fileName);
            clientes.AddRange(JsonSerializer.Deserialize<List<Cliente>>(jsonString));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cliente cargados correctamente.");
        }
    }
}