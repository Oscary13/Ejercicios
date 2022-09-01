using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURBUJA
{
    class Program
    {
        public static int [] arraynum   = new int[10];
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema de ordenamiento Burbuja");
            Console.WriteLine("Para iniciar debe ingresar 10 numero");
            Console.WriteLine();
            llenar();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Desea ordenar la lista de numeros");
            Console.WriteLine("(1) = SI Acendente");
            Console.WriteLine("(2) = SI Decendente");
            Console.WriteLine("(3) = NO");
            Console.WriteLine("----------------------------------------------");
            int ordenar = int.Parse(Console.ReadLine());
            if (ordenar == 1)
            {
                ordenarBurbuja();
            }
            if (ordenar ==2 )
            {
                ordenarBurbuja2();
            }
            else
            {
                imprimir();
            }
            Console.ReadKey();

        }
        public static void llenar()
        {
            for (int i = 0; i < arraynum.Length; i++)
            {
                Console.WriteLine("Ingrese el valor numero: " + (i+1));
                arraynum[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void imprimir()
        {
            string cadena = "";
            Console.WriteLine("              NUMEROS ORDENADOS");
            Console.WriteLine("----------------------------------------------");
            foreach (var item in arraynum)
            {
                cadena = cadena + "         " + item;
            }
            Console.WriteLine(cadena);
        }

        public static void ordenarBurbuja()
        {
            for (int i = 0; i < arraynum.Length; i++)
            {
                for (int j = i; j < arraynum.Length; j++)
                {
                    if (arraynum[i] > arraynum[j])
                    {
                        int x = arraynum[i];
                        arraynum[i] = arraynum[j];
                        arraynum[j] = x;
                        
                    }
                }
            }
            imprimir();
        }

        public static void ordenarBurbuja2()
        {
            for (int i = 0; i < arraynum.Length; i++)
            {
                for (int j = i; j < arraynum.Length; j++)
                {
                    if (arraynum[i] < arraynum[j])
                    {
                        int x = arraynum[i];
                        arraynum[i] = arraynum[j];
                        arraynum[j] = x;
                        
                    }
                }
            }
            imprimir();
        }

    }
}
