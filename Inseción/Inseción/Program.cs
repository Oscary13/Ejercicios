using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inseción
{
    class Inserción
    {
        private int[] vector;

        public void Cargar()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("          Metodo de insercion directa");
            Console.WriteLine("---------------------------------------------");
            Console.Write("INGRESA LA LONGITUD DE TU VECTOR:");
            string linea;
            Console.WriteLine();
            linea = Console.ReadLine();
            int cant;
            cant = int.Parse(linea);
            vector = new int[cant];
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write("INGRESE EL ELEMENTO NO. " + (f + 1) + ": ");
                linea = Console.ReadLine();
                vector[f] = int.Parse(linea);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void InsercionDirecta()
        {
            int auxili;
            int j;
            for (int i = 0; i < vector.Length; i++)
            {
                auxili = vector[i];
                j = i - 1;
                while (j >= 0 && vector[j] > auxili)
                {
                    vector[j + 1] = vector[j];
                    j--;
                }
                vector[j + 1] = auxili;
            }
        }
        public void InsercionDirecta2()
        {
            int auxili;
            int j;
            for (int i = 0; i < vector.Length; i++)
            {
                auxili = vector[i];
                j = i - 1;
                while (j >= 0 && vector[j] > auxili)
                {
                    vector[j + 1] = vector[j];
                    j--;
                }
                vector[j + 1] = auxili;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Vector ordenados en forma ascendente");
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }
            Console.ReadKey();
        }
          public void Imprimir2()
        {
            Console.WriteLine("Vector ordenados en forma ascendente");
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Inserción pv = new Inserción();
            pv.Cargar();
            pv.InsercionDirecta();
            pv.Imprimir();
            Console.WriteLine();
            pv.InsercionDirecta2();
            pv.Imprimir();
        }
    }
}
