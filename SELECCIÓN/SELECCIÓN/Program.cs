using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SELECCIÓN
{
    class Program
    {
        public static int[] arrayseleccion = new int[10];
        static void Main(string[] args)
        {
            Console.WriteLine("--- SISTEMA DE ORDENAMIENTO POR SELECCÓN ---");
            Console.WriteLine("");
            llenar();
            Console.WriteLine("---------- ACENDENTE ----------");
            ordenarSelección();
            imprimir();
            Console.WriteLine("---------- DECENDENTE ----------");
            ordenarSelección2();
            imprimir();
            Console.ReadKey();

        }
        public static void llenar()
        {
            for (int i = 0; i < arrayseleccion.Length; i++)
            {
                Console.WriteLine("Ingrese el numero de la posicion " + (i+1));
                arrayseleccion[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El arreglo se lleno correctamente");
        }
        public static void imprimir()
        {
            string valor = "";
            foreach (var item in arrayseleccion)
            {
                valor = valor + "       " + item;
            }
            Console.WriteLine(valor);
        }
        public static void ordenarSelección()
        {
            int x = 0; 

            for (int i = 0; i < arrayseleccion.Length; i++)
            {
                x = arrayseleccion[i];
                int h = -1;
                for (int j = i; j < arrayseleccion.Length; j++)
                {
                    if (x >  arrayseleccion[j])
                    {
                        x = arrayseleccion[j];
                        h = j;
                    }
                }
                if (h!= -1)
                {
                    arrayseleccion[h] = arrayseleccion[i];
                    arrayseleccion[i] = x;
                }
            }
        }
        public static void ordenarSelección2()
        {
            int x = 0;

            for (int i = 0; i < arrayseleccion.Length; i++)
            {
                x = arrayseleccion[i];
                int h = -1;
                for (int j = i; j < arrayseleccion.Length; j++)
                {
                    if (x < arrayseleccion[j])
                    {
                        x = arrayseleccion[j];
                        h = j;
                    }
                }
                if (h != -1)
                {
                    arrayseleccion[h] = arrayseleccion[i];
                    arrayseleccion[i] = x;
                }
            }
        }
    }
}
