using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_3321IS
{
    class Program
    {
        public static int[] array1 = new int[1];
        public static int[] array2 = new int[2];
        public static int[] array3 = new int[4];
        public static int[] array4 = new int[8];
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--- Bienvenido al Sistema de almacenamiento de Arbol ---");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("   Para iniciar debe ingresar el nodo  raiz del arbol ");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("        Por favor ingrese el valor del nodo raiz");
            Console.WriteLine("--------------------------------------------------------");
            array1[0] = int.Parse(Console.ReadLine());
            Console.WriteLine($"El nodo ({array1[0]}) contiene un nodo a la izquierda");
            Console.WriteLine("(1).- SI");
            Console.WriteLine("(2).- NO");
            int respuesta = int.Parse(Console.ReadLine());

            if (respuesta == 1)
            {
                Console.WriteLine($"Ingrese el valor del nodo ({array1[0]}) izquierdo: ");
                array2[0] = int.Parse(Console.ReadLine());

                Console.WriteLine($"El nodo ({array2[0]}) contiene un nodo a la izquierda");
                Console.WriteLine("(1).- SI");
                Console.WriteLine("(2).- NO");
                respuesta = int.Parse(Console.ReadLine());
                if (respuesta == 1)
                {
                    Console.WriteLine($"Ingrese el valor del nodo ({array2[0]}) izquierdo: ");
                    array3[0] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"El nodo ({array2[0]}) contiene un nodo a la derecha:");
                Console.WriteLine("(1).- SI");
                Console.WriteLine("(2).- NO");
                respuesta = int.Parse(Console.ReadLine());
                if (respuesta == 1)
                {
                    Console.WriteLine($"Ingrese el valor del nodo ({array2[0]}) derecho: ");
                    array3[1] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"El nodo ({array3[0]}) contiene un nodo a la izquierda:");
                Console.WriteLine("(1).- SI");
                Console.WriteLine("(2).- NO");
                respuesta = int.Parse(Console.ReadLine());
                if (respuesta == 1)
                {
                    Console.WriteLine($"Ingrese el valor del nodo ({array3[0]}) izquierdo: ");
                    array4[0] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"El nodo ({array3[0]}) contiene un nodo a la derecha:");
                Console.WriteLine("(1).- SI");
                Console.WriteLine("(2).- NO");
                respuesta = int.Parse(Console.ReadLine());
                if (respuesta == 1)
                {
                    Console.WriteLine($"Ingrese el valor del nodo ({array3[0]}) derecho: ");
                    array4[1] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine($"El nodo ({array3[1]}) contiene un nodo a la izquierda:");
                Console.WriteLine("(1).- SI");
                Console.WriteLine("(2).- NO");
                respuesta = int.Parse(Console.ReadLine());
                if (respuesta == 1)
                {
                    Console.WriteLine($"Ingrese el valor del nodo ({array3[1]}) izquierdo: ");
                    array4[2] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"El nodo ({array3[1]}) contiene un nodo a la derecha:");
                Console.WriteLine("(1).- SI");
                Console.WriteLine("(2).- NO");
                respuesta = int.Parse(Console.ReadLine());
                if (respuesta == 1)
                {
                    Console.WriteLine($"Ingrese el valor del nodo ({array3[1]}) derecho: ");
                    array4[3] = int.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine($"El nodo ({array1[0]}) contiene un nodo a la derecha");
            Console.WriteLine("(1).- SI");
            Console.WriteLine("(2).- NO");
            respuesta = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ingrese el valor del nodo ({array1[0]}) izquierdo: ");
            array2[1] = int.Parse(Console.ReadLine());

            Console.WriteLine($"El nodo ({array2[1]}) contiene un nodo a la izquierda");
            Console.WriteLine("(1).- SI");
            Console.WriteLine("(2).- NO");
            respuesta = int.Parse(Console.ReadLine());
            if (respuesta == 1)
            {
                Console.WriteLine($"Ingrese el valor del nodo ({array2[1]}) izquierdo: ");
                array3[2] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"El nodo ({array2[1]}) contiene un nodo a la derecha:");
            Console.WriteLine("(1).- SI");
            Console.WriteLine("(2).- NO");
            respuesta = int.Parse(Console.ReadLine());
            if (respuesta == 1)
            {
                Console.WriteLine($"Ingrese el valor del nodo ({array2[1]}) derecho: ");
                array3[3] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"El nodo ({array3[2]}) contiene un nodo a la izquierda:");
            Console.WriteLine("(1).- SI");
            Console.WriteLine("(2).- NO");
            respuesta = int.Parse(Console.ReadLine());
            if (respuesta == 1)
            {
                Console.WriteLine($"Ingrese el valor del nodo ({array3[2]}) izquierdo: ");
                array4[4] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"El nodo ({array3[2]}) contiene un nodo a la derecha:");
            Console.WriteLine("(1).- SI");
            Console.WriteLine("(2).- NO");
            respuesta = int.Parse(Console.ReadLine());
            if (respuesta == 1)
            {
                Console.WriteLine($"Ingrese el valor del nodo ({array3[2]}) derecho: ");
                array4[5] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"El nodo ({array3[3]}) contiene un nodo a la izquierda:");
            Console.WriteLine("(1).- SI");
            Console.WriteLine("(2).- NO");
            respuesta = int.Parse(Console.ReadLine());
            if (respuesta == 1)
            {
                Console.WriteLine($"Ingrese el valor del nodo ({array3[3]}) izquierdo: ");
                array4[6] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"El nodo ({array3[3]}) contiene un nodo a la derecha:");
            Console.WriteLine("(1).- SI");
            Console.WriteLine("(2).- NO");
            respuesta = int.Parse(Console.ReadLine());
            if (respuesta == 1)
            {
                Console.WriteLine($"Ingrese el valor del nodo ({array3[3]}) derecho: ");
                array4[7] = int.Parse(Console.ReadLine());
            }
            imprimir();
            Console.ReadKey();

        }

        public static void imprimir()
        {
            string a2 = "";
            string a3 = "";
            string a4 = "";
            Console.Clear();
            foreach (int item in array1)
            {
                if (item == 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("                                        " + item);
                }
                
            }
            foreach (int item in array2)
            {
                if (item == 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    a2 = a2 + "                           " + item;
                }
                
            }
            Console.WriteLine("");
            Console.WriteLine($"{a2}");
            foreach (int item in array3)
            {
                if (item == 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    a3 = a3 + "             " + item;
                }
                
            }
            Console.WriteLine("");
            Console.WriteLine($"       {a3}");
            foreach (int item in array4)
            {
                if (item == 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    a4 = a4 + "      " + item;
                }

              
            }
            Console.WriteLine("");
            Console.WriteLine($"          {a4}");
        }

    }
}
