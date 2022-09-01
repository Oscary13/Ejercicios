using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("        Program de clase");
            Console.WriteLine("------------------------------");

            Veiculo mivehiculo = new Veiculo();
            mivheiculo.marca = "Nissan";
            mivehiculo.placa = "XLS1980";
            mivehiculo.modelo = 2021;
            Console.WriteLine("La marca del Vehiculoes:"+ mivehiculo.marca + " con una placa: ") + mivehiculo.placa + " y modelo: " + mivehiculo.modelo);
            Console.ReadKey();
        }
    }
}
