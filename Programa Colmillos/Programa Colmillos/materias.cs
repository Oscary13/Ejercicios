using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmillos
{
    class Clase_materias
    {
        public string t;
        public int x = 0, n = 0;
        public double calg;
        public double tot, ctarea, ctclase, cexamen;
        public void des()
        {
            Console.Clear();
            Console.WriteLine(" DIGITE EL NOMBRE DEL GRUPO A EVALUAR ");
            string grupo = Console.ReadLine();
            Console.WriteLine(" DIGITE EL NOMBRE DE LA MATERIA A EVALUAR ");
            string materia = Console.ReadLine();
            Console.WriteLine(" LOS RUBROS A EVALUAR SON: ");
            Console.WriteLine(" TAREAS                 10%");
            Console.WriteLine(" TRABAJO EN CLASE       30%");
            Console.WriteLine(" EXAMEN                 60%");
            Console.WriteLine(" DIGITE LA CANTIDAD DE ALUMNOS A EVALUAR ");
            n = int.Parse(Console.ReadLine());
            double[] examen = new double[n];
            double cal = 0, cali = 0, calif = 0, califi = 0;
            //double ct, ctc, ce;
            double[] tareas = new double[n];
            double[] tclase = new double[n];
            string[] name = new string[n];
            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" INGRESE EL NOMBRE DEL ALUMNO ");
                name[i] = Console.ReadLine();
                Console.WriteLine(" DIGITE SU CALIFICACION DE TAREAS ");
                tareas[i] = double.Parse(Console.ReadLine());
                Console.WriteLine(" DIGITE SU CALIFICACION DE TRABAJO EN CLASE ");
                tclase[i] = double.Parse(Console.ReadLine());
                Console.WriteLine(" DIGITE SU CALIFICACION DE EXAMEN ");
                examen[i] = double.Parse(Console.ReadLine());
            }
            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                x += 1;
                cal = (tareas[i] + tclase[i] + examen[i]) / 3;
                cali = (tareas[i] * 10 / 10);
                calif = (tclase[i] * 30 / 10);
                califi = (examen[i] * 60 / 10);
                ctarea += tareas[i] / n * 10 / 10;
                ctclase += tclase[i] / n * 30 / 10;
                cexamen += examen[i] / n * 60 / 10;
                if (cal == 10)
                {
                    t = " EXCELENTE ";
                }
                else if (cal > 8.9 && cal < 10)
                {
                    t = " BUENA ";
                }
                else if (cal < 9 && cal > 7.9)
                {
                    t = " REGULAR ";
                }
                else if (cal < 8 && cal > 6.9)
                {
                    t = " BAJO ";
                }
                else if (cal < 6)
                {
                    t = " REPROBATORIA ";
                    Console.WriteLine(" LA CALIFICACION DEL ALUMNO/A " + name[i] + " ES " + t + "{0:N2}", cal);
                    Console.WriteLine(" EL ALUMNO NECESITA UNA ASESORIA INDIVIDUAL");
                    Console.WriteLine(" TAREAS                 " + Math.Round(cali, 02) + "%");
                    Console.WriteLine(" TRABAJO EN CLASE       " + Math.Round(calif, 02) + "%");
                    Console.WriteLine(" EXAMEN                 " + Math.Round(califi, 02) + "%");
                }
                if (cal > 6.9)
                {
                    Console.WriteLine(" LA CALIFICACION DEL ALUMNO/A " + name[i] + " ES " + t + "{0:N2}", cal);
                    Console.WriteLine(" TAREAS                 " + Math.Round(cali, 02) + "%");
                    Console.WriteLine(" TRABAJO EN CLASE       " + Math.Round(calif, 02) + "%");
                    Console.WriteLine(" EXAMEN                 " + Math.Round(califi, 02) + "%");
                }
                calg += cal;
                tot = calg / x;

            }
            if (tot == 10)
            {
                t = " EXCELENTE ";
            }
            else if (tot > 8.9 && tot < 10)
            {
                t = " BUENA ";
            }
            else if (tot < 9 && tot > 7.9)
            {
                t = " REGULAR ";
            }
            else if (tot < 8 && tot > 6.9)
            {
                t = " INSUFICIENTE ";
            }
            else if (tot < 7)
            {
                t = " REPROBATORIA ";
            }

            Console.WriteLine(" ----------------------------------------------------------------------");
            Console.WriteLine("                CALIFICACIONES DEL GRUPO " + grupo);
            Console.WriteLine(" ----------------------------------------------------------------------");
            Console.WriteLine(" " + materia + ": LA CALIFICACION ES: " + t + "{0:N2}", tot);
            Console.WriteLine(" TAREAS                 " + Math.Round(ctarea, 02) + "%");
            Console.WriteLine(" TRABAJO EN CLASE       " + Math.Round(ctclase, 02) + "%");
            Console.WriteLine(" EXAMEN                 " + Math.Round(cexamen, 02) + "%");
        }
    }
}
