using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de clases");
            Console.WriteLine("");
            perros pidbull = new perros();
            pidbull.raza = "Pidbull";
            pidbull.nombre = "Herculez";
            pidbull.color = "Marron";
            pidbull.edad = 1;
            perros perro2 = new perros();
            perro2.raza = "Doberman";
            perro2.nombre = "Tobi";
            perro2.color = "Gris";
            perro2.edad = 2;
            Console.WriteLine("La raza del perro es: "+ pidbull.raza+ " su nombre es "+pidbull.nombre+ " de color "+ pidbull.color+ " con " + pidbull.edad + " año de edad");
            Console.WriteLine("La raza del perro es: " + perro2.raza + " su nombre es " + perro2.nombre + " de color " + perro2.color + " con " + perro2.edad + " años de edad");
            Console.WriteLine(" ");
            computadoras laptop1 = new computadoras();
            Console.WriteLine("Escribe la marca de tu laptop");
            laptop1.marca = Console.ReadLine();
            Console.WriteLine("Escribe la cantidad de memoria RAM");
            laptop1.ram = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe la cantidad de memoria interna");
            laptop1.minterna = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el color de tu laptop");
            laptop1.color = Console.ReadLine();
            computadoras laptop2 = new computadoras();
            Console.WriteLine("Escribe la marca de tu laptop");
            laptop2.marca = Console.ReadLine();
            Console.WriteLine("Escribe la cantidad de memoria RAM");
            laptop2.ram = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe la cantidad de memoria interna");
            laptop2.minterna = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el color de tu laptop");
            laptop2.color = Console.ReadLine();
            Console.WriteLine(" "); 
            Console.WriteLine("Tu laptop es de la marca: "+ laptop1.marca + " con " + laptop1.ram+ " Gb de RAM y "+ laptop1.minterna+" Gb de memoria interna y color "+laptop1.color);
            Console.WriteLine("Tu laptop es de la marca: " + laptop2.marca + " con " + laptop2.ram + " Gb de RAM y " + laptop2.minterna + " Gb de memoria interna y color " + laptop2.color);
            Console.ReadKey();
        }
    }
}
