using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1, num2, num3;
            Console.WriteLine("Bienvenido al Sistema de Comparacion de 3 numeros -OBB-");
            Console.WriteLine("Ingresa un valor");
            Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo valor");
            num2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Ingresa el tercer valor");
            num3 = int.Parse(Console.ReadLine());

            if (Num1 > num2 & Num1 > num3 )
            {
                Console.WriteLine("El Numero " + Num1 + " es el mayor");
            }
            else if (num2 > Num1 & num2 > num3)
            {
                Console.WriteLine("El Numero " + num2 + " es el mayor");
            }
            else if (num3 > Num1 & num3 > num2)
            {
                Console.WriteLine("El Numero " + num3 + " es el mayor");
            }



            if (Num1 < num2 & Num1 < num3)
            {
                Console.WriteLine("El Numero " + Num1 + " es el menor");
            }
            else if (num2 < Num1 & num2 < num3)
            {
                Console.WriteLine("El Numero " + num2 + " es el menor");
            }
            else if (num3 < Num1 & num3 < num2)
            {
                Console.WriteLine("El Numero " + num3 + " es el menor");
            }




            else
            {
                Console.WriteLine("Los numeros son iguales");
            }
            Console.ReadKey();
        }
    }
}
