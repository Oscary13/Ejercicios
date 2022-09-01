using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_agroalimentaria
{
    class Program
    {

        static void Main(string[] args)
        {
            ProductosFrescos Productofresco = new ProductosFrescos();
            ProductosRefrigerados Productorefrigerado = new ProductosRefrigerados();
            ProductosCongelados Productoscongelados = new ProductosCongelados();
            int opc = menu();
            switch (opc)
            {
                case 1:
                    int otra;
                    do
                    {
                        int op;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("|              PRODUCTOS FRESCOS           |");
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("| (1).- Pescados frescos                   |");
                            Console.WriteLine("| (2).- Kilo de Huevo                      |");
                            Console.WriteLine("| (3).- Informacion de todos los productos |");
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Digita el numero de la opcion que deseas:");
                            Console.WriteLine();
                            op = int.Parse(Console.ReadLine());
                        } while (op < 1 || op > 3);
                        if (op == 1)
                        {
                            Console.Clear();
                            Productofresco.pescadosfrescos();
                        }
                        else if (op == 2)
                        {
                            Console.Clear();
                            Productofresco.KiloDeHuevo();
                        }
                        else if (op == 3)
                        {
                            Console.Clear();
                            Productofresco.pescadosfrescos();
                            Console.WriteLine();
                            Productofresco.KiloDeHuevo();
                        }
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("  Deseas volver al menu de Productos frescos:");
                        Console.ResetColor();
                        Console.WriteLine("-----------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("  (1).- SI");
                        Console.WriteLine("  (2).- NO");
                        Console.ResetColor();
                        Console.WriteLine();
                        otra = int.Parse(Console.ReadLine());
                    } while (otra == 1);

                    break;

                case 2:
                    int otra2;
                    do
                    {
                        int op;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("|           PRODUCTOS REFRIGERADOS          |");
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("| (1).- Carne de Ave refrigerada           |");
                            Console.WriteLine("| (2).- Alimentos procesados refrigerados  |");
                            Console.WriteLine("| (3).- Huevos en cáscara refrigerados     |");
                            Console.WriteLine("| (4).- Información de todos los productos |");
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Digita el numero de la opcion que deseas:");
                            Console.WriteLine();
                            op = int.Parse(Console.ReadLine());
                        } while (op < 1 || op > 4);
                        if (op == 1)
                        {
                            Console.Clear();
                            Productorefrigerado.CarneDeAveRefrigerada();
                        }
                        else if (op == 2)
                        {
                            Console.Clear();
                            Productorefrigerado.Alimentosprocesadosrefrigerados();
                        }
                        else if (op == 3)
                        {
                            Console.Clear();
                            Productorefrigerado.Huevosencáscararefrigerados();
                        }
                        else if (op == 4)
                        {
                            Console.Clear();
                            Productorefrigerado.CarneDeAveRefrigerada();
                            Console.WriteLine();
                            Productorefrigerado.Alimentosprocesadosrefrigerados();
                            Console.WriteLine();
                            Productorefrigerado.Huevosencáscararefrigerados();
                            
                        }
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("  Deseas volver al menu de Productos refrigerados:");
                        Console.ResetColor();
                        Console.WriteLine("--------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("  (1).- SI");
                        Console.WriteLine("  (2).- NO");
                        Console.ResetColor();
                        Console.WriteLine();
                        otra2 = int.Parse(Console.ReadLine());
                    } while (otra2 == 1);
                    break;

                case 3:
                    int otra3;
                    do
                    {
                        int op;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("|           PRODUCTOS CONGELADOS           |");
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("| (1).- Congelados por aire                |");
                            Console.WriteLine("| (2).- Congelados por agua                |");
                            Console.WriteLine("| (3).- Congelados por nitrogeno           |");
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Digita el numero de la opcion que deseas:");
                            Console.WriteLine();
                            
                            op = int.Parse(Console.ReadLine());
                        } while (op < 1 || op > 3);
                        if (op == 1)
                        {
                            Console.Clear();
                            Productoscongelados.CongeladosPorAire();
                        }
                        else if (op == 2)
                        {
                            Console.Clear();
                            Productoscongelados.CongeladosPorAgua();
                        }
                        else if (op == 3)
                        {
                            Productoscongelados.CongeladosPorNitrogeno();
                        }
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("  Deseas volver al menu de Productos Congelados:");
                        Console.ResetColor();
                        Console.WriteLine("-----------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("  (1).- SI");
                        Console.WriteLine("  (2).- NO");
                        Console.ResetColor();
                        Console.WriteLine();
                        otra3 = int.Parse(Console.ReadLine());
                    } while (otra3 == 1);
                    break;

            }
        }
        public static int menu()
        {
            int opc;
            Boolean valida;
            do
            {

                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("|         EMPRESA AGROALIMENTARIA       |");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("| (1).- Productos Frescos               |");
                Console.WriteLine("| (2).- Productos Refrigerados          |");
                Console.WriteLine("| (3).- Productos Congelados            |");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Digita el numero de la opcion que deseas:");
                Console.WriteLine();
                opc = int.Parse(Console.ReadLine());
                valida = Valida(opc, 3);
            } while (valida);
            return opc;
            
        }
        public static Boolean Valida(int opcion, int tamaño)
        {
            if (opcion < 1 || opcion > tamaño)
            {
                Console.Clear();
                Console.WriteLine("La opcion seleccionada es invalida..... <<Enter para continuar>>  ");
                Console.ReadKey();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
