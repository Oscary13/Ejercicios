using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBB2
{
    class Program
    {
        static void Main(string[] args)
        {
            int res;
            do
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Hola OBB" + i);
                }

                Console.WriteLine("Desea hacer otra operacion  1=Si  2=No");
                
                res = int.Parse(Console.ReadLine());
            } while (res == 1);
            Console.ReadKey();
        }
    }
    }
