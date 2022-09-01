using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OscaryBasurtoBasurto
{
    class OBB_ProductosCongelados : OBB_Herencia
    {
        public static List<OBB_ProductosCongelados> PC = new List<OBB_ProductosCongelados>();
        public string CongelacionPor;
        public string ComposocionDelAire;
        public string TiempodeExposicionNitrogeno;
        public string Salinidad;
        public string DatoAdicional;
        public void CongeladosPorAire()
        {

            int op;
            do
            {

                Console.Clear();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("|       PRODUCTOS CONGELADOS POR AIRE      |");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("| (1).- Alta                               |");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Digita el numero de la opcion que deseas:");
                Console.WriteLine();
                op = int.Parse(Console.ReadLine());
            } while (op < 1 || op > 1);
            if (op == 1)
            {
                Console.Clear();
                OBB_AltaProductosCongelados_PorAire();
            }

        }
        public static void OBB_AltaProductosCongelados_PorAire()
        {
            Console.Clear();
            Console.WriteLine("                       ALTA");
            Console.WriteLine("------------------------------------------------");
            string congelacionpor = "PRODUCTO CONGELADO CONHGELADO POR AIRE --> "; 
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
            string dato = "Composición del aire con que fue congelado: ";
            Console.WriteLine("Escriba la Composición del aire con que fue congelado: ");
            string composicion = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Escriba la Temperatura de mantenimiento recomendada: ");
            string temperatura = Console.ReadLine();
            Console.WriteLine();;
            PC.Add(new OBB_ProductosCongelados() { CongelacionPor = congelacionpor, NombreDelProducto = nom, FechaDeCaducidad = fechadecadusidad, NumeroDeLote = numerodelote, FechaDeEnvasado = fechadeenvasado, PaisDeOrigen = paisdeorigen, ComposocionDelAire = composicion, TempDeManteReco = temperatura, DatoAdicional = dato });
        }
       
        public void CongeladosPorAgua()
        {

            int op;
            do
            {

                Console.Clear();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("|       PRODUCTOS CONGELADOS POR AGUA      |");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("| (1).- Alta                               |");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Digita el numero de la opcion que deseas:");
                Console.WriteLine();
                op = int.Parse(Console.ReadLine());
            } while (op < 1 || op > 1);
            if (op == 1)
            {
                Console.Clear();
                OBB_AltaProductosCongelados_PorAgua();
            }

        }
        public static void OBB_AltaProductosCongelados_PorAgua()
        {
            Console.Clear();
            Console.WriteLine("                       ALTA");
            Console.WriteLine("------------------------------------------------");
            string congelacionpor = "PRODUCTO CONGELADO CONHGELADO POR AGUA --> ";
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
            string dato = "Salinidad del agua con que se realizó la congelación: ";
            Console.WriteLine("Escriba la Salinidad del agua con que se realizó la congelación: ");
            string sal = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Escriba la Temperatura de mantenimiento recomendada: ");
            string temperatura = Console.ReadLine();
            Console.WriteLine(); ;
            PC.Add(new OBB_ProductosCongelados() { CongelacionPor = congelacionpor, NombreDelProducto = nom, FechaDeCaducidad = fechadecadusidad, NumeroDeLote = numerodelote, FechaDeEnvasado = fechadeenvasado, PaisDeOrigen = paisdeorigen, Salinidad = sal, TempDeManteReco = temperatura, DatoAdicional = dato });
        }


        public void CongeladosPorNitrogeno()
        {

            int op;
            do
            {

                Console.Clear();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("|    PRODUCTOS CONGELADOS POR NITROGENO    |");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("| (1).- Alta                               |");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Digita el numero de la opcion que deseas:");
                Console.WriteLine();
                op = int.Parse(Console.ReadLine());
            } while (op < 1 || op > 1);
            if (op == 1)
            {
                Console.Clear();
                OBB_AltaProductosCongelados_PorNitrogeno();
            }

        }
        public static void OBB_AltaProductosCongelados_PorNitrogeno ()
        {
            Console.Clear();
            Console.WriteLine("                       ALTA");
            Console.WriteLine("------------------------------------------------");
            string congelacionpor = "PRODUCTO CONGELADO CONHGELADO POR NITROGENO --> ";
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
            Console.WriteLine("Escriba la Temperatura de mantenimiento recomendada: ");
            string temperatura = Console.ReadLine();
            Console.WriteLine();
            string dato = "Tiempo de exposición al nitrógeno: ";
            Console.WriteLine("Escriba el Tiempo de exposición al nitrógeno: ");
            string tiempodeexposicion = Console.ReadLine();
            Console.WriteLine(); ;
            PC.Add(new OBB_ProductosCongelados() { CongelacionPor = congelacionpor, NombreDelProducto = nom, FechaDeCaducidad = fechadecadusidad, NumeroDeLote = numerodelote, FechaDeEnvasado = fechadeenvasado, PaisDeOrigen = paisdeorigen, TempDeManteReco = temperatura, TiempodeExposicionNitrogeno = tiempodeexposicion, DatoAdicional = dato});
        }
        public void OBBImprimirProductosCongelados()
        {
            Console.Clear();
            Console.WriteLine("                               IMPRIMIR");
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (OBB_ProductosCongelados item in PC)
            {
                Console.WriteLine();

                Console.WriteLine($"{item.CongelacionPor} Nombre del producto {item.NombreDelProducto} Fecha de Envasado: {item.FechaDeEnvasado}  Fecha de Caducidad: { item.FechaDeCaducidad}  Pais de origen: {item.PaisDeOrigen}  No. Lote: {item.NumeroDeLote}  Código del organizmo de supervición alimentaria: {item.CodigodelOSA} Temperatura de mantenimiento recomendada: {item.TempDeManteReco} {item.DatoAdicional}  {item. Salinidad }{item.ComposocionDelAire}{ item.TiempodeExposicionNitrogeno }");
                Console.WriteLine("--------------------------------------------------------------------");
            }
        }
        public  void OBB_BajaProductosCongelados()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del producto a dar de baja");
            string nom = Console.ReadLine();
            int cont = 0;
            int indice = -1;
            foreach (OBB_ProductosCongelados item in PC)
            {
                if (item.NombreDelProducto == nom)
                {
                    indice = cont;
                }
                cont++;
            }
            if (indice > -1)
            {
                PC.RemoveAt(indice);
            }
            Console.WriteLine();
            Console.WriteLine(">>>>> El registro se removio correctamente <<<<<");
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
