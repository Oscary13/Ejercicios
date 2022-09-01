  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Abstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            Datos d = new Datos();
            string saludo = d.Bienvenida();
            int res = d.suma(4,3);
            int respuesta = d.sumaNumeros(2,4);
            Console.WriteLine($"{saludo} Valor de res: {res}  Valor de respuesta: {respuesta}");
            Console.ReadKey();

        }
    }
}
