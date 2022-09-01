using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incremento_de_cantidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema de Aumento de cantidades");
            Console.WriteLine("----------------------------------------------");

            int res;
            do
            {
                Console.WriteLine("Desde que numero desea comenzar");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Hasta que numero desea llegar");
                int num1 = int.Parse(Console.ReadLine());
                for (int i = num2; i <= num1; i++)
                {
                    Console.WriteLine("--" + i + "--");

                }
                Console.WriteLine("---------------------------");
                Console.WriteLine("Desea realisar otro aumento");
                Console.WriteLine("(1) SI");
                Console.WriteLine("(2) NO");
                res = int.Parse(Console.ReadLine());
            } while (res == 1);
            Console.WriteLine("GRACIAS POR USAR EL SISTEMA DE AUNMENTO -OBB-");
            Console.ReadKey();
        }
    }
}
