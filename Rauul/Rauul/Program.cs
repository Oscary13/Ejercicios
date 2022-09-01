using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENU_ARRAY
{
    class Program
    {

        public static int[] arrayUno = new int[10];
        public static int[] arrayDos = new int[10];
        public static int[] arrayTres = new int[10];
        public static int[] arrayCuatro = new int[10];
        static void Main(string[] args)
        {
            int otra = 0;
            do
            {
                Console.Clear();
                int opcion = menuUno();
                int opcionDos = menuDos(opcion);
                opciones(opcion, opcionDos);


                Console.WriteLine("DESEA REALIZAR OTRA OPERAION: 1 = SI / 2 = NO");
                otra = int.Parse(Console.ReadLine());
            } while (otra == 1);

            Console.WriteLine("GRACIAS POR UTILIZAR EL SISTEMA......");
            Console.ReadKey();
        }
        public static Boolean valida(int opcion, int tamaño)
        {
            if (opcion < 1 || opcion > tamaño)
            {
                Console.WriteLine("LA OPCION SELECCIONADA ES INVALIDA......INTETALO DE NUEVO.ENTER PARA CONTINUAR");
                Console.ReadKey();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int menuUno()
        {
            Boolean val;
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("  MENU  ");
                Console.WriteLine("========================================");
                Console.WriteLine("               1.-Alta ");
                Console.WriteLine("               2.-Baja ");
                Console.WriteLine("               3.-Imprimir");
                Console.WriteLine("               4.-Editar");
                Console.WriteLine("======================================");
                Console.WriteLine("Seleccione una opcion");
                opc = int.Parse(Console.ReadLine());
                val = valida(opc, 4);
            } while (val);
            return opc;
        }
        public static int menuDos(int opcionUno)
        {
            Boolean val;
            int opc;
            int tamaño = 4;
            do
            {
                Console.Clear();
                Console.WriteLine("****************************************");
                Console.WriteLine("                ARREGLOS ");
                Console.WriteLine("****************************************");
                Console.WriteLine("             (1) Arreglo 1 ");
                Console.WriteLine("             (2) Arreglo 2 ");
                Console.WriteLine("             (3) Arreglo 3");
                Console.WriteLine("             (4) Arreglo 4");
                if (opcionUno == 4)
                {
                    Console.WriteLine("5.- todos los arreglos:");
                    tamaño = 5;
                }
                Console.WriteLine("****************************************");
                Console.WriteLine("Seleccione una opcion");
                opc = int.Parse(Console.ReadLine());
                val = valida(opc, tamaño);
            } while (val);
            return opc;
        }
        public static void alta(int opcionDos)
        {
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese el numero ");
                if (opcionDos == 1)
                {
                    arrayUno[i] = int.Parse(Console.ReadLine());
                }
                else if (opcionDos == 2)
                {
                    arrayDos[i] = int.Parse(Console.ReadLine());
                }
                else if (opcionDos == 3)
                {
                    arrayTres[i] = int.Parse(Console.ReadLine());
                }
                else if (opcionDos == 4)
                {
                    arrayCuatro[i] = int.Parse(Console.ReadLine());
                }
            }
        }
        public static void baja(int opcionDos)
        {
            Console.WriteLine("¿Cual sera el valor a eliminar? ");
            int numEliminar = int.Parse(Console.ReadLine());

            if (opcionDos == 1)
            {
                bool existe = arrayUno.Contains(numEliminar);
                if (existe)
                {
                    for (int i = 0; i < arrayUno.Length; i++)
                    {
                        if (numEliminar == arrayUno[i])
                        {
                            arrayUno[i] = 0;
                        }

                    }
                }
            }
            else if (opcionDos == 2)
            {
                bool existe = arrayDos.Contains(numEliminar);
                if (existe)
                {
                    for (int i = 0; i < arrayDos.Length; i++)
                    {
                        if (numEliminar == arrayDos[i])
                        {
                            arrayDos[i] = 0;
                        }

                    }
                }
            }
            else if (opcionDos == 3)
            {
                bool existe = arrayTres.Contains(numEliminar);
                if (existe)
                {
                    for (int i = 0; i < arrayTres.Length; i++)
                    {
                        if (numEliminar == arrayTres[i])
                        {
                            arrayTres[i] = 0;
                        }


                    }
                }
            }
            else if (opcionDos == 4)
            {
                bool existe = arrayCuatro.Contains(numEliminar);
                if (existe)
                {
                    for (int i = 0; i < arrayCuatro.Length; i++)
                    {
                        if (numEliminar == arrayCuatro[i])
                        {
                            arrayCuatro[i] = 0;
                        }

                    }
                }
            }
        }
        public static void imprimir(int opcionDos)
        {
            Console.Clear();
            if (opcionDos == 1)
            {
                foreach (int item in arrayUno)
                {
                    Console.WriteLine(item);
                }
            }
            else if (opcionDos == 2)
            {
                foreach (int item in arrayDos)
                {
                    Console.WriteLine(item);
                }
            }
            else if (opcionDos == 3)
            {
                foreach (int item in arrayTres)
                {
                    Console.WriteLine(item);
                }
            }
            else if (opcionDos == 4)
            {
                foreach (int item in arrayCuatro)
                {
                    Console.WriteLine(item);
                }
            }
            else if (opcionDos == 5)
            {
                foreach (int item in arrayUno)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("****************************************");
                foreach (int item in arrayDos)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("****************************************");
                foreach (int item in arrayTres)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("****************************************");
                foreach (int item in arrayCuatro)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("****************************************");
            }

        }
        public static void edicion(int opcionDos)
        {
            bool existe = false;
            Console.WriteLine("¿Cual numero editara? ");
            int numeditar = int.Parse(Console.ReadLine());

            if (opcionDos == 1)
            {
                existe = arrayUno.Contains(numeditar);
            }
            else if (opcionDos == 2)
            {
                existe = arrayDos.Contains(numeditar);
            }
            else if (opcionDos == 3)
            {
                existe = arrayTres.Contains(numeditar);
            }
            else if (opcionDos == 4)
            {
                existe = arrayCuatro.Contains(numeditar);
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
                baja(opcionDos);
            }
            else if (opcion == 3)
            {
                imprimir(opcionDos);
            }
            else if (opcion == 4)
            {
                edicion(opcionDos);
            }
        }
    }
}
