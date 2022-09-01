using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("----METODOS & ATRIBUTOS-----");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1.- Suma");
            Console.WriteLine("2.- Resta");
            Console.WriteLine("3.- Multiplicación");
            Console.WriteLine("4.- División");
            Console.WriteLine("----------------------------");
            int otra;
            do
            {
               
                Console.WriteLine("Dijite el numero de una una opción");
                Console.WriteLine("----------------------------------");
                int opci = int.Parse(Console.ReadLine());
                Operaciones operacion = new Operaciones();
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Digite el primer número a sumar");
                operacion.num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Digite el segundo número");
                operacion.num2 = int.Parse(Console.ReadLine());


                if (opci == 1)
                {
                    operacion.suma(operacion.num1, operacion.num2);
                }
                else if (opci == 2)
                {
                    int result = operacion.resta(operacion.num1, operacion.num2);
                    Console.WriteLine("Resultado de la resta: " + result);

                }
                else if (opci == 3)
                {
                    int result = operacion.multi(operacion.num1, operacion.num2);
                    Console.WriteLine("Resultado de la multiplicación: " + result);
                }
                else if (opci == 4)
                {
                    double result = operacion.divi(operacion.num1, operacion.num2);
                    Console.WriteLine("Resultado de la divición: " + result);
                }
                else
                {
                    Console.WriteLine("INCORRECTO .|.");
                }
                Console.WriteLine("Desea realizar otra operacion");
                Console.WriteLine("(1). SI");
                Console.WriteLine("(2). NO");
                otra = int.Parse(Console.ReadLine());
                Console.Clear();


            } while (otra == 1);


        }
    }
}