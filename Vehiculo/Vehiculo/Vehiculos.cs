using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    class Vehiculos
    {
        public string Marca = "BMW";
        public string Modelo = "Prius";
        public string pais = "Dubai";
        public string Placa = "MGF-5763";
        public int año = 2020;


        public void llenar_Datos()
        {
            Console.WriteLine("Escriba la marca: ");
            Marca = Console.ReadLine();
            Console.WriteLine("Esciba el modelo: ");
            Modelo = Console.ReadLine();
            Console.WriteLine("Escribe el año: ");
            año = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe la placa: ");
            Placa = Console.ReadLine();
            Console.WriteLine("Pais de fabricacion: ");
            pais = Console.ReadLine();

        }

        public void llenar_Datos(string m)
        {
            Marca = m;

        }

        public void llenar_Datos(string mo, int a)
        {
            Modelo = mo;
            año = a;
        }

        public void llenar_Datos(int añ, string mar)
        {
            año = añ;
            Marca = mar;
        }
    }
}
