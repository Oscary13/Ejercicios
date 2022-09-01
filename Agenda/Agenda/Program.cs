using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Program : Atributos
    {
        public static List<Atributos> ltnuevo = new List<Atributos>();
        static void Main(string[] args)
        {
            Atributos nuevo = new Atributos();
            Boolean val;
            int opc, otra;
            do
            {
                do
                {
                    
                    Console.Clear();
                    menu();
                    Console.WriteLine("(1).- Alta ");
                    Console.WriteLine("(2).- Baja ");
                    Console.WriteLine("(3).- Edición ");
                    Console.WriteLine("(4).- Imprimir ");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("              Seleccione una opcion: ");
                    Console.WriteLine("------------------------------------------------");
                    opc = int.Parse(Console.ReadLine());
                    val = valida(opc, 5);
                } while (val);
                if (opc == 1)
                {
                    Alta();
                }
                else if (opc == 2)
                {
                    Baja();
                }
                else if (opc == 3)
                {
                    nuevo.EdicionClinte(ltnuevo);
                }
                else if (opc == 4)
                {
                    Imprimir();
                }
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("        Desea realizar otra operación: ");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("(1).- SI ");
                Console.WriteLine("(2).- NO ");
                otra = int.Parse(Console.ReadLine());

            } while (otra == 1);
        }
        public static void Alta()
        {
            Console.Clear();
            Console.WriteLine("                       ALTA");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Escriba el nombre: ");
            string nom = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Escriba el apellido Paterno: ");
            string pat = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Escriba el apellido Materno: ");
            string mat = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Escriba el telefono: ");
            string tel = Console.ReadLine();
            Console.WriteLine();
            ltnuevo.Add(new Atributos() { nombre = nom, Apaterno = pat, Amaterno = mat, telefono = tel });
        }
        public static void Imprimir()
        {
            Console.Clear();
            Console.WriteLine("                               IMPRIMIR");
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (Atributos item in ltnuevo)
            {
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine($"Nombre: {item.nombre} {item.Apaterno} {item.Amaterno}  <> Numero telefonico: {item.telefono}");
                Console.WriteLine("--------------------------------------------------------------------");
            }


        }
        public static void Baja()
        {
            Console.Clear();
            Console.WriteLine("INGRESE EL NOMBRE DEL ELEMENTO A DAR DE BAJA");
            string nom = Console.ReadLine();
            int cont = 0;
            int indice = -1;
            foreach (Atributos item in ltnuevo)
            {
                if (item.nombre == nom)
                {
                    indice = cont;
                }
                cont++;
            }
            if (indice > -1)
            {
                ltnuevo.RemoveAt(indice);
            }
            Console.WriteLine();
            Console.WriteLine(">>>>> El registro se removio correctamente <<<<<");
        }

        public static void menu()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("                     AGENDA OBB");
            Console.WriteLine("------------------------------------------------");

        }
        public static Boolean valida(int opcion, int tamaño)
        {
            if (opcion < 1 || opcion > 4)
            {
                Console.Clear();
                Console.WriteLine("La opccion seleccionada es invalida........");
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
