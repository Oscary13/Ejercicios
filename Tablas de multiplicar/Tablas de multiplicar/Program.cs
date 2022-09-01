using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tablas_de_multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            int opcion;
            do
            {

                Console.WriteLine("Que tabla de multiplicar quieres imprimir");
                int numero1 = int.Parse(Console.ReadLine());
                for (int i = 1; i < 11; i++)
                {
                    r = numero1 * i;
                    
                    Console.WriteLine(numero1 + " X " + i + "=" + r);
                }
                Console.WriteLine(" Desea Realizar otra tabla de multiplicar");
                Console.WriteLine("1.- Si        2.- No");
                opcion = int.Parse(Console.ReadLine());
            } while (opcion == 1);

            Console.ReadKey();
        }
    }
}
