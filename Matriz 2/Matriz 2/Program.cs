﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] abc = new char[29] { '-', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '.',  };
            int[,] mtz = new int [3, 3];


            for (byte i = 0; i < 3; i++)
            {
                for (byte k = 0; k < 3; k++)
                {
                    Console.WriteLine("Ingresa el número C{0}{1}", i + 1, k + 1);
                    mtz[i, k] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("Ingresa el texto a cifrar:");
            string cadena = Console.ReadLine();

            Console.Clear();
            char[] chars = cadena.ToCharArray();
            int num = cadena.Length / 3;
            int[,] pos = new int[num, 3];
            int contador = 0;
            for (byte i = 0; i < num; i++)
            {
                for (byte k = 0; k < 3; k++)
                {
                    int po = Array.IndexOf(abc, chars[contador]);
                    pos[i, k] = po;
                    contador++;
                }

                int[] cif = new int[cadena.Length];
                contador = 0;
                int r = 0;
                int r2 = 0;
                int r3 = 0;
                for (byte h = 0; h < num; h++)
                {
        
                     r = 0;
                    for (byte k = 0; k < 3; k++)
                    {
                        r += pos[i, k] * mtz[k, i];
                        r2 += pos[i, k] * mtz[k, i];
                        r3 += pos[i, k] * mtz[k, i];

                    }
                    cif[contador] = r;
                    cif[contador+1] = r2;
                    cif[contador+2] = r3;
                    contador += 3;

                }

                foreach (int c in cif)
                {
                    Console.WriteLine(c + "-");

                }
                Console.ReadKey();

                //POS FN * MTZ

                //Console.WriteLine("fila 1 " +pos[0,0]+" "+pos[0,1]+" "+pos[0,2]);


                /*
                * Seccion donde se imprime matriz de texto en matriz
                *
                */
                //for (byte i = 0; i < num; i++)
                //{
                // for (byte k = 0; k < 3; k++)
                // {
                // Console.Write(pos[i, k] + " ");
                // }
                // Console.WriteLine();
                //

            }
        }
    }
}
