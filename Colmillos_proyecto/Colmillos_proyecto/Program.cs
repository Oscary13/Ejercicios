using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmillos
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase_materias ma = new Clase_materias();
            Clase_calculadoraBasica ca = new Clase_calculadoraBasica();
            int selecciona, cam;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine(" ------------------------------------------------------------------------");
                    Console.WriteLine("                         BIENVENIDO PROFESOR DAVID                       ");
                    Console.WriteLine(" ------------------------------------------------------------------------");
                    Console.WriteLine(" Seleccione un software: ");
                    Console.WriteLine(" ------------------------------------------------------------------------");
                    Console.WriteLine(" (1).- CALCULADOR DE PROMEDIO DE GRUPOS");
                    Console.WriteLine(" (2).- CALCULADORA BASICA");
                    Console.WriteLine(" ------------------------------------------------------------------------");
                    selecciona = int.Parse(Console.ReadLine());
                } while (selecciona < 1 || selecciona > 2);
                switch (selecciona)
                {
                    case 1:
                        ma.des();
                        DateTime fecha = DateTime.Now;
                        Console.WriteLine();
                        Console.WriteLine(fecha.ToLongDateString());
                        break;
                    case 2:
                        ca.CalculadoraBasicaa();
                        DateTime fecha1 = DateTime.Now;
                        Console.WriteLine();
                        Console.WriteLine(fecha1.ToLongDateString());
                        break;
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------");
                Console.WriteLine("                      ¿ QUIERES ELEGIR OTRO SOFTWARE ?");
                Console.WriteLine(" ------------------------------------------------------------------------");
                Console.WriteLine("(1).- SI");
                Console.WriteLine("(2).- NO");
                Console.WriteLine(" ------------------------------------------------------------------------");
                cam = int.Parse(Console.ReadLine());

            } while (cam == 1);

        }
    }
}
