using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("                -PROGRAM OBB-");
            Console.WriteLine("-----------------------------------------------");
            Tenis_NIKE jordan1 = new Tenis_NIKE();
            jordan1.Modelo = "Jordan 1";
            jordan1.Color = "Negro con rojo";
            jordan1.Talla = 24.5;
            jordan1. Precio = 23000;
            Tenis_NIKE cortez = new Tenis_NIKE();
            Console.WriteLine("Ingresa el |modelo| de tus tenis NIKE:");
            cortez.Modelo = Console.ReadLine();
            Console.WriteLine("Ingresa el |color| de tus tenis NIKE:");
            cortez.Color = Console.ReadLine();
            Console.WriteLine("Ingresa el |numero| de tus tenis NIKE:");
            cortez.Talla = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el |precio| de tus tenis NIKE:");
            cortez.Precio = double.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------");
            Motocicletas Italica = new Motocicletas();
            Console.WriteLine("Ingresa la |marca| de tu Motocicleta:");
            Italica.Marca = Console.ReadLine();
            Console.WriteLine("Ingresa el |modelo| de tu Motocicleta:");
            Italica.Modelo = Console.ReadLine();
            Console.WriteLine("Ingresa el |color de pintura| de tu Motocicleta:");
            Italica.Pintura = Console.ReadLine();
            Console.WriteLine("Ingresa el |año| de tu Motocicleta:");
            Italica.Año = int.Parse (Console.ReadLine());
            Motocicletas Yamaha = new Motocicletas();
            Yamaha.Marca = "Yamaha";
            Yamaha.Modelo = "YZ250F";
            Yamaha.Pintura = "Blanco mate";
            Yamaha.Año = 2020;
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Tenis, Modelo: " + jordan1.Modelo + " ,color: " + jordan1.Color + " ,talla: " + jordan1.Talla + ", con un valor de: $" + jordan1.Precio + " pesos");
            Console.WriteLine("Tenis, Modelo: " + cortez.Modelo + " ,color: " + cortez.Color + " ,talla: " + cortez.Talla + ", con un valor de: $" + cortez.Precio + " pesos");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Motosicleta, Marca: " + Italica.Marca + ", modelo: " + Italica.Modelo + ", Con una pintura de color; " + Italica.Pintura + ", del año: " + Italica.Año);
            Console.WriteLine("Motosicleta, Marca: " + Yamaha.Marca + ", modelo: " + Yamaha.Modelo + ", Con una pintura de color; " + Yamaha.Pintura + ", del año: " + Yamaha.Año);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.ReadKey();
        }

     
    }
    
}
