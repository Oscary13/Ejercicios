using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen___Estacionamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            int otra;
            do
            {
                float can, r;
                Console.WriteLine("BIENVENIDO AL SISTEMA DE COBRO DE ESTACIONAMIENTO -OBB-");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Ingrese la cantidad de minutos que permanecio en el establecimiento");
                int tiempo = int.Parse(Console.ReadLine());
                can = 0;
                if (tiempo <= 60)
                {
                    can = 11;
                }
                else if (tiempo >= 61 & tiempo <= 120)
                {
                    can = 21;
                }
                else if (tiempo >= 121 & tiempo <= 180)
                {
                    can = 31;
                }
                else if (tiempo >= 181 & tiempo <= 240)
                {
                    can = 41;
                }
                else if (tiempo >= 241 & tiempo <= 300)
                {
                    can = 51;
                }
                else if (tiempo >= 301 & tiempo <= 360)
                {
                    can = 61;
                }
                else if (tiempo >= 361 & tiempo <= 420)
                {
                    can = 71;
                }
                else if (tiempo >= 421)
                {
                    can = 81;
                }
                Console.WriteLine("¿Cuenta con un tiket de descuento?");
                Console.WriteLine("(1) Si");
                Console.WriteLine("(2) No");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        r = can - 6;
                        Console.WriteLine("El total a pagar es:  $" + r);
                        break;
                    case 2:
                        Console.WriteLine("El total a pagar es:  $" + can);
                        break;
                }
                Console.WriteLine("¿Desea realizar otro cobro de estacionamiento?");
                Console.WriteLine("(1) Si");
                Console.WriteLine("(2) No");
                otra = int.Parse(Console.ReadLine());
            } while (otra == 1);
            Console.WriteLine("GRACIAS POR UTILIZAR EL SISTEMA DE COBRO DE ESTACIONAMIENTO -OBB-");
            Console.ReadKey();
        }
    }
}
