using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_agroalimentaria
{
    class ProductosCongelados : Herencia
    {

        public string ComposocionDelAire;
        public string TiempodeExposicionNitrogeno;
        public string Salinidad;
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
                Console.WriteLine("| (1).- Frutas                             |");
                Console.WriteLine("| (2).- Refrescos                          |");
                Console.WriteLine("| (3).- Información de todos los productos |");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Digita el numero de la opcion que deseas:");
                Console.WriteLine();
                op = int.Parse(Console.ReadLine());
            } while (op < 1 || op > 3);
            if (op == 1)
            {
                Console.Clear();
                CAFrutas();
            }
            else if (op == 2)
            {
                Console.Clear();
                CARefrescos();
            }
            else if (op == 3)
            {
                Console.Clear();
                CAFrutas();
                Console.WriteLine();
                CARefrescos();
            }

        }
        public void CAFrutas()
        {
            ProductosCongelados Frutas = new ProductosCongelados();
            Frutas.FechaDeCaducidad = "26/ Agosto/ 2021";
            Frutas.NumeroDeLote = 01012340;
            Frutas.FechaDeEnvasado = "13/ Marzo/ 2021";
            Frutas.PaisDeOrigen = "México";
            Frutas.TempDeManteReco = "De entre 10°C y 30°C";
            Frutas.ComposocionDelAire = "Oxigeno";
            Console.WriteLine($"------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"                                  <<FRUTAS>>");
            Console.ResetColor();
            Console.WriteLine($" Fecha de Envasado: {Frutas.FechaDeEnvasado}");
            Console.WriteLine($" Fecha de Caducidad: {Frutas.FechaDeCaducidad} ");
            Console.WriteLine($" Pais de origen: {Frutas.PaisDeOrigen}");
            Console.WriteLine($" No. Lote: {Frutas.NumeroDeLote}");
            Console.WriteLine($" Temperatura de mantenimiento recomendada: {Frutas.TempDeManteReco}");
            Console.WriteLine($" Composición del aire con que fue congelado: {Frutas.ComposocionDelAire}");
            Console.WriteLine($"------------------------------------------------------------------------");
        }
        public void CARefrescos()
        {
            ProductosCongelados Refrescos = new ProductosCongelados();
            Refrescos.FechaDeCaducidad = "26/ Agosto/ 2021";
            Refrescos.NumeroDeLote = 01012340;
            Refrescos.FechaDeEnvasado = "13/ Marzo/ 2021";
            Refrescos.PaisDeOrigen = "México";
            Refrescos.TempDeManteReco = "De entre los 4°C y 8°C";
            Refrescos.ComposocionDelAire = "Dióxido de carbono";
            Console.WriteLine($"------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"                                <<REFRESCOS>>");
            Console.ResetColor();
            Console.WriteLine($" Fecha de Envasado: {Refrescos.FechaDeEnvasado}");
            Console.WriteLine($" Fecha de Caducidad: {Refrescos.FechaDeCaducidad} ");
            Console.WriteLine($" Pais de origen: {Refrescos.PaisDeOrigen}");
            Console.WriteLine($" No. Lote: {Refrescos.NumeroDeLote}");
            Console.WriteLine($" Temperatura de mantenimiento recomendada: {Refrescos.TempDeManteReco}");
            Console.WriteLine($" Composición del aire con que fue congelado: {Refrescos.ComposocionDelAire}");
            Console.WriteLine($"------------------------------------------------------------------------");
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
                Console.WriteLine("| (1).- Pescado Congelado                  |");
                Console.WriteLine("| (2).- Camarones Congelados               |");
                Console.WriteLine("| (3).- Información de todos los productos |");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Digita el numero de la opcion que deseas:");
                Console.WriteLine();
                op = int.Parse(Console.ReadLine());
            } while (op < 1 || op > 3);
            if (op == 1)
            {
                Console.Clear();
                PescadoCongelado();
            }
            else if (op == 2)
            {
                Console.Clear();
                CamaronesCongelados();
            }
            else if (op == 3)
            {
                Console.Clear();
                PescadoCongelado();
                Console.WriteLine();
                CamaronesCongelados();
            }

        }
        public void PescadoCongelado()
        {
            ProductosCongelados PescadoC = new ProductosCongelados();
            PescadoC.FechaDeCaducidad = "30/ Julio/ 2021";
            PescadoC.NumeroDeLote = 01012340;
            PescadoC.FechaDeEnvasado = "03/ Marzo/ 2021";
            PescadoC.PaisDeOrigen = "Veracruz";
            PescadoC.TempDeManteReco = "De 32 a 41 °F (0 a 5 °C)";
            PescadoC.Salinidad = "0,05 gramos por cada litro de agua";
            Console.WriteLine($"------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"                         <<PESCADO CONGELADO>>");
            Console.ResetColor();
            Console.WriteLine($" Fecha de Envasado: {PescadoC.FechaDeEnvasado}");
            Console.WriteLine($" Fecha de Caducidad: {PescadoC.FechaDeCaducidad} ");
            Console.WriteLine($" Pais de origen: {PescadoC.PaisDeOrigen}");
            Console.WriteLine($" No. Lote: {PescadoC.NumeroDeLote}");
            Console.WriteLine($" Temperatura de mantenimiento recomendada: {PescadoC.TempDeManteReco}");
            Console.WriteLine($" Salinidad del agua con que se realizó la congelación: {PescadoC.Salinidad}");
            Console.WriteLine($"------------------------------------------------------------------------");
        }
        public void CamaronesCongelados()
        {
            ProductosCongelados CamaronesC = new ProductosCongelados();
            CamaronesC.FechaDeCaducidad = "25/ Mayo/ 2021";
            CamaronesC.NumeroDeLote = 01012340;
            CamaronesC.FechaDeEnvasado = "01/ Marzo/ 2021";
            CamaronesC.PaisDeOrigen = "Veracruz";
            CamaronesC.TempDeManteReco = "De 32 a 41 °F (0 a 5 °C)";
            CamaronesC.Salinidad = "0.8 gramos por cada litro de agua";
            Console.WriteLine($"------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"                            <<CAMARONES CONGELADO>>");
            Console.ResetColor();
            Console.WriteLine($" Fecha de Envasado: {CamaronesC.FechaDeEnvasado}");
            Console.WriteLine($" Fecha de Caducidad: {CamaronesC.FechaDeCaducidad} ");
            Console.WriteLine($" Pais de origen: {CamaronesC.PaisDeOrigen}");
            Console.WriteLine($" No. Lote: {CamaronesC.NumeroDeLote}");
            Console.WriteLine($" Temperatura de mantenimiento recomendada: {CamaronesC.TempDeManteReco}");
            Console.WriteLine($" Salinidad del agua con que se realizó la congelación: {CamaronesC.Salinidad}");
            Console.WriteLine($"------------------------------------------------------------------------");
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
                Console.WriteLine("| (1).- Carnes congeladas por Nitrogeno    |");
                Console.WriteLine("| (2).- Información de todos los productos |");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Digita el numero de la opcion que deseas:");
                Console.WriteLine();
                op = int.Parse(Console.ReadLine());
            } while (op < 1 || op > 3);
            if (op == 1)
            {
                Console.Clear();
                CarneCongeladaConNitrogeno();
            }
            else if (op == 2)
            {
                Console.Clear();
                CarneCongeladaConNitrogeno();
            }

        }
        public void CarneCongeladaConNitrogeno()
        {
            ProductosCongelados CarnesN = new ProductosCongelados();
            CarnesN.FechaDeCaducidad = "05/ Julio/ 2021";
            CarnesN.NumeroDeLote = 01012340;
            CarnesN.FechaDeEnvasado = "02/ Marzo/ 2021";
            CarnesN.PaisDeOrigen = "Honduras";
            CarnesN.TempDeManteReco = "De 30 a 40 °F (0 a 5 °C)";
            CarnesN.ComposocionDelAire = "Nitrogeno";
            CarnesN.TiempodeExposicionNitrogeno = "10 segundos entre cada toma de pajuela";
            Console.WriteLine($"------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"                            <<CAMARONES CONGELADO>>");
            Console.ResetColor();
            Console.WriteLine($" Fecha de Envasado: {CarnesN.FechaDeEnvasado}");
            Console.WriteLine($" Fecha de Caducidad: {CarnesN.FechaDeCaducidad} ");
            Console.WriteLine($" Pais de origen: {CarnesN.PaisDeOrigen}");
            Console.WriteLine($" No. Lote: {CarnesN.NumeroDeLote}");
            Console.WriteLine($" Temperatura de mantenimiento recomendada: {CarnesN.TempDeManteReco}");
            Console.WriteLine($" Metodo de congelación impemantado: {CarnesN.ComposocionDelAire}");
            Console.WriteLine($" Tiempo de exposición al nitrógeno : {CarnesN.TiempodeExposicionNitrogeno}");
            Console.WriteLine($"------------------------------------------------------------------------");
        }
    }
}
