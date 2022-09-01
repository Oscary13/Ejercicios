using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_Binaria
{
    class Program
    {
        public static int[] Array1 = new int[10];
        public static Hashtable tabla = new Hashtable();
        static void Main(string[] args)
        {
            menu();
        }
        public static void menu()
        {
            int otra;
            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("  Bienvenido al sistema de busqueda binaria");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("(1).- Llenar");
                Console.WriteLine("(2).- Ordenamiento burbuja");
                Console.WriteLine("(3).- Busqueda binaria");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Selecciona una opcion");
                int opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    llenar();
                }
                else if (opcion == 2)
                {
                    ordenar();
                    imprimir();

                }
                else if (opcion == 3)
                {
                    busquedaBinaria();
                }
                else
                {
                    Console.WriteLine("La opción es incorrecta");
                }
                Console.WriteLine("¿Desea realizar otra operación?");
                Console.WriteLine("(1).- SI");
                Console.WriteLine("(2).- NO");
                otra = int.Parse(Console.ReadLine());
            } while (otra == 1);
            Console.WriteLine("GRACIAS POR UTILIZAR EL SISTEMA OBB");
            Console.ReadKey();

        }
        public static void llenar()
        {
            
            Console.Clear();
            Console.WriteLine("Ingrese los 10 numero");
            for (int i = 0; i < Array1.Length; i++)
            {
                Console.WriteLine("Ingrese el numero " + (i + 1) + " del arreglo");
                Array1[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Nombre del alumno  " + (i + 1) + " del arreglo");
                string Nombre = Console.ReadLine();
                tabla.Add(Array1[i], Nombre);
            }
        }
        public static void ordenar()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int aux;
                    if (Array1[i] < Array1[j])
                    {
                        aux = Array1[i];
                        Array1[i] = Array1[j];
                        Array1[j] = aux;
                    }
                }
            }
        }
        public static void imprimir()
        {
            Console.WriteLine("Los datos ordenados son");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Array1[i]);
            }
           
            foreach (DictionaryEntry item in tabla)
            {
                Console.WriteLine($"Llave Primaria;{item.Key} Nombre: {item.Value}");
            }
        }
        public static void busquedaBinaria()
        {
            Console.WriteLine("¿Qué dato quieres buscar? ");
            int num = int.Parse(Console.ReadLine());
            bool encontrado = false;
            int izquierda = 0, derecha = Array1.Length - 1;
            while (izquierda <= derecha && !encontrado)
            {
                int medio = izquierda + (derecha - izquierda) / 2;
                if (Array1[medio] == num)
                {
                    encontrado = true;
                }
                else if (Array1[medio] < num)
                {
                    izquierda = medio + 1;
                }
                else
                {
                    derecha = medio - 1;
                }


            }

            if (encontrado)
            {
                Console.WriteLine();
                Console.WriteLine("El valor ingresado fue encontrado");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("El valor ingresado no fue encontrado");
            }
        }
    }
}
 