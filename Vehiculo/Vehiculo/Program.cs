using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("        Programa de Vehiculos");
            Console.WriteLine("-----------------------------------");

            Vehiculos ve1 = new Vehiculos ();
            Vehiculos ve2 = new Vehiculos ();
            Vehiculos ve3 = new Vehiculos ();

            ve1.llenar_Datos();
            ve1.llenar_Datos(2010, "Nissan");

            Console.WriteLine("Escribe la marca:");
            ve2.Marca = Console.ReadLine();
            Console.WriteLine("Escrbe el modelo:");
            ve2.Modelo = Console.ReadLine();
            Console.WriteLine("Escribe la placa:");
            ve2.Placa = Console.ReadLine();
            Console.WriteLine("Escribe donde fue fabricado:");
            ve2.pais = Console.ReadLine();
            Console.WriteLine("Escribe el año:");
            ve2.año = int.Parse(Console.ReadLine());

            Console.WriteLine("Vehiculo de la marca: " + ve1.Marca + " " + " Modelo: " + ve1.Modelo + " " + ve1.año +" " + " Pais de fabricacion: " + ve1.pais + " " + " Placas: " + ve1.Placa);
            Console.WriteLine("");
            Console.WriteLine("Vehiculo de la marca: " + ve2.Marca + " " + " Modelo: " + ve2.Modelo + " " + ve2.año +" " + " Pais de fabricacion: " + ve2.pais + " " + " Placas: " + ve2.Placa);
            Console.WriteLine("");
            Console.WriteLine("Vehiculo de la marca: " + ve3.Marca + " " + " Modelo: " + ve3.Modelo + " " + ve3.año +" " + " Pais de fabricacion: " + ve3.pais + " " + " Placas: " + ve3.Placa);
            Console.ReadKey();
        }
    }
}
