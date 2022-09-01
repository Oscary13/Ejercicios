using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raul_Agenda
{
    class Program
    {
        public static List<Datos> ltdatos = new List<Datos>();
        static void Main(string[] args)
        {

            int opc, otra;
            do
            {
                menu();
                Console.WriteLine();
                Console.WriteLine("Digite el numero de la opción");
                opc = int.Parse(Console.ReadLine());

                if (opc == 1)
                {
                    alta();
                }
                else if (opc == 2)
                {
                    baja();
                }
                else if (opc == 3)
                {
                    editar(ltdatos);
                }
                else if (opc == 4)
                {
                    imprimir();
                }
                Console.WriteLine();
                Console.WriteLine("Desea realizar otra operación");
                Console.WriteLine("(1): SI");
                Console.WriteLine("(2): NO");
                otra = int.Parse(Console.ReadLine());
            } while (otra == 1);
        }


        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("                  AGENDA");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("               (1) Alta");
            Console.WriteLine("               (2) Baja");
            Console.WriteLine("               (3) Edición");
            Console.WriteLine("               (4) Imprimir");
            Console.WriteLine("--------------------------------------");
        }
        public static void alta()
        {

            Console.Clear();
            Console.WriteLine("Escribe el nombre ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escribe el apellido paterno");
            string apaterno = Console.ReadLine();
            Console.WriteLine("Escribe el apellido materno");
            string amaterno = Console.ReadLine();
            Console.WriteLine("Ingresa el numero de telefono");
            string telefono = Console.ReadLine();
            ltdatos.Add(new Datos() { Nombre = nombre, Paterno = apaterno, Materno = amaterno, Telefono = telefono });


        }
       
        public static void baja()
        {
            Console.WriteLine("Escribe el nombre del contacto a dar de baja");
            string nombre = Console.ReadLine();
            int cont = 0;
            int indice = -1;

            foreach (Datos item in ltdatos)
            {
                if (item.Nombre == nombre)
                {
                    indice = cont;
                }
                cont++;
            }
            if (indice > -1)
            {
                ltdatos.RemoveAt(indice);
                Console.WriteLine("REGISTRO ELIMINADO");
            }
        }
        public static void imprimir()
        {
            Console.WriteLine("----- IMPRIMIR DATOS -----");
            Console.WriteLine();
            foreach (Datos item in ltdatos)
            {
                Console.WriteLine(item.Nombre + " " + item.Paterno + " " + item.Materno + " " + item.Telefono);
            }
        }
        public static void editar(List<Datos> ltclientes)
        {

            List<Datos> ltalterna = new List<Datos>();
            foreach (Datos item in ltclientes)
            {
                ltalterna.Add(item);
            }

            Console.WriteLine("Ingresa el nombre del contacto a editar ");
            string nombre = Console.ReadLine();
            int opc = menuEdicion();
            ltclientes.Clear();

            if (opc == 1)
            {
                Console.WriteLine("Escribe el nuevo Apellido Paterno ");
                string paterno = Console.ReadLine();

                foreach (Datos item in ltalterna)
                {
                    if (item.Nombre == nombre)
                    {
                        ltclientes.Add(new Datos() { Nombre = item.Nombre, Paterno = paterno, Materno = item.Materno, Telefono = item.Telefono });
                    }
                    else
                    {
                        ltclientes.Add(item);
                    }
                }
                Console.WriteLine("------- CONTACTO EDITADO ------- ");
            }
            else if (opc == 2)
            {
                Console.WriteLine("ingrese el nuevo apellido materno");
                string materno = Console.ReadLine();

                foreach (Datos item in ltalterna)
                {
                    if (item.Nombre == nombre)
                    {
                        ltclientes.Add(new Datos() { Nombre = item.Nombre, Paterno = item.Paterno, Materno = materno, Telefono = item.Telefono });
                    }
                    else
                    {
                        ltclientes.Add(item);
                    }
                }
                Console.WriteLine("------- CONTACTO EDITADO ------- ");
            }
            else if (opc == 3)
            {
                Console.WriteLine("ingrese el nuevo telefono");
                string telefono = Console.ReadLine();

                foreach (Datos item in ltalterna)
                {
                    if (item.Nombre == nombre)
                    {
                        ltclientes.Add(new Datos() { Nombre = item.Nombre, Paterno = item.Paterno, Materno = item.Materno, Telefono = telefono });
                    }
                    else
                    {
                        ltclientes.Add(item);
                    }
                }
                Console.WriteLine("------- CONTACTO EDITADO ------- ");
            }
        }
        public static int menuEdicion()
        {
            Boolean val;
            int opc;
            do
            {

                Console.Clear();
                Console.WriteLine("(1)    Apellido paterno");
                Console.WriteLine("(2)    Apellido materno");
                Console.WriteLine("(3)    Telefono");
                Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
                Console.WriteLine("   seleccione una opcion");
                opc = int.Parse(Console.ReadLine());
                val = valida(opc, 3);
            } while (val);
            return opc;
        }
        public static Boolean valida(int opcion, int tamaño)
        {
            if (opcion < 1 || opcion > tamaño)
            {
                Console.WriteLine("la opcion es invalida");
                Console.ReadKey();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}
