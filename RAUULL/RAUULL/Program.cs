using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigoo
{
    class Program
    {
        public static int[] ARRAYUNO = new int[1];
        public static int[] ARRAYDOS = new int[2];
        public static int[] ARRAYTRES = new int[4];
        public static int[] ARRAYCUATRO = new int[8];


        static void Main(string[] args)
        {
            Console.WriteLine("--Bienvenido al sistema de almacenamiento arbolo--");
            Console.WriteLine("--Para iniciar debe ingresar el no raiz del arbol--");
            Console.WriteLine("--Ingrese el valor del nodo raiz--");
            ARRAYUNO[0] = int.Parse(Console.ReadLine());

            Console.WriteLine(" Este nodo " + ARRAYUNO[0] + " contiene un nodo a la izquierda 1=Si/ 2=No ");
            int respuesta = int.Parse(Console.ReadLine());

            if (respuesta == 1)
            {
                Console.WriteLine("Ingresa el valor del nodo (" + ARRAYUNO[0] + ") izquierdo");
                ARRAYDOS[0] = int.Parse(Console.ReadLine());

                Console.WriteLine("Este nodo (" + ARRAYDOS[0] + ") contiene un nodo a la izquierda 1=Si/ 2=No");
                respuesta = int.Parse(Console.ReadLine());

                if (respuesta == 1)
                {
                    Console.WriteLine("Ingresa el valor del nodo " + ARRAYDOS[0] + " izquierdo");
                    ARRAYTRES[0] = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("Este nodo (" + ARRAYDOS[0] + ") contiene un nodo a la derecha 1=Si/ 2=No");
            respuesta = int.Parse(Console.ReadLine());

            if (respuesta == 1)
            {
                Console.WriteLine("Ingresa el valor del nodo " + ARRAYDOS[0] + " derecho");
                ARRAYTRES[1] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" Este nodo " + ARRAYUNO[0] + " contiene un nodo a la derecha 1=Si/ 2=No");
            respuesta = int.Parse(Console.ReadLine());

            if (respuesta == 1)
            {
                Console.WriteLine(" Ingresa el valor del nodo " + ARRAYUNO[0] + " derecho ");
                ARRAYDOS[1] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" Este nodo " + ARRAYDOS[1] + " contiene un nodo a la izquierda 1=Si/ 2=No");
            respuesta = int.Parse(Console.ReadLine());

            if (respuesta == 1)
            {
                Console.WriteLine(" Ingresa el valor del nodo " + ARRAYDOS[1] + " izquierda ");
                ARRAYTRES[2] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" Este nodo " + ARRAYDOS[1] + " contiene un nodo a la derecha 1=Si/ 2=No");
            respuesta = int.Parse(Console.ReadLine());

            if (respuesta == 1)
            {
                Console.WriteLine(" Ingresa el valor del nodo " + ARRAYDOS[1] + " derecha ");
                ARRAYTRES[3] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" Este nodo " + ARRAYTRES[0] + " contiene un nodo a la IZQUIERDA 1=Si/ 2=No");
            respuesta = int.Parse(Console.ReadLine());

            if (respuesta == 1)
            {
                Console.WriteLine(" Ingresa el valor del nodo " + ARRAYTRES[0] + " IZQUIERDA ");
                ARRAYCUATRO[0] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" Este nodo " + ARRAYTRES[0] + " contiene un nodo a la DERECHA 1=Si/ 2=No");
            respuesta = int.Parse(Console.ReadLine());

            if (respuesta == 1)
            {
                Console.WriteLine(" Ingresa el valor del nodo " + ARRAYTRES[0] + " derecha ");
                ARRAYCUATRO[1] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" Este nodo " + ARRAYTRES[1] + " contiene un nodo a la IZQUIERDA 1=Si/ 2=No");
            respuesta = int.Parse(Console.ReadLine());

            if (respuesta == 1)
            {
                Console.WriteLine(" Ingresa el valor del nodo " + ARRAYTRES[1] + " IZQUIERDA ");
                ARRAYCUATRO[2] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" Este nodo " + ARRAYTRES[1] + " contiene un nodo a la DERECHA 1=Si/ 2=No");
            respuesta = int.Parse(Console.ReadLine());

            if (respuesta == 1)
            {
                Console.WriteLine(" Ingresa el valor del nodo " + ARRAYTRES[1] + " derecha ");
                ARRAYCUATRO[3] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" Este nodo " + ARRAYTRES[2] + " contiene un nodo a la IZQUIERDA 1=Si/ 2=No");
            respuesta = int.Parse(Console.ReadLine());

            if (respuesta == 1)
            {
                Console.WriteLine(" Ingresa el valor del nodo " + ARRAYTRES[2] + " IZQUIERDA ");
                ARRAYCUATRO[4] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" Este nodo " + ARRAYTRES[2] + " contiene un nodo a la DERECHA 1=Si/ 2=No");
            respuesta = int.Parse(Console.ReadLine());

            if (respuesta == 1)
            {
                Console.WriteLine(" Ingresa el valor del nodo " + ARRAYTRES[2] + " derecha ");
                ARRAYCUATRO[5] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" Este nodo " + ARRAYTRES[3] + " contiene un nodo a la IZQUIERDA 1=Si/ 2=No");
            respuesta = int.Parse(Console.ReadLine());

            if (respuesta == 1)
            {
                Console.WriteLine(" Ingresa el valor del nodo " + ARRAYTRES[3] + " IZQUIERDA ");
                ARRAYCUATRO[6] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" Este nodo " + ARRAYTRES[3] + " contiene un nodo a la DERECHA 1=Si/ 2=No");
            respuesta = int.Parse(Console.ReadLine());

            if (respuesta == 1)
            {
                Console.WriteLine(" Ingresa el valor del nodo " + ARRAYTRES[3] + " derecha ");
                ARRAYCUATRO[7] = int.Parse(Console.ReadLine());
            }
            imprimir();

            Console.ReadKey();
        }

        public static void imprimir()
        {
            String A2 = "";
            string A3 = "";
            string A4 = "";
            Console.Clear();
            foreach (int item in ARRAYUNO)
            {
                if (item == 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("          " + item);
                }
                
            }
            foreach (int item in ARRAYDOS)
            {
                if (item == 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    A2 = A2 + ("      " + item);
                }
                
            }
            Console.WriteLine(A2);

            foreach (int item in ARRAYTRES)
            {
                if (item == 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    A3 = A3 + ("   " + item);
                }

                
            }
            Console.WriteLine(A3);

            foreach (int item in ARRAYCUATRO)
            {
                if (item == 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    A4 = A4 + (" " + item);
                }
                
            }
            Console.WriteLine(A4);

        }
    }
}