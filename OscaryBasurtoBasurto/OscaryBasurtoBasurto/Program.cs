using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OscaryBasurtoBasurto
{
    class Program 
    {
        public static List<OBB_ProductosFrescos> PF = new List<OBB_ProductosFrescos>();
        public static List<OBB_ProductosRefrigerados> PR = new List<OBB_ProductosRefrigerados>();
        public static List<OBB_ProductosCongelados> PC = new List<OBB_ProductosCongelados>();
        static void Main(string[] args)
        {
            OBB_ProductosFrescos pf = new OBB_ProductosFrescos();
            OBB_ProductosRefrigerados pr = new OBB_ProductosRefrigerados();
            OBB_ProductosCongelados pc = new OBB_ProductosCongelados();
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
                            Console.WriteLine("| (1).- Alta de producto                   |");
                            Console.WriteLine("| (2).- Imprimir productos                 |");
                            Console.WriteLine("| (3).- Eliminar productos                 |");
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Digita el numero de la opcion que deseas:");
                            Console.WriteLine();
                            op = int.Parse(Console.ReadLine());
                        } while (op < 1 || op > 3);
                        if (op == 1)
                        {
                            Console.Clear();
                            OBB_AltaProductosFrescos();
                            
                        }
                        else if (op == 2)
                        {
                            Console.Clear();
                            OBBImprimirProductosFrescos();
                        }
                        else if (op == 3)
                        {
                            Console.Clear();
                            OBB_BajaProductosFrescos();
                            Console.WriteLine();
                           
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
                            Console.WriteLine("| (1).- Alta de producto                   |");
                            Console.WriteLine("| (2).- Imprimir productos                 |");
                            Console.WriteLine("| (3).- Eliminar productos                 |");
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Digita el numero de la opcion que deseas:");
                            Console.WriteLine();
                            op = int.Parse(Console.ReadLine());
                        } while (op < 1 || op > 4);
                        if (op == 1)
                        {
                            Console.Clear();
                            OBB_AltaProductosRefrigerados();
                        }
                        else if (op == 2)
                        {
                            Console.Clear();
                            OBBImprimirProductosRefrigerados();
                        }
                        else if (op == 3)
                        {
                            Console.Clear();
                            OBB_BajaProductosRefrigerados();
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
                            Console.WriteLine("| (4).- Imprimir productos                 |");
                            Console.WriteLine("| (5).- eliminar un producto               |");
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Digita el numero de la opcion que deseas:");
                            Console.WriteLine();

                            op = int.Parse(Console.ReadLine());
                        } while (op < 1 || op > 5);
                        if (op == 1)
                        {
                            Console.Clear();
                            pc.CongeladosPorAire();
                        }
                        else if (op == 2)
                        {
                            Console.Clear();
                            pc.CongeladosPorAgua();
                        }
                        else if (op == 3)
                        {
                            Console.Clear();
                            pc.CongeladosPorNitrogeno();
                        }
                        else if (op == 4)
                        {
                            Console.Clear();
                            pc.OBBImprimirProductosCongelados();
                        }
                        else if (op == 5)
                        {
                            Console.Clear();
                            pc.OBB_BajaProductosCongelados();
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

        public static void OBB_AltaProductosFrescos()
        {
            Console.Clear();
            Console.WriteLine("                       ALTA");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Escriba el nombre del producto:");
            string nom = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Escriba La Fecha de cadusidad del producto");
            string fechadecadusidad = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Escriba el Numero de lote");
            int numerodelote = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Escriba la fecha de envasado: ");
            string fechadeenvasado = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Escriba El pais de origen: ");
            string paisdeorigen = Console.ReadLine();
            Console.WriteLine();
            PF.Add(new OBB_ProductosFrescos() { NombreDelProducto = nom, FechaDeCaducidad = fechadecadusidad, NumeroDeLote = numerodelote, FechaDeEnvasado = fechadeenvasado, PaisDeOrigen = paisdeorigen  });
        }
        public static void OBBImprimirProductosFrescos()
        {
            Console.Clear();
            Console.WriteLine("                               IMPRIMIR");
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (OBB_ProductosFrescos item in PF)
            {
                Console.WriteLine();

                Console.WriteLine($" Nombre del producto {item.NombreDelProducto} Fecha de Envasado: {item.FechaDeEnvasado}  Fecha de Caducidad: { item.FechaDeCaducidad}  Pais de origen: {item.PaisDeOrigen}  No. Lote: {item.NumeroDeLote}");
                Console.WriteLine("--------------------------------------------------------------------");
            }
        }
        public static void OBB_BajaProductosFrescos()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del producto a dar de baja");
            string nom = Console.ReadLine();
            int cont = 0;
            int indice = -1;
            foreach (OBB_ProductosFrescos item in PF)
            {
                if (item.NombreDelProducto == nom)
                {
                    indice = cont;
                }
                cont++;
            }
            if (indice > -1)
            {
                PF.RemoveAt(indice);
            }
            Console.WriteLine();
            Console.WriteLine(">>>>> El registro se removio correctamente <<<<<");
        }

        public static void OBB_AltaProductosRefrigerados()
        {
            Console.Clear();
            Console.WriteLine("                       ALTA");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Escriba el nombre del producto:");
            string nom = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Escriba La Fecha de cadusidad del producto");
            string fechadecadusidad = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Escriba el Numero de lote");
            int numerodelote = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Escriba la fecha de envasado: ");
            string fechadeenvasado = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Escriba El pais de origen: ");
            string paisdeorigen = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Escriba el Código del organizmo de supervición alimentaria: ");
            string codigo = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Escriba la Temperatura de mantenimiento recomendada: ");
            string temperatura = Console.ReadLine();
            Console.WriteLine();
            PR.Add(new OBB_ProductosRefrigerados() { NombreDelProducto = nom, FechaDeCaducidad = fechadecadusidad, NumeroDeLote = numerodelote, FechaDeEnvasado = fechadeenvasado, PaisDeOrigen = paisdeorigen, CodigodelOSA = codigo, TempDeManteReco = temperatura });
        }

        public static void OBBImprimirProductosRefrigerados()
        {
            Console.Clear();
            Console.WriteLine("                               IMPRIMIR");
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (OBB_ProductosRefrigerados item in PR)
            {
                Console.WriteLine();

                Console.WriteLine($" Nombre del producto {item.NombreDelProducto} Fecha de Envasado: {item.FechaDeEnvasado}  Fecha de Caducidad: { item.FechaDeCaducidad}  Pais de origen: {item.PaisDeOrigen}  No. Lote: {item.NumeroDeLote}  Código del organizmo de supervición alimentaria: {item.CodigodelOSA} Temperatura de mantenimiento recomendada: {item.TempDeManteReco}");
                Console.WriteLine("--------------------------------------------------------------------");
            }
        }

        public static void OBB_BajaProductosRefrigerados()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del producto a dar de baja");
            string nom = Console.ReadLine();
            int cont = 0;
            int indice = -1;
            foreach (OBB_ProductosRefrigerados item in PR)
            {
                if (item.NombreDelProducto == nom)
                {
                    indice = cont;
                }
                cont++;
            }
            if (indice > -1)
            {
                PR.RemoveAt(indice);
            }
            Console.WriteLine();
            Console.WriteLine(">>>>> El registro se removio correctamente <<<<<");
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
        public static Boolean Valida2(int opcion, int tamaño)
        {
            if (opcion < 1 || opcion > 1)
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
