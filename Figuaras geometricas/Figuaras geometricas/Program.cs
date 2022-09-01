 using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuaras_geometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO AL SISTEMA DE AREA Y PERIMETRO DE FIGURAS -OBB-");
            int res;
            do
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("Elija el numero de la figura de la cual desea obtener el area y perimetro");
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("(1) Para un Cuadrado");
                Console.WriteLine("(2) Para un Rectangulo");
                Console.WriteLine("(3) Para un Triangulo");
                Console.WriteLine("(4) Para un Circulo");
                Console.WriteLine("(5) Para un pentagono");
                int op = int.Parse(Console.ReadLine());
                double perimetro, area;
                perimetro = 0;
                area = 0;
                if (op == 1)
                {
                    Console.Clear();
                    Console.WriteLine("ÁREA Y PERIMETRO DE UN CUADRADO");
                    Console.WriteLine("--Ingrese los siguientes valores--");
                    Console.WriteLine("Ingrese la base o lado del cuadrado");
                    double ladoC = double.Parse(Console.ReadLine());
                    perimetro = 4 * ladoC;
                    area = ladoC * ladoC;
                }

                else if (op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("ÁREA Y PERIMETRO DE UN Rectangulo");
                    Console.WriteLine("--Ingrese los siguientes valores--");
                    Console.WriteLine("Ingrese la base del Rectangulo");
                    double baseR = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del Rectangulo");
                    double alturaR = double.Parse(Console.ReadLine());
                    perimetro = baseR * 2 + alturaR * 2;
                    area = baseR * alturaR;
                }

                else if (op == 3)
                {
                    Console.Clear();
                    Console.WriteLine("ÁREA Y PERIMETRO DE UN Triangulo");
                    Console.WriteLine("--Ingrese los siguientes valores--");
                    Console.WriteLine("Ingrese la base del Triangulo");
                    double baseT = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del Rectangulo");
                    double alturaT = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la medida de los lados 1, 2, 3 de Triangulo");
                    double lado1 = double.Parse(Console.ReadLine());
                    double lado2 = double.Parse(Console.ReadLine());
                    double lado3 = double.Parse(Console.ReadLine());
                    double areaT;
                    perimetro = lado1 + lado2 + lado3;
                    areaT = baseT * alturaT;
                    area = areaT / 2;
                }

                else if (op == 4)
                {
                    Console.Clear();
                    Console.WriteLine("ÁREA Y PERIMETRO DE UN Circulo");
                    Console.WriteLine("--Ingrese los siguientes valores--");
                    Console.WriteLine("Ingrese el radio del Circulo");
                    double radio = double.Parse(Console.ReadLine());
                    double pi = Math.PI;
                    perimetro = 2 * pi * radio;
                    area = pi * Math.Pow(radio, 2);
                }
                else if (op == 5)
                {
                    Console.Clear();
                    Console.WriteLine("ÁREA Y PERIMETRO DE UN PENTAGONO");
                    Console.WriteLine("--Ingrese los siguientes valores--");
                    Console.WriteLine("Medida del los  5 lados");
                    double Lado = double.Parse(Console.ReadLine());
                    double area2;
                    perimetro = Lado * 5;
                    Console.WriteLine("Medida del Apotema");
                    Console.WriteLine("¿Qué es el apotema de un Pentágono? Es la distancia más corta entre el centro del pentágono y uno de sus lados.Se traza con una perpendicular.");
                    double apotema = double.Parse(Console.ReadLine());
                    area2 = perimetro * apotema;
                    area = area2 / 2;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opccion incorrecta");
                }
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("El perietro es: " + perimetro);
                Console.WriteLine("El area es  es: " + area);
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("¿Desea obtener el are y perimetro de otra figura?");
                Console.WriteLine("(1) Si");
                Console.WriteLine("(2) NO");
                res = int.Parse(Console.ReadLine());
            } while (res == 1);
            Console.WriteLine("GRACIAS POR UTILIZAR EL SISTEMA DE CALCULO DE AREA Y PERIMETRO DE UNA FIGURA -OBB-");
            Console.ReadKey();
        }
    }
}
