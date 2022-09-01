using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_Shell
{
    class PruebaVector
    {
        private int[] vector;

        public void Cargar()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("           Metodo de Shell Sort");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.Write("Cual sera la longitud del vector: ");
            string linea;
            linea = Console.ReadLine();
            int cant;
            cant = int.Parse(linea);
            vector = new int[cant];
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write("Ingrese elemento " + (f + 1) + ": ");
                linea = Console.ReadLine();
                vector[f] = int.Parse(linea);
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }

        public void Shell()
        {
            int salto = 0;
            int sw = 0;
            int auxi = 0;
            int e = 0;
            salto = vector.Length / 2;
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while (e <= (vector.Length - salto))
                    {
                        if (vector[e - 1] > vector[(e - 1) + salto])
                        {
                            auxi = vector[(e - 1) + salto];
                            vector[(e - 1) + salto] = vector[e - 1];
                            vector[(e - 1)] = auxi;
                            sw = 1;
                        }
                        e++;
                    }
                }
                salto = salto / 2;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("  Vector ordenados en forma ascendente");
            Console.WriteLine("-----------------------------------------");
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }
            
        }


        static void Main(string[] args)
        {
            
            int otra;
            PruebaVector pv = new PruebaVector();
            do
            {
                Console.Clear();
                pv.Cargar();
                pv.Shell();
                pv.Imprimir();
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("    ¿Desea realizar otra operacion?");
                Console.WriteLine("              (1).- SI");
                Console.WriteLine("              (2).- NO");
                Console.WriteLine("-----------------------------------------");
                otra = int.Parse(Console.ReadLine());
            } while (otra == 1);
            
        }
    }
}
