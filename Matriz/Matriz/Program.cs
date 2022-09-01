using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] abc = new string[29] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", ".", " - " };

            double[,] mtz = new double[3, 3];

            for (byte i = 0; i < 3; i++)
            {
                for (byte k = 0; k < 3; k++)
                {
                    Console.WriteLine("ingrese el numero c{0} {1}", i + 1, k + 1);

                    mtz[i, k] = double.Parse(Console.ReadLine());
                }

            }
            Console.Clear();
            
            string cadena = "";
            Console.WriteLine("Ingresa el texto a cifrar:");
            cadena =
                cadena = Console.ReadLine();
            char[] charArry = new char[cadena.Length];
            int[] pos = new int[cadena.Length];

            Console.Clear();
            for (byte i = 0; i < cadena.Length ; i++)
            {
                char le = cadena[i];
                charArry[i] = cadena[i];
                int po = charArry.IndexOf(abc, le);

            }


        }
    }
}
