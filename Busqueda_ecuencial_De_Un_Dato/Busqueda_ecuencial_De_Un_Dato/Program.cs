using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_Secuencial_De_Un_Dato
{
    class Program
    {
        static void Main(string[] args)
        {
            int otra;
            do
            {
                Console.Clear();
                int numero, i = 0, pos = 0;
                int[] vec = { 2, 6, 0, 9, 88, 2, 1, 8, 65, 3 };
                bool encontro = false;
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("              EL ARREGLO ES: ");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine();
                for (i = 0; i < vec.Length - 1; i++)
                {
                    Console.WriteLine($"- - - - {vec[i]} - - - -");
                }
                i = 0;
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("      Ingresa el numero del cual quieres saber su posicion");
                Console.WriteLine("-----------------------------------------------------------------");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine();
                while (!(encontro) && i < 10)
                {
                    if (numero == vec[i])
                    {
                        encontro = true;
                        pos = i;
                    }
                    i = i + 1;
                }
                if (encontro)
                    Console.WriteLine($"El dato se encuentra y esta en la posición:  {pos + 1}");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("    ¿Desea realizar otro calculo de promedios?");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("   (1).- SI");
                Console.WriteLine("   (2).- NO");
                otra = int.Parse(Console.ReadLine());
            } while (otra == 1);


           
        }
    }
}
