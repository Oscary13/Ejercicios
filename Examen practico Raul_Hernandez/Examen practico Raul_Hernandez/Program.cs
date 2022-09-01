using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_practico_Raul_Hernandez
{
    class Program
    {
        static void Main(string[] args)
        {

            int opc;
            do
            {

                do
                {
                    Console.Clear();
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("|    BIENVENIDO AL PROGRAMA -INVERSOR DE FRASES-   |");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("| (1).- Escribir una frase  e invertirla           |");
                    Console.WriteLine("| (2).- Salir                                      |");
                    Console.WriteLine("----------------------------------------------------");
                    opc = int.Parse(Console.ReadLine());
                } while (opc < 1 | opc > 2);
                switch (opc)
                {
                    case 1:
                        Console.WriteLine();
                        string Frase = "";
                        Console.WriteLine("----------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("    Escribe la frase que quieres invertir: ");
                        Console.ResetColor();
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine();
                        Frase = Console.ReadLine();
                        string[] palabras = Frase.Split(' ');
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("           LA PALABRA INVERTIDA ES: ");
                        Console.ResetColor();
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine();
                        for (int y = palabras.GetLength(0) - 1; y >= 0; y--)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write(palabras[y] + " ");
                            Console.ResetColor();
                        }

                        break;
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(">>>>>> ENTER PARA CONTINUAR <<<<<<");
                Console.ResetColor();
                Console.ReadKey();

            } while (opc != 2);
           
        }
    }
}
