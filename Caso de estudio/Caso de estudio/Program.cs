using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_de_estudio
{
    class Program
    {
        struct Dat
        {
            public string nom;
            public double cali1;
            public double cali2;
            public double cali3;
            public double promedio;
        }

        static void Main(string[] args)
        {


            int otra;
            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("- Calificaciones finales de los estudiantes y promedio general -");
                Console.ResetColor();
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Ingrese el grupo que evaluara: ");
                string grupo = Console.ReadLine();
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine();
                Console.Write("Ingrese el número de alumnos que contiene el grupo: ");
                int Nalumnos = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------------------------------------");
                double suma = 0;
                double promedio2;
                Dat[] alumno = new Dat[35];
                for (int i = 0; i < Nalumnos; i++)
                {

                    Console.Clear();
                    Console.WriteLine("Nombre completo del alumno:");
                    alumno[i].nom = Console.ReadLine();
                    Console.WriteLine();
                    alumno[i].promedio = 0;
                    do
                    {
                        Console.WriteLine("Calificación de examen: ");
                        alumno[i].cali1 = double.Parse(Console.ReadLine());

                    } while (!(alumno[i].cali1 >= 0 & alumno[i].cali1 <= 10));

                    Console.WriteLine();
                    do
                    {
                        Console.WriteLine("Calificación de trabajo en clase: ");
                        alumno[i].cali2 = double.Parse(Console.ReadLine());
                    } while (!(alumno[i].cali2 >= 0 & alumno[i].cali2 <= 10));

                    Console.WriteLine();
                    do
                    {
                        Console.WriteLine("Calificación de tareas: ");
                        alumno[i].cali3 = double.Parse(Console.ReadLine());
                    } while (!(alumno[i].cali3 >= 0 & alumno[i].cali3 <= 10));

                    alumno[i].promedio = (alumno[i].cali1 + alumno[i].cali2 + alumno[i].cali3) / 3;
                    suma = suma + alumno[i].promedio;
                }
                Console.Clear();
                promedio2 = 1.0 * suma / Nalumnos;
                Console.WriteLine("--------------------------------------------------------------------");
                for (int i = 0; i < Nalumnos; i++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write($"{ alumno[i].nom}");
                    Console.ResetColor();
                    Console.Write($"; calificación final : ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($"{Math.Round( alumno[i].promedio,2)}");
                    Console.ResetColor();
                    Console.WriteLine("--------------------------------------------------------------------");
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------------------------");
                Console.Write($"El promedio general del grupo;");
                Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write($" {grupo}");
                Console.ResetColor();
                Console.Write($" es: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($"{Math.Round(promedio2,2)}");
                Console.ResetColor();
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine();

                Console.WriteLine("¿Desea realizar otro calculo de promedios?");
                Console.WriteLine("(1).- SI");
                Console.WriteLine("(2).- NO"); 
                otra = int.Parse(Console.ReadLine());
            } while (otra == 1);
            Console.ReadKey();
        }
    }
}
