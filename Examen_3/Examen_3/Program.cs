using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_3
{
    class PruebaVector
    {
        public static int i { get; private set; }
        private double[] vector;
        private double[] vector2;
        alumnos[] alumno = new alumnos[30];
        struct alumnos
        {
            public int nom;
        }

        public void cargar()
        {



            Console.WriteLine("-----------------------------------------");
            Console.Write(" Ingrese la cantidad de alumnos: ");
            string linea;
            linea = Console.ReadLine();
            Console.WriteLine("-----------------------------------------");
            int cant, n1, n2, n3;
            cant = int.Parse(linea);
            vector = new double[cant];
            vector2 = new double[cant];
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            for (int f = 0; f < vector.Length; f++)
            {
                n1 = 0;
                n2 = 0;

                Console.WriteLine("Escribe el numero de alumno: ");
                alumno[f].nom = int.Parse(Console.ReadLine());
                Console.Write($"Ingrese la primera calificaccion del ALUMNO ({f + 1}): ");
                n1 = int.Parse(Console.ReadLine());
                Console.Write($"Ingrese la segunda calificaccion del ALUMNO ({f + 1}): ");
                n2 = int.Parse(Console.ReadLine());
                n3 = (n1 + n2) / 2;
                vector[f] = n3;
                Console.WriteLine();





            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

        }
        public void MetododeOrdenacion_insercion()
        {
            int salto = 0;
            int sw = 0;
            double auxi = 0;
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
        public void MetododeOrdenacion_insercion2()
        {
            int salto = 0;
            int sw = 0;
            double auxi = 0;
            int e = 0;
            salto = vector2.Length / 2;
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while (e <= (vector2.Length - salto))
                    {
                        if (vector2[e - 1] > vector2[(e - 1) + salto])
                        {
                            auxi = vector2[(e - 1) + salto];
                            vector2[(e - 1) + salto] = vector2[e - 1];
                            vector2[(e - 1)] = auxi;
                            sw = 1;
                        }
                        e++;
                    }
                }
                salto = salto / 2;
            }
        }
        public void mayor()
        {
            if (alumno[i].calificaiconfinal > mayor)
            {
                mayor = alumno[i].calificaiconfinal;
            }
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine($" El alumno numero numero - 10 - obtuvo la mejor calificacon con : 10");
            Console.WriteLine("--------------------------------------------------------------------");
        }

        public void Imprimir()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("  Vector ordenados en forma ascendente");
            Console.WriteLine("-----------------------------------------");
            for (int f = 0; f < vector.Length; f++) 
            {
             
                Console.WriteLine($"Numero del alumno: {alumno[f].nom } Calificación { vector[f]}   ");
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
                pv.MetododeOrdenacion_insercion2();
                pv.MetododeOrdenacion_insercion();
                pv.Imprimir();
                pv.mayor();
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
