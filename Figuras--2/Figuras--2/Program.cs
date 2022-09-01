using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras__2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valida;
            int opcion;
            int otra;
            do
            {
                do
                {
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("   CALCULAR AREA Y PERIMETRO DE FIGURAS");
                    Console.WriteLine("--------------------------------------------");

                    menu();
                    opcion = int.Parse(Console.ReadLine());
                    valida = validaOpcion(opcion);


                } while (valida);

                Figuras fig = new Figuras();
                if (opcion == 1)
                {
                    fig.Cuadrado();
                }
                else if (opcion == 2)
                {
                    fig.Rectangulo();
                }
                else if (opcion == 3)
                {
                    fig.Triangulo();
                }
                else if (opcion == 4)
                {
                    fig.Pentagono();
                }
                else if (opcion == 5)
                {
                    fig.Circulo();
                }

                Console.WriteLine("¿Desea obtener el are y perimetro de otra figura?");
                Console.WriteLine("(1) Si");
                Console.WriteLine("(2) NO");
                otra = int.Parse(Console.ReadLine());
                Console.WriteLine("GRACIAS POR UTILIZAR EL SISTEMA DE CALCULO DE AREA Y PERIMETRO DE UNA FIGURA -OBB-");
            } while (otra == 1);
           

            Console.ReadKey();
        }

        public static void menu()
        {
            Console.WriteLine("(1) Para un Cuadrado");
            Console.WriteLine("(2) Para un Rectangulo");
            Console.WriteLine("(3) Para un Triangulo");
            Console.WriteLine("(4) Para un pentagono");
            Console.WriteLine("(5) Para un Circulo");
            
        }
        public static bool validaOpcion(int opcion)
        {
            if (opcion > 0 && opcion < 6)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Opcion incorrecta =( ");
                Console.ReadKey();
                Console.Clear();
                return true;

            }
        }
    }
}
