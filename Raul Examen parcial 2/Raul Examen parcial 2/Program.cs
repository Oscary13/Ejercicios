using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raul_Examen_parcial_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ot;
            do
            {
                float cambio, resultado;
                Console.WriteLine("Cuanto tiempo en minutos estuvo en nuestro establecimiento");
                int t = int.Parse(Console.ReadLine());
                cambio = 0;
                if (t <= 60)
                {
                    cambio = 11;
                }
                else if (t >= 61 & t <= 120)
                {
                    cambio = 21;
                }
                else if (t >= 121 & t <= 180)
                {
                    cambio = 31;
                }
                else if (t >= 181 & t <= 240)
                {
                    cambio = 41;
                }
                else if (t >= 241 & t <= 300)
                {
                    cambio = 51;
                }
                else if (t >= 301 & t <= 360)
                {
                    cambio = 61;
                }
                else if (t >= 361)
                {
                    cambio = 71;
                }

                Console.WriteLine("¿Tienes tiket para que te realicemos un descuento?");
                Console.WriteLine("1 - Si     2 - No ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        resultado = cambio - 6;
                        Console.WriteLine("Cantidad a pagar:  " + resultado);
                        break;
                    case 2:
                        Console.WriteLine("Cantidad a pagar:  " + cambio);
                        break;
                }
                Console.WriteLine("¿Desea realizar otro cobro de estacionamiento?");
                Console.WriteLine("1 - Si       2- No");
                ot = int.Parse(Console.ReadLine());
            } while (ot == 1);
            Console.ReadKey();
        }
    }
}
