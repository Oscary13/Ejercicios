using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" ingrese el numero a incertar");
                vector[i] = int.Parse(Console.ReadLine());
            }
            foreach (int item in vector)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
