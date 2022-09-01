using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carmen_Arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = { 23, 45, 67, 12, 23, 34, 67 }; 
            Console.WriteLine("EL ARREGLO ES: "); 
            for (int i = 0; i < numero.Length- 1; i++)
            {
                Console.WriteLine(numero[i]);
            }
            Console.WriteLine("Qué elemento quieres buscar?"); 
            int elemento = int.Parse(Console.ReadLine());
            busqueda_secuencial(numero, elemento);
            Console.ReadKey();
        }
        public static void busqueda_secuencial(int []arreglo, int dato)
        {
            for (int i = 0; i < arreglo.Length- 1; i++)
                if (arreglo[i] == dato)
                Console.WriteLine("Posición del elemento: " + i);
        }


    }
}
