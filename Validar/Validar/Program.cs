using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validar
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int otra;
            do
            {
                contador++;
                Console.WriteLine("---------------------------");
                Console.WriteLine("SISTEMA DE ACCESOS Y VENTAS");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Ingrese su usuario:");
                string usuario = Console.ReadLine();
                Console.WriteLine("Ingrese la contraseña");
                string contraseña = Console.ReadLine();

                Valida val = new Valida();
                Productos prod = new Productos();
                string res = val.ValidaDatosAcceso(usuario, contraseña);

                if (res == "ok")
                {
                    prod.menuproductos();
                }
                else
                {
                    Console.WriteLine(res);
                    contador++;
                }

                if (contador == 4 )
                {
                    Console.WriteLine("Acceso invalido, 3 intentos fallidos");
                    Console.ReadKey();
                    otra = 2;
                }
                else
                {
                    Console.WriteLine("Desea realizar otra operación; ");
                    Console.WriteLine("(1).- SI");
                    Console.WriteLine("(2).- NO");
                    otra = int.Parse(Console.ReadLine());
                }
              

            } while (otra == 1);
            Console.WriteLine("Gracias por utilizar nustro sistema");
            Console.ReadKey();

        }
    }
}
