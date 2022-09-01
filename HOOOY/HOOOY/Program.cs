using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBB
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digita el numero: " + (i + 1));
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {

                    if (array[a] > array[b])
                    {
                        int temp = array[b];
                        array[b] = array[a];
                        array[a] = temp;
                   
                    }
                }
            }
            Console.WriteLine("---------------------------");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
