using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENUNIDAD3
{
    class Program
    {
        public static int h { get; private set; }


        struct datos
        {
            public string n;
            public int No_alumno;
            public int c_1;
            public int c_2;
            public int c_f;


        }
        static void Main(string[] args)
        {

            int m = 0;
            datos[] al = new datos[30];
            Console.WriteLine("-------------------------------------------");
            Console.Write("         ¿Cuantos alumnos ingresaran? : ");

            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------");
            for (int h = 0; h <= a; h++)
            {

                Console.WriteLine("Ingrese el numero del estudiante: ");
                al[h].No_alumno = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre del estudiante: ");
                al[h].n = Console.ReadLine();
                Console.WriteLine("CALIFICACION 1 del estudiante: ");
                al[h].c_1 = int.Parse(Console.ReadLine());
                Console.WriteLine("CALIFICACION 2 del estudiante: ");
                al[h].c_2 = int.Parse(Console.ReadLine());
                al[h].c_f = (al[h].c_1 + al[h].c_2) / 2;
                Console.WriteLine("------------------------------------------");
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("                        LISTA ORDENADA");
            Console.WriteLine("-------------------------------------------------------------");
            for (int h = 0; h <= a; h++)
            {

                Console.WriteLine("No. De estudiante: " + al[h].No_alumno + " Nombre del alumno: " + al[h].n + " Calificacion final: " + al[h].c_f);


            }
            Console.WriteLine("-------------------------------------------------------------");
            if (al[h].c_f > m)
            {
                m = al[h].c_f;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("La calificacion mayor fue:  " + m);



            Console.ReadKey();
        }

    }
}