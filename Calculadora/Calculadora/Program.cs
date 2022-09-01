using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int cam;
            do
            {
                Console.Clear();
                menu();
                float numero1 = 0;
                Console.WriteLine("Escribe el primer numero");
                numero1 = float.Parse(Console.ReadLine());
                int opcion;
                do
                {
                    Console.WriteLine();
                    do
                    {
 
                        Console.Clear();
                        menu();
                        Console.WriteLine($"                Operacion a realizar para al numero: {numero1}");
                        Console.WriteLine(" ------------------------------------------------------------------------");
                        Console.WriteLine("   (1) SUMA");
                        Console.WriteLine("   (2) RESTA");
                        Console.WriteLine("   (3) DIVICIÓN");
                        Console.WriteLine("   (4) MULTIPLICACION");
                        Console.WriteLine(" ------------------------------------------------------------------------");
                        opcion = int.Parse(Console.ReadLine());
                    } while (opcion < 1 || opcion > 4);
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------");
                    Console.WriteLine("                       Ingrese el segundo numero a operar");
                    Console.WriteLine(" ------------------------------------------------------------------------");
                    float numero2 = float.Parse(Console.ReadLine());
                    if (opcion == 1)
                    {
                        numero1 = numero1 + numero2;
                        Console.WriteLine(" ------------------------------------------------------------------------");
                        Console.WriteLine("                       El resultado de la suma es: " + numero1);
                        Console.WriteLine(" ------------------------------------------------------------------------");
                    }
                    else if (opcion == 2)
                    {
                        numero1 = numero1 - numero2;
                        Console.WriteLine(" ------------------------------------------------------------------------");
                        Console.WriteLine("                      El resultado de la resta es:  " + numero1);
                        Console.WriteLine(" ------------------------------------------------------------------------");
                    }
                    else if (opcion == 3)
                    {
                        numero1 = numero1 / numero2;
                        Console.WriteLine(" ------------------------------------------------------------------------");
                        Console.WriteLine("                   El resultado de la divicion es:  " + numero1);
                        Console.WriteLine(" ------------------------------------------------------------------------");
                    }
                    else if (opcion == 4)
                    {
                        numero1 = numero1 * numero2;
                        Console.WriteLine(" ------------------------------------------------------------------------");
                        Console.WriteLine("             El resultado de la multiplicacion es:  " + numero1);
                        Console.WriteLine(" ------------------------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("Opcion invalida");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ------------------------------------------------------------------------");
                    Console.WriteLine("                       ¿QUE OPERACIÓN DESEAS REALIZAR?");
                    Console.WriteLine(" ------------------------------------------------------------------------");
                    Console.WriteLine($"(1).- REALIZAR UNA OPERACIÓN AL RESULTADO  QUE ES: {numero1}");
                    Console.WriteLine("(2).- REALIZAR UNA OPERACION NUEVA ");
                    Console.WriteLine("(3).- Salir");
                    Console.WriteLine(" ------------------------------------------------------------------------");
                    cam = int.Parse(Console.ReadLine());
                } while (cam == 1);

            } while (cam == 2);
        }
        public static void menu()
        {
            Console.WriteLine(" ------------------------------------------------------------------------");
            Console.WriteLine("                             CALCULADORA BASICA ");
            Console.WriteLine(" ------------------------------------------------------------------------");

        }
    }
}
