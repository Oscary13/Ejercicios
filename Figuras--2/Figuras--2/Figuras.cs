using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras__2
{
    class Figuras
    {
        public double ladoC;
        public double perimetro;
        public double area;
        public double baseR;
        public double alturaR;
        double lado1;
        double lado2;
        double lado3;
        double areaT;
        double baseT;
        double alturaT;
        double Lado;
        double area2;
        double apotema;
        double radio;
        double pi;
        public string Figura;



        public void Cuadrado()
        {
            Figura = "Cuadrado";
            Encabezado();
            Console.WriteLine("");
            Console.WriteLine("Ingrese la base o lado del cuadrado");
            ladoC = double.Parse(Console.ReadLine());
            perimetro = 4 * ladoC;
            area = ladoC * ladoC;
            Resultado();
        }
        public void Rectangulo()
        {
            Figura = "rectangulo";
            Encabezado();
            Console.WriteLine("");
            Console.WriteLine("Ingrese la base del Rectangulo");
            baseR = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del Rectangulo");
            alturaR = double.Parse(Console.ReadLine());
            perimetro = baseR * 2 + alturaR * 2;
            area = baseR * alturaR;
            Resultado();
        }

        public void Triangulo()
        {
            Figura = "Triangulo";
            Encabezado();
            Console.WriteLine("");
            Console.WriteLine("Ingrese la base del Triangulo");
            baseT = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del Rectangulo");
            alturaT = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la medida de los lados 1, 2, 3 de Triangulo");
            lado1 = double.Parse(Console.ReadLine());
            lado2 = double.Parse(Console.ReadLine());
            lado3 = double.Parse(Console.ReadLine());
            perimetro = lado1 + lado2 + lado3;
            areaT = baseT * alturaT;
            area = areaT / 2;
            Resultado();
        }

        public void Pentagono()
        {
            Figura = "Pentagono";
            Encabezado();
            Console.WriteLine("");
            Console.WriteLine("Medida del los  5 lados");
            Lado = double.Parse(Console.ReadLine());
            perimetro = Lado * 5;
            Console.WriteLine("Medida del Apotema");
            Console.WriteLine("¿Qué es el apotema de un Pentágono? Es la distancia más corta entre el centro del pentágono y uno de sus lados.Se traza con una perpendicular.");
            apotema = double.Parse(Console.ReadLine());
            area2 = perimetro * apotema;
            area = area2 / 2;
            Resultado();
        }

        public void Circulo()
        {
            Figura = "Circulo";
            Encabezado();
            Console.WriteLine("");
            Console.WriteLine("Ingrese el radio del Circulo");
            radio = double.Parse(Console.ReadLine());
            pi = Math.PI;
            perimetro = 2 * pi * radio;
            area = pi * Math.Pow(radio, 2);
            Resultado();
        }
        public void Encabezado()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"ÁREA Y PERIMETRO DE UN {Figura}");
            Console.WriteLine("-Ingrese los siguientes valores-");
            Console.WriteLine("--------------------------------");
        }
        public void Resultado()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"El area del {Figura} es: {area}");
            Console.WriteLine($"El perimetro del { Figura} es: { perimetro}");
            Console.WriteLine("--------------------------------");
        }
    }
}
