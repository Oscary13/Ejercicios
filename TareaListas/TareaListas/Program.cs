using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaListas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine("De que sera tu lista selecciona un numero:");
            Console.WriteLine("(1) para Strings");
            Console.WriteLine("(2) para Numeros");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            int opc = int.Parse(Console.ReadLine());
            if (opc == 1)
            {
                listas lt = new listas();
                Console.ReadKey();
            }
            else if (opc == 2) 
            {
                numeros lt = new numeros();
                Console.ReadKey();
            }
        }
    }
}
