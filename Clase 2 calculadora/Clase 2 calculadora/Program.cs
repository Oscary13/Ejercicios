using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2_calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int otra = 0;
            do
            { 
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("---              CALCULADORA             ---");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("(1).- SUMA");
            Console.WriteLine("(2).- RESTA");
            Console.WriteLine("(3).- MULTIPLICACION");
            Console.WriteLine("(4).- DIVICION");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Diguite el numero de la operacion a realizar");
            int opcion  = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                Console.Clear();
                Console.WriteLine("       Bienvenido a la suma");
                Console.WriteLine("-------------------- ------------");
                Console.WriteLine("Ingrese el primer numero a sumar");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el degundo numero a sumar");
                Console.WriteLine("---------------------------------");
                int num2 = int.Parse(Console.ReadLine());
                int suma = num1 + num2;
                Console.WriteLine("El resultado es:" + suma);
            }
            else if (opcion == 2)
            {
                Console.Clear();
                Console.WriteLine("      Bienvenido a la resta");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Ingrese el primer numero a restar ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero a restar");
                Console.WriteLine("----------------------------------");
                int num2 = int.Parse(Console.ReadLine());
                int resta = num1 - num2;
                Console.WriteLine("El resultado es:" + resta);
            }
            else if (opcion == 3)
            {
                Console.Clear();
                Console.WriteLine("   Bienvenido a la multiplicación");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Ingrese el primer numero a multiplicar");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el degundo numero a multiplicar");
                Console.WriteLine("---------------------------------------");
                int num2 = int.Parse(Console.ReadLine());
                int multiplicacion = num1 * num2;
                Console.WriteLine("El resultado es:" + multiplicacion);

            }
            else if (opcion == 4)
            {
                Console.Clear();
                Console.WriteLine("     Bienvenido a la Divición");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Ingrese el primer numero a dividir");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el degundo numero a dividir");
                Console.WriteLine("-----------------------------------");
                int num2 = int.Parse(Console.ReadLine());
                double divicion = num1/num2;
                Console.WriteLine("El resultado es:" + divicion);

            }
            else
            {
                Console.Clear();
                Console.WriteLine("----------------");
                Console.WriteLine("Opcion no valida");
                Console.WriteLine("----------------");
            }
            Console.WriteLine("Desea realizaar otr operación");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("(1).- SI");
            Console.WriteLine("(2).- NO");
            Console.WriteLine("-----------------------------");
                otra = int.Parse(Console.ReadLine());
            } while (otra == 1);
            Console.ReadKey();
        }
    }
}
