using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preograma_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string otra = "n";
            do
            {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("---              CALCULADORA             ---");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("(1).- SUMA");
            Console.WriteLine("(2).- RESTA");
            Console.WriteLine("(3).- MULTIPLICACION");
            Console.WriteLine("(4).- DIVICION");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Diguite el numero de la operacion a realizar");
            int opcion = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Ingrese el primer numero a operar");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero a operar");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            int res = 0;

            if (opcion == 1)
            {
                Console.Clear();
                Console.WriteLine("       Bienvenido a la suma");
                Console.WriteLine("---------------------------------");
                res = num1 + num2;
            }
            else if (opcion == 2)
            {
                Console.Clear();
                Console.WriteLine("      Bienvenido a la resta");
                Console.WriteLine("----------------------------------");
                res = num1 - num2;
            }
            else if (opcion == 3)
            {
                Console.Clear();
                Console.WriteLine("   Bienvenido a la multiplicación");
                Console.WriteLine("---------------------------------------");
                res = num1 * num2;
            }
            else if (opcion == 4)
            {
                Console.Clear();
                Console.WriteLine("     Bienvenido a la Divición");
                Console.WriteLine("-----------------------------------");
                res = num1 / num2;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("----------------");
                Console.WriteLine("Opcion no valida");
                Console.WriteLine("----------------");
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("El resultado es: "+ res);
            Console.WriteLine("-----------------------------------");
                
            Console.WriteLine("Desea realizaar otra operación");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("(s).- SI");
            Console.WriteLine("(n).- NO");
            Console.WriteLine("-----------------------------");
            otra = Console.ReadLine();
        } while (otra == "s" || otra == "S");
            Console.ReadKey();
        }
    }
}
