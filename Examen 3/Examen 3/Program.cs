using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Console.WriteLine("BIENVENIDO AL SITEMA DE ORDENAMIENTO DE 10 NUMEROS DE MENOR A MAYOR -OBB-");
            Console.WriteLine("-------------------------------------------------------------------------");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digita el numero: " + (i + 1));
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Los numeros ingresados son: ");
            Console.WriteLine("--------------------------------------------");
            foreach (int item in array)
            {
                Console.WriteLine(" - " + item + " - ");
            }
            Console.WriteLine("--------------------------------------------");

            for (int A = 0; A < 10; A++)
            {
                for (int B = 0; B < 10; B++)
                {

                    if (array[A] < array[B])
                    {
                        int temp = array[B];
                        array[B] = array[A];
                        array[A] = temp;

                    }
                }
            }
            Console.WriteLine("Los numeros ordenados de menor a mayor son: ");
            Console.WriteLine("--------------------------------------------");
            foreach (int item in array)
            {
                Console.WriteLine(" - " + item + " - ");
            }
            Console.WriteLine("--------------------------------------------");
            Console.ReadKey();
        }
    }
}
