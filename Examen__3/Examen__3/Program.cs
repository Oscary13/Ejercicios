using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen__3
{
    class PruebaVector
    {
        pribate int[][] vector;
        public void cargar()
        {
            Console.WriteLine("-----------------------------------------");
            Console.Write(" Ingrese la cantidad de alumnos: ");
            string linea;
            linea = Console.ReadLine();
            Console.WriteLine("-----------------------------------------");
            int cant, n0, n1, n2, n3;
            cant = int.Parse(linea);
            vector = new int[n0][cant];
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            for (int f = 0; f < vector.Length; f++)
            {
                n1 = 0;
                n2 = 0;
                Console.Write("Ingrese la primera calificaccion del ALUMNO " + (f + 1) + ": ");
                n1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la primera calificaccion del ALUMNO " + (f + 1) + ": ");
                n2 = int.Parse(Console.ReadLine());
                n3 = (n1 + n2) / 2;
                vector[f][] = f+1;
                vector[][f] = n3;
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
                        if (vector[][e - 1] > vector[][(e - 1) + salto])
                        {
                            auxi = vector[][(e - 1) + salto];
                            vector[][(e - 1) + salto] = vector[][e - 1];
                            vector[][(e - 1)] = auxi;
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
                Console.Write(vector[][f] + "  ");
            }

        }


        static void Main(string[] args)
        {

            int otra;
            PruebaVector pv = new PruebaVector();
            do
            {
                Console.Clear();
                pv.cargar();
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
