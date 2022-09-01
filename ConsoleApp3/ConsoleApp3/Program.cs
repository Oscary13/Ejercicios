using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static List<int> ltnumeros = new List<int>();
        static void Main(string[] args)
        {
            int  opcion = 0;
            do
            {
                Console.WriteLine(" Bienvenido al sistema de almacenamiento");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("(1) Clasica");
                Console.WriteLine("(2) Agregar valor a la lista");
                Console.WriteLine("(3) Borrar lista");
                Console.WriteLine("(4) Imprimir lista");
                Console.WriteLine("Seleccione una opcion");
                int op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    clasica();
                }
                else if (op == 2)
                {
                    Listado();
                }
                else if (op == 3)
                {
                    ltnumeros.Clear();
                }
                else if (op == 4)
                {
                    foreach (int item in ltnumeros)
                    {
                        Console.WriteLine(item);
                    }
                }
                    
                    
                Console.WriteLine("¿Desea realizar otra operacion?");
                Console.WriteLine("(1) SI");
                Console.WriteLine("(2) NO");
                opcion = int.Parse(Console.ReadLine());
            } while (opcion == 1 );
            Console.WriteLine("GRACIAS POR YTILIZAR LOS SISTEMAS -OBB-");
            Console.ReadKey();
        }
        static void Listado ()
        {
            Console.WriteLine("Cuantos numeros desea almacenar");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Ingrese el numero a la lista");
                int numero = int.Parse(Console.ReadLine());
                ltnumeros.Add(numero);
            }
            foreach (int item in ltnumeros)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey(); 
        }

        static void clasica()
        { 
            
            Console.WriteLine("Ingrese el numero 1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 3");
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Los numeros son: " + n1 + ", " + n2 + ", " + n3);
            Console.ReadKey();
        }
    }
}
