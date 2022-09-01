using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1era_Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("                     HELLO WORD");
            Console.WriteLine("Esta es la clase de Programación orientada a objetos");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("INGRESE SU NOMBRE:");
            string nom = Console.ReadLine();

            Console.WriteLine("INGRESE SU EDAD;");
            int edad = int.Parse (Console.ReadLine());
            edad = edad + 1;

            Console.WriteLine("INGRTESE UN NUMERO;");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRTESE UN NUMERO;");
            int num2 = int.Parse(Console.ReadLine());

            int res = num1 + num2;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("El nombre es:" +"--" + nom + "--" + "   y la edad es:" + "--" + edad + "--");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("La suma de los numeros ingresados es: " + res);



            Console.ReadKey();
        }
    }
}
