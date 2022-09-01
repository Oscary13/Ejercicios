using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAso_de_estudio2
{
    class Program
    {

        struct Dat
        {
            public string nom;
            public double cali1;
            public double Po1;
            public double cali2;
            public double Po2;
            public double cali3;
            public double Po3;
            public double promedio;
            public string AyR;
        }

        static void Main(string[] args)
        {
            CalculadoraBasica ca = new CalculadoraBasica();
            int selecciona, cam;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine(" ------------------------------------------------------------------------");
                    Console.WriteLine("                         BIENVENIDO PROFESOR DAVID                       ");
                    Console.WriteLine(" ------------------------------------------------------------------------");
                    Console.WriteLine(" Seleccione un software: ");
                    Console.WriteLine(" ------------------------------------------------------------------------");
                    Console.WriteLine(" (1).- CALCULADOR DE PROMEDIO DE GRUPOS");
                    Console.WriteLine(" (2).- CALCULADORA BASICA");
                    Console.WriteLine(" ------------------------------------------------------------------------");
                    selecciona = int.Parse(Console.ReadLine());
                } while (selecciona < 1 || selecciona > 2);
                switch (selecciona)
                {
                    case 1:
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
                            Console.WriteLine("------------------------------");
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Ingrese el grupo que evaluara: ");
                            Console.ResetColor();
                            Console.WriteLine("------------------------------");
                            string grupo = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("---------------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Ingrese el número de alumnos que contiene el grupo: ");
                            Console.ResetColor();
                            Console.WriteLine("---------------------------------------------------");
                            int Nalumnos = int.Parse(Console.ReadLine());
                            int mes = 0;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("----------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine(" Digite el numero del mes en el que se realizara la evaluación:");
                                Console.ResetColor();
                                Console.WriteLine("----------------------------------------------------------------");
                                Console.WriteLine("(1).-  ENERO");
                                Console.WriteLine("(2).-  FEBRERO");
                                Console.WriteLine("(3).-  MARZO");
                                Console.WriteLine("(4).-  ABRIL");
                                Console.WriteLine("(5).-  MAYO");
                                Console.WriteLine("(6).-  JUNIO");
                                Console.WriteLine("(7).-  JULIO");
                                Console.WriteLine("(8).-  AGOSTO");
                                Console.WriteLine("(9).-  SEPTIEMBRE");
                                Console.WriteLine("(10).- OCTUBRE");
                                Console.WriteLine("(11).- NOBIEMBRE");
                                Console.WriteLine("(12).- DICIEMBRE");
                                Console.WriteLine("--------------------------------------------------------------");
                                mes = int.Parse(Console.ReadLine());
                            } while (mes < 1 | mes > 12);
                            string mes2 = "";
                            switch (mes)
                            {
                                case 1:
                                    mes2 = "ENERO";
                                    break;
                                case 2:
                                    mes2 = "FEBREO";
                                    break;
                                case 3:
                                    mes2 = "MARZO";
                                    break;
                                case 4:
                                    mes2 = "ABRIL";
                                    break;
                                case 5:
                                    mes2 = "MAYO";
                                    break;
                                case 6:
                                    mes2 = "JUNIO";
                                    break;
                                case 7:
                                    mes2 = "JULIO";
                                    break;
                                case 8:
                                    mes2 = "AGOSTO";
                                    break;
                                case 9:
                                    mes2 = "SEPTIEMBRE";
                                    break;
                                case 10:
                                    mes2 = "OCTUBRE";
                                    break;
                                case 11:
                                    mes2 = "NOVIEMBRE";
                                    break;
                                case 12:
                                    mes2 = "DICIEMBRE";
                                    break;
                            }
                            double suma = 0;
                            double suma1 = 0;
                            double suma2 = 0;
                            double suma3 = 0;
                            double promedio2;
                            double promedio3;
                            double promedio4;
                            double promedio5;
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
                                    Console.WriteLine("Calificación de examen 10 = 60% : ");
                                    alumno[i].cali1 = double.Parse(Console.ReadLine());
                                    alumno[i].Po1 = alumno[i].cali1 * 60 / 10;



                                } while (!(alumno[i].cali1 >= 0 & alumno[i].cali1 <= 10));
                                suma1 = suma1 + alumno[i].Po1;
                                alumno[i].cali1 = alumno[i].cali1 * 60 / 100;
                                Console.WriteLine();
                                do
                                {
                                    Console.WriteLine("Calificación de tareas 10 = 10% : ");
                                    alumno[i].cali2 = double.Parse(Console.ReadLine());
                                    alumno[i].Po2 = alumno[i].cali2 * 10 / 10;


                                } while (!(alumno[i].cali2 >= 0 & alumno[i].cali2 <= 10));
                                suma2 = suma2 + alumno[i].Po2;
                                alumno[i].cali2 = alumno[i].cali2 * 10 / 100;
                                Console.WriteLine();
                                do
                                {
                                    Console.WriteLine("Calificación de apuntes 10 = 30% :");
                                    alumno[i].cali3 = double.Parse(Console.ReadLine());
                                    alumno[i].Po3 = alumno[i].cali3 * 30 / 10;


                                } while (!(alumno[i].cali3 >= 0 & alumno[i].cali3 <= 10));
                                suma3 = suma3 + alumno[i].Po3;
                                alumno[i].cali3 = alumno[i].cali3 * 30 / 100;
                                alumno[i].promedio = alumno[i].cali1 + alumno[i].cali2 + alumno[i].cali3;
                                if (alumno[i].promedio > 6)
                                {
                                    alumno[i].AyR = " ";

                                }
                                else
                                {
                                    alumno[i].AyR = ": Alumno reprobado :(";
                                    Console.ResetColor();
                                }
                                suma = suma + alumno[i].promedio;
                            }
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------------------");
                            Console.Write($"                   EVALUACIONES DEL MES DE  ");
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($"{mes2}");
                            Console.ResetColor();
                            Console.WriteLine("-------------------------------------------------------------------------");
                            Console.WriteLine();

                            promedio2 = 1.0 * suma / Nalumnos;
                            promedio3 = (suma1 / Nalumnos) * 10 / 10;
                            promedio4 = (suma2 / Nalumnos) * 10 / 10;
                            promedio5 = (suma3 / Nalumnos) * 10 / 10;
                            Console.WriteLine("-------------------------------------------------------------------------");
                            for (int i = 0; i < Nalumnos; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write($"{ alumno[i].nom}");
                                Console.ResetColor();
                                Console.Write($"; calificación final : ");
                                Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write($"{Math.Round(alumno[i].promedio, 2)}");
                                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"{ alumno[i].AyR}");
                                Console.ResetColor();
                                Console.WriteLine();
                                Console.WriteLine($" Examen: {alumno[i].Po1} % de 60%");
                                Console.WriteLine($" Tareas: {alumno[i].Po2} % de 10%");
                                Console.WriteLine($" Apuntes: {alumno[i].Po3} % de 30%");

                                Console.WriteLine("-------------------------------------------------------------------------");
                            }
                            Console.WriteLine();
                            Console.WriteLine("-------------------------------------------------------------------------");
                            Console.Write($"El promedio general del grupo;");
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write($" {grupo}");
                            Console.ResetColor();
                            Console.Write($" es: ");
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($"{Math.Round(promedio2, 2)}");
                            Console.ResetColor();
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($" Examen: {Math.Round(promedio3, 2)} % de 60%");
                            Console.WriteLine($" Tareas: {Math.Round(promedio4, 2)} % de 10%");
                            Console.WriteLine($" Apuntes: {Math.Round(promedio5, 2)} % de 30%");
                            Console.ResetColor();
                            Console.WriteLine("-------------------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("-------------------------------------------------------------------------");
                            Console.WriteLine("                ¿ DESEA REALIZAR OTRO CALCULO DE PROMEDIOS ?");
                            Console.WriteLine("-------------------------------------------------------------------------");
                            Console.WriteLine("(1).- SI");
                            Console.WriteLine("(2).- NO");
                            Console.WriteLine("-------------------------------------------------------------------------");
                            otra = int.Parse(Console.ReadLine());
                        } while (otra == 1);

                        break;
                    case 2:
                        ca.CalculadoraBasicaa();
                        DateTime fecha1 = DateTime.Now;
                        Console.WriteLine();
                        Console.WriteLine(fecha1.ToLongDateString());
                        break;
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------------------------------------------------------");
                Console.WriteLine("                      ¿ QUIERES ELEGIR OTRO SOFTWARE ?");
                Console.WriteLine(" ------------------------------------------------------------------------");
                Console.WriteLine($"(1).- SI");
                Console.WriteLine("(2).- NO");
                Console.WriteLine(" ------------------------------------------------------------------------");
                cam = int.Parse(Console.ReadLine());

            } while (cam ==1);
        }
    }
}
