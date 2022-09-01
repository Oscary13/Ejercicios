using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANDERA_DE_MEXICO
{
    class Program
    {
        public static int[] ArrayUno = new int[10];
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            int otra;
            do
            {
                Console.Clear();
                Console.WriteLine("  Bienvenido al programa de busqueda binaria");
                Console.WriteLine("(1).- Llenar");
                Console.WriteLine("(2).- Buscar");
                Console.WriteLine("(3).- Ordenar");
                Console.WriteLine("Selecciona una opcion");
                int opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    llenar();
                }
                else if (opcion == 2)
                {
                    busbinaria();
                }
                else if (opcion == 3)
                {
                    
                    ordenar();
                    imprimir();

                }
                else
                {
                    Console.WriteLine("Opción incorrecta");
                }
                Console.WriteLine("¿Desea realizar otra operación? 1 = SI  2 = NO");
                otra = int.Parse(Console.ReadLine());
            } while (otra == 1);
            Console.WriteLine("Gracias por utilizar el programa");
            Console.ReadKey();

        }
        public static void llenar()
        {
            Console.WriteLine("Ingrese los 10 numero");
            for (int i = 0; i < ArrayUno.Length; i++)
            {
                Console.WriteLine("Ingrese el numero " + (i + 1) + " del arreglo");
                ArrayUno[i] = int.Parse(Console.ReadLine());

            }
        }
        public static void ordenar()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int a;
                    if (ArrayUno[i] < ArrayUno[j])
                    {
                        a = ArrayUno[i];
                        ArrayUno[i] = ArrayUno[j];
                        ArrayUno[j] = a;
                    }
                }
            }
        }
        public static void imprimir()
        {
            Console.WriteLine("Los datos son");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(ArrayUno[i]);
            }
        }
        public static void busbinaria()
        {
            Console.WriteLine("Ingresa el dato que vas a buscar");
            int num = int.Parse(Console.ReadLine());
            bool Esta = false;
            int A = 0, B = ArrayUno.Length - 1;
            while (A <= B && !Esta)
            {
                int medio = A + (B - A) / 2;
                if (ArrayUno[medio] == num)
                    Esta = true;
                else if (ArrayUno[medio] < num)
                    A = medio + 1;
                else
                    B = medio - 1;
            }
            if (Esta)
            {
                Console.WriteLine("Se encontro el valor correctamente");
            }
            else
            {
                Console.WriteLine("No se encontro el valor");
            }
        }
    }
}
