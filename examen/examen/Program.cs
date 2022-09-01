using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
           
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Escribe un numero ");
                array[i] = int.Parse(Console.ReadLine());
            }


            
            Console.WriteLine("Estos son los numeros que ingresaste ");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
           
            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {

                    if (array[a] < array[b])
                    {
                        int temp = array[b];
                        array[b] = array[a];
                        array[a] = temp;

                    }
                }
            }


            Console.WriteLine ("Estos son los numeros ya ordenados ");
            foreach (int item in array)
            {
                Console.WriteLine( item );
            }
            Console.ReadKey();
        }
    }
}
