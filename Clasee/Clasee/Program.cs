using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("        Program de clase");
            Console.WriteLine("------------------------------");
            Vehiculo mivheiculo = new Vehiculo();
            mivheiculo.marca = "Nissan";
            mivheiculo.placa = "Tsuru1212";
            mivheiculo.modelo = 2021;
            Console.WriteLine("La marca del coche es:" + mivheiculo.marca + " con una placa: " + mivheiculo.placa + " y modelo: " + mivheiculo.modelo);

            Personas persona1 = new Personas();
            Console.WriteLine("Ingrese Su nombre:");
            persona1.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su Apellido Paterno:");
            persona1.Apaterno = Console.ReadLine();
            Console.WriteLine("Ingrese su Apellido Materno:");
            persona1.Amaterno = Console.ReadLine();
            Console.WriteLine("Ingrese su Genero (1)- Masculino  (0)- Femenino:");
            persona1.Genero = Convert.ToBoolean(int.Parse(Console.ReadLine()));
            Console.WriteLine("Ingrese su Direccion:");
            persona1.Direccion = Console.ReadLine();
            Console.WriteLine("Ingrese su Edad:");
            persona1.Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su CURP:");
            persona1.CURP = Console.ReadLine();
            Console.WriteLine("Ingrese su Peso:");
            persona1.Peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su Numero telefonico:");
            persona1.Ntelefono = Console.ReadLine();
            string Genero =  "";
            if (persona1.Genero)
            {
                Genero = "Masculino";
            }
            else
            {
                Genero = "Femenino";
            }
            Console.WriteLine(" El nombre es: " + persona1.Nombre+ " "+ persona1.Apaterno+ " "+ persona1.Amaterno+ " De genero: "+ persona1.Genero +"  Edad: "+persona1.Edad+ " Peso:" + persona1.Peso);
            Console.WriteLine(" Con direccion: " + persona1.Direccion + " Su CURP es: " + persona1.CURP + " Y su numero telefonico es: " + persona1.Ntelefono );
            Console.ReadKey();
        }
    }
}
