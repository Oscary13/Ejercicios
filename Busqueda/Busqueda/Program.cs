using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda
{
    class Program :Datos
    {
        public static List<Datos> ltDatos = new List<Datos>();
        static void Main(string[] args)
        {
            int opcion2;
            do
            {
                int opcion;
                do
                {
                    Console.WriteLine("----------- BIENVENIDOS AL SISTEMA DE BUSQUEDA -----------");
                    Console.WriteLine("Es necesario llenar la lista con los datos de los usuarios");
                    menu();
                    Console.WriteLine("¿Eliga el numero de la operacion que quiere realizar?");
                    opcion = int.Parse(Console.ReadLine());

                } while (opcion < 1 | opcion > 3);
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("¿Cuantos registros desea ingresar?");
                        int registros = int.Parse(Console.ReadLine());
                        Console.Clear();
                        LlenarLista(registros);
                        break;
                    case 2:
                        Console.Clear();
                        imprimir();
                        break;
                    case 3:
                        Console.Clear();
                        buscar();
                        break;
                }
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("        ¿Desea volver al menu?");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("(1).- SI");
                Console.WriteLine("(2).- NO");
                opcion2 = int.Parse(Console.ReadLine());
            } while (opcion2 == 1);
            Console.Clear();
            Console.WriteLine("--- GRACIAS POR UTILIZAR EL SISTEMA OBB ---");
            Console.ReadKey();
        }
        public static void LlenarLista(int registros)
        {
            for (int i = 0; i < registros; i++)
            {
                Console.Clear();
                Console.WriteLine("Ingrese el id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el Apellido paterno");
                string Apaterno = Console.ReadLine();
                Console.WriteLine("Ingrese el Apellido materno");
                string Amaterno = Console.ReadLine();
                Console.WriteLine("Ingrese la dirección");
                string direccion = Console.ReadLine();
                Console.WriteLine("Ingrese la edad");
                int Edad = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el email");
                string email = Console.ReadLine();
                ltDatos.Add(new Datos() { id = id, Nombre = nombre, Apaterno = Apaterno, Amaterno = Amaterno, Direccion = direccion, Edad =Edad, email = email });

            }
        }
        public static void imprimir()
        {
            foreach (Datos item in ltDatos)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"{item.Nombre} {item.Apaterno} {item.Amaterno} Con direccion: {item.Direccion} Con edad de. {item.Edad} y Correo electronico {item.email} y ID: {item.id}");
            }
        }
        public static void buscar()
        {
            int encontrado = 0;
            Console.WriteLine("Ingrese el Id a buscar: ");
            int idBusqueda = int.Parse(Console.ReadLine());
            foreach (Datos item in ltDatos)
            {
                if (item.id == idBusqueda)
                {
                    Console.Clear();
                    Console.WriteLine($"{item.Nombre} {item.Apaterno} {item.Amaterno} Con direccion: {item.Direccion} Con edad de. {item.Edad} y Correo electronico {item.email} y ID: {item.id}");
                    encontrado = 1;
                }
            }
            if (encontrado == 0 )
            {
                Console.WriteLine("No se encontro registro");

            }
        }
        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("       BIENVENIDO AL MENU ");
            Console.WriteLine(" ---------------------------------");
            Console.WriteLine(" (1) ALTA ");
            Console.WriteLine(" (2) IMPRIMIR ");
            Console.WriteLine(" (3) BUSCAR ");
            Console.WriteLine(" ---------------------------------");


        }
    }
}
