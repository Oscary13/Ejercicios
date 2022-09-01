using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2do_programa_3er_cuatri
{
    class Program
    {
        public static int[] array1 = new int[10];
        public static int[] array2 = new int[10];
        public static int[] array3 = new int[10];
        public static int[] array4 = new int[10];
        static void Main(string[] args)
        {
            int otra = 0;
            do
            {
                Console.Clear();
                int opcion = menu1();
                int OpcionDos = menu2(opcion);
                opciones(opcion, OpcionDos);
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("        Desea realizar otra operacion?");
                Console.WriteLine("                 (1) .- SI");
                Console.WriteLine("                 (2) .- NO");
                Console.WriteLine("---------------------------------------------");
                otra = int.Parse(Console.ReadLine());
            } while (otra == 1);
            Console.Clear();
            Console.WriteLine("GRASIAS POR UTLILIZAR EL SISTEAMA -OBB-");
            Console.ReadKey();

        }
        public static int menu1()
        {
            int opcion;
            bool val;
            do
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("                   MENU");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("               (1) Alta");
                Console.WriteLine("               (2) Baja");
                Console.WriteLine("               (3) Edición");
                Console.WriteLine("               (4) Imprimir");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Digite el numero de la opción");
                opcion = int.Parse(Console.ReadLine());
                val = valida(opcion, 4);

            } while (val == false);
            return opcion;
        }
        public static int menu2(int opcionUno)
        {
            
            int opcion;
            bool val;
            int tamano = 4;
            do
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("            SELECCIONAR ARREGLO");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("             (1) Arreglo 1");
                Console.WriteLine("             (2) Arreglo 2");
                Console.WriteLine("             (3) Arreglo 3");
                Console.WriteLine("             (4) Arreglo 4");
                Console.WriteLine("--------------------------------------");
                if (opcionUno  == 4)
                {
                    Console.WriteLine("           (5) Todos los Arreglos");
                    tamano = 5;
                }
                Console.WriteLine();
                Console.WriteLine("Digite el numero de la opción");
                opcion = int.Parse(Console.ReadLine());
                val = valida(opcion, tamano);

            } while (val == false);
            return opcion;
        }
        public static void alta(int opcionDos)
        {
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese el nuevo numero");
                if (opcionDos == 1)
                {
                    array1[i] = int.Parse(Console.ReadLine());

                }
                else if (opcionDos == 2)
                {
                    array2[i] = int.Parse(Console.ReadLine());

                }
                else if (opcionDos == 3)
                {
                    array3[i] = int.Parse(Console.ReadLine());

                }
                else if (opcionDos == 4)
                {
                    array4[i] = int.Parse(Console.ReadLine());

                }
            }

        }
        public static void eliminar(int opcionDos)
        {
            Console.WriteLine("Ingrese el nuemro a eliminar");
            int NumeroEliminar = int.Parse(Console.ReadLine());
            if (opcionDos == 1)
            {
                bool existe = array1.Contains(NumeroEliminar);
                if (existe)
                {
                    for (int i = 0; i < array1.Length; i++)
                    {
                        if (NumeroEliminar == array1[i])
                        {
                            array1[i] = 0;
                        }
                        
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" El Numero no existe en el arreglo :( ......  ");
                }

            }
            else if (opcionDos == 2)
            {
                bool existe = array2.Contains(NumeroEliminar);
                if (existe)
                {
                    for (int i = 0; i < array2.Length; i++)
                    {
                        if (NumeroEliminar == array2[i])
                        {
                            array2[i] = 0;
                        }
                        
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" El Numero no existe en el arreglo :( ......  ");
                }
            }
            else if (opcionDos == 3)
            {
                bool existe = array3.Contains(NumeroEliminar);
                if (existe)
                {
                    for (int i = 0; i < array3.Length; i++)
                    {
                        if (NumeroEliminar == array3[i])
                        {
                            array3[i] = 0;
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" El Numero no existe en el arreglo :( ......  ");
                }

            }
            else if (opcionDos == 4)
            {
                bool existe = array4.Contains(NumeroEliminar);
                if (existe)
                {
                    for (int i = 0; i < array4.Length; i++)
                    {
                        if (NumeroEliminar == array4[i])
                        {
                            array4[i] = 0;
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" El Numero no existe en el arreglo :( ......  ");
                }
            }
            
        }
        public static void edicion(int opcionDos)
        {
            Console.WriteLine("Ingrese el nuemro a editar");
            int NumeroEliminar = int.Parse(Console.ReadLine());
            if (opcionDos == 1)
            {
                bool existe = array1.Contains(NumeroEliminar);
                if (existe)
                {
                    Console.WriteLine("Ingrese el numero nuevo");
                    int NuevoNumero = int.Parse(Console.ReadLine());

                    for (int i = 0; i < array1.Length; i++)
                    {
                        if (NumeroEliminar == array1[i])
                        {
                            array1[i] = 0;
                            array1[i] = NuevoNumero;
                        }

                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" El Numero no existe en el arreglo :( ......  ");
                }

            }
            else if (opcionDos ==2)
            {
                bool existe = array2.Contains(NumeroEliminar);
                if (existe)
                {
                    Console.WriteLine("Ingrese el numero nuevo");
                    int NuevoNumero = int.Parse(Console.ReadLine());

                    for (int i = 0; i < array2.Length; i++)
                    {
                        if (NumeroEliminar == array2[i])
                        {
                            array2[i] = 0;
                            array2[i] = NuevoNumero;
                        }

                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" El Numero no existe en el arreglo :( ......  ");
                }
            }
            else if (opcionDos == 3)
            {
                bool existe = array3.Contains(NumeroEliminar);
                if (existe)
                {
                    Console.WriteLine("Ingrese el numero nuevo");
                    int NuevoNumero = int.Parse(Console.ReadLine());

                    for (int i = 0; i < array3.Length; i++)
                    {
                        if (NumeroEliminar == array3[i])
                        {
                            array3[i] = 0;
                            array3[i] = NuevoNumero;
                        }

                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" El Numero no existe en el arreglo :( ......  ");
                }
            }
            else if (opcionDos == 4)
            {
                bool existe = array4.Contains(NumeroEliminar);
                if (existe)
                {
                    Console.WriteLine("Ingrese el numero nuevo");
                    int NuevoNumero = int.Parse(Console.ReadLine());

                    for (int i = 0; i < array4.Length; i++)
                    {
                        if (NumeroEliminar == array4[i])
                        {
                            array4[i] = 0;
                            array4[i] = NuevoNumero;
                        }

                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" El Numero no existe en el arreglo :( ......  ");
                }
            }
            

        }
        public static void imprimir(int opcionDos)
        {
            Console.Clear();
            if (opcionDos == 1)
            {
                foreach (int item in array1)
                {
                    Console.WriteLine(item);
                }

            }
            else if (opcionDos == 2)
            {
                foreach (int item in array2)
                {
                    Console.WriteLine(item);
                }

            }
            else if (opcionDos == 3)
            {
                foreach (int item in array3)
                {
                    Console.WriteLine(item);
                }

            }
            else if (opcionDos == 4)
            {
                foreach (int item in array4)
                {
                    Console.WriteLine(item);
                }

            }
            else if (opcionDos == 5)
            {
                Console.WriteLine("------------------------------------");
                foreach (int item in array1)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("------------------------------------");
                foreach (int item in array2)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("------------------------------------");
                foreach (int item in array3)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("------------------------------------");
                foreach (int item in array4)
                {
                    Console.WriteLine(item);
                }


            }

        }
        public static bool valida(int opcion, int tamaño)
        {
            if (opcion > 0 && opcion <= tamaño)
            {
                return true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("La opccion seleccionada es invalida........");
                Console.ReadKey();
                return false;
            }
        }
        public static void opciones(int opcion, int opcionDos)
        {
            if (opcion == 1)
            {
                alta(opcionDos);
            }
            else if (opcion == 2)
            {
                eliminar(opcionDos);
            }
            else if (opcion == 3)
            {
                edicion(opcionDos);
            }
            else if (opcion == 4)
            {
                imprimir(opcionDos);
            }
        }
    }
}
