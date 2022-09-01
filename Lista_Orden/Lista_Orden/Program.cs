using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Orden
{
    class Program
    {
        public static List<Datos> ltdatos = new List<Datos>();
        public static List<Datos> temporal = new List<Datos>();
        

        static void Main(string[] args)
        {
            int otra;
            do
            {
                Console.WriteLine("      BIENVENIDO AL SISTEMA DE ORDENAMIENTO");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("(1).- Alta");
                Console.WriteLine("(2).- Imprimir");
                Console.WriteLine("(3).- Ordenar");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("(SELECCIONE UNA OPCION");
                int opc = int.Parse(Console.ReadLine());
                if (opc == 1)
                {
                    alta();
                }
                else if (opc == 2)
                {
                    imprimir();
                }
                else if (opc == 3)
                {
                    ordenar();
                }
                else
                {
                    Console.WriteLine("(SELECCIONE UNA OPCION DENTRO DEL RANGO");
                }
                Console.WriteLine("DESEA REALIZAR OTRA OPERACIÓN");
                Console.WriteLine("(1).- SI");
                Console.WriteLine("(2).- NO");
                otra = int.Parse(Console.ReadLine());
            } while (otra == 1);
            Console.ReadKey();
           
        }
        public static void alta()
        {
            int listanum;
            Console.WriteLine("¿Cuantos elementos desea agreagar a la lista?");
            listanum  = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < listanum ; i++)
            {
                Console.Clear();
                Console.WriteLine("INGRESE id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("INGRESE agencia:");
                string agencia = Console.ReadLine();
                Console.WriteLine("INGRESE cantidad:");
                int cantidad = int.Parse(Console.ReadLine());
                ltdatos.Add(new Datos() { id = id, agencia = agencia, cantidad = cantidad });

            }
        }
        public static void imprimir()
        {
            Console.Clear();
            foreach (var item in temporal)
            {
                Console.WriteLine($"ID :{item.id}  Agencia: {item.agencia} Cantidad: {item.cantidad}");
            }
        }
        public static void ordenar()
        {
            int opc = submenu();
            int l = ltdatos.Count;
            int[] array = new int[l];
            int[] array2 = new int[l];
            int[] array3 = new int[l];
            int[] array4 = new int[l];
            int a = 0;
            
            if (opc ==1)
            {
                foreach (Datos item in ltdatos)
                {
                    array[a]  = item.id;

                    a++;
                }
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[i] < array[j])
                        {
                            int x = array[i];
                            array[i] = array[j];
                            array[j] = x;
                        }
                    }

                }
                for (int i = 0; i < array.Length; i++)
                {
                    foreach (Datos item in ltdatos)
                    {
                        if (array[i] == item.id)
                        {
                            temporal.Add(item);

                        }

                    }
                }
            }
            else if(opc == 2)
            {
                foreach (Datos item in ltdatos)
                {
                    array2[a] = item.id;

                    a++;
                }
                for (int i = 0; i < array2.Length; i++)
                {
                    for (int j = 0; j < array2.Length; j++)
                    {
                        if (array2[i] > array2[j])
                        {
                            int x = array2[i];
                            array2[i] = array2[j];
                            array2[j] = x;
                        }
                    }

                }
                for (int i = 0; i < array2.Length; i++)
                {
                    foreach (Datos item in ltdatos)
                    {
                        if (array2[i] == item.id)
                        {
                            temporal.Add(item);

                        }

                    }
                }

            }
            else if (opc == 3)
            {
                foreach (Datos item in ltdatos)
                {
                    array3[a] = item.cantidad;

                    a++;
                }
                for (int i = 0; i < array3.Length; i++)
                {
                    for (int j = 0; j < array3.Length; j++)
                    {
                        if (array3[i] < array3[j])
                        {
                            int x = array3[i];
                            array3[i] = array3[j];
                            array3[j] = x;
                        }
                    }

                }
                for (int i = 0; i < array3.Length; i++)
                {
                    foreach (Datos item in ltdatos)
                    {
                        if (array3[i] == item.cantidad)
                        {
                            temporal.Add(item);

                        }

                    }
                }
            }
            else if (opc == 4)
            {
                foreach (Datos item in ltdatos)
                {
                    array4[a] = item.cantidad;

                    a++;
                }
                for (int i = 0; i < array4.Length; i++)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array4[i] > array4[j])
                        {
                            int x = array4[i];
                            array4[i] = array4[j];
                            array4[j] = x;
                        }
                    }

                }
                for (int i = 0; i < array4.Length; i++)
                {
                    foreach (Datos item in ltdatos)
                    {
                        if (array4[i] == item.cantidad)
                        {
                            temporal.Add(item);

                        }

                    }
                }
            }
        }
        public static int submenu()
        {
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("             SUB_MENU DE ORDENAMIENTO");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("(1).-Id Ascendente");
                Console.WriteLine("(2).-Id Descendente");
                Console.WriteLine("(3).-Cantidad Ascendente");
                Console.WriteLine("(4).-Cantidad Descendente");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("SELECCIONE UNA OPCIÓN A ORDENAR");
                opc = int.Parse(Console.ReadLine());
            } while (opc > 4 || opc < 1);
            return opc;
        }
    }
}
