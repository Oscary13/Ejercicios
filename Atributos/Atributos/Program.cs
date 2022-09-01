using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("  - Metodos y Atributos -");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1.- Suma");
            Console.WriteLine("2.- Resta");
            Console.WriteLine("3.- Multiplicación");
            Console.WriteLine("4.- División");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Seleccione una opcion:");
            int op = int.Parse(Console.ReadLine());
            Operaciones opera = new Operaciones();
            Console.WriteLine("Ingrese el primer numero:");
            opera.num1 = int.Parse(Console.ReadLine());
            opera.num2 = int.Parse(Console.ReadLine());



            if (op == 1)
            {

                opera.suma(opera.num1, opera.num2);
            }
            else if (op == 2)
            {
                opera.resta(opera.num1, opera.num2);
                Console.WriteLine("El resultado de la resta es: " + result);

            }
            else if (op == 3)
            {

            }
            else if (op == 4)
            {

            }
            else
            {

            }
            Console.ReadKey();

        }
    }
}
