using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_agroalimentaria
{
    class ProductosRefrigerados : Herencia
    {
        public string CodigodelOSA;
        public void CarneDeAveRefrigerada()
        {
            ProductosRefrigerados carnedeave = new ProductosRefrigerados();
            carnedeave.FechaDeCaducidad = "23/ Abril/ 2021";
            carnedeave.NumeroDeLote = 01000457;
            carnedeave.FechaDeEnvasado = "01/ Febreo/ 2021";
            carnedeave.PaisDeOrigen = "Venezuela";
            carnedeave.CodigodelOSA = "B#6745";
            carnedeave.TempDeManteReco = "De 28 a 41 °F (-2,2 a 5 °C)";
            Console.WriteLine($"------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"                       <<CARNE DE AVE REFRIGERADA>>");
            Console.ResetColor();
            Console.WriteLine($" Fecha de Envasado: {carnedeave.FechaDeEnvasado}");
            Console.WriteLine($" Fecha de Caducidad: {carnedeave.FechaDeCaducidad} ");
            Console.WriteLine($" Pais de origen: {carnedeave.PaisDeOrigen}");
            Console.WriteLine($" No. Lote: {carnedeave.NumeroDeLote}");
            Console.WriteLine($" Código del organizmo de supervición alimentaria: {carnedeave.CodigodelOSA}");
            Console.WriteLine($" Temperatura de mantenimiento recomendada: {carnedeave.TempDeManteReco}");
            Console.WriteLine($"------------------------------------------------------------------------");
        }
        public void Alimentosprocesadosrefrigerados()
        {
            ProductosRefrigerados alimentosprocesadosrefri = new ProductosRefrigerados();
            alimentosprocesadosrefri.FechaDeCaducidad = "13/ Enero/ 2023";
            alimentosprocesadosrefri.NumeroDeLote = 09301232;
            alimentosprocesadosrefri.FechaDeEnvasado = "13/ Febreo/ 2021";
            alimentosprocesadosrefri.PaisDeOrigen = "Venezuela";
            alimentosprocesadosrefri.CodigodelOSA = "A#39278";
            alimentosprocesadosrefri.TempDeManteReco = "De 32 a 41 °F (0 a 5 °C)";
            Console.WriteLine($"------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"                 <<ALIMENTOS PROCESADOS REFRIGERADOS>>");
            Console.ResetColor();
            Console.WriteLine($" Fecha de Envasado: {alimentosprocesadosrefri.FechaDeEnvasado}");
            Console.WriteLine($" Fecha de Caducidad: {alimentosprocesadosrefri.FechaDeCaducidad} ");
            Console.WriteLine($" Pais de origen: {alimentosprocesadosrefri.PaisDeOrigen}");
            Console.WriteLine($" No. Lote: {alimentosprocesadosrefri.NumeroDeLote}");
            Console.WriteLine($" Código del organizmo de supervición alimentaria: {alimentosprocesadosrefri.CodigodelOSA}");
            Console.WriteLine($" Temperatura de mantenimiento recomendada: {alimentosprocesadosrefri.TempDeManteReco}");
            Console.WriteLine($"------------------------------------------------------------------------");
        }

        public void Huevosencáscararefrigerados()
        {
            ProductosRefrigerados huevorefri = new ProductosRefrigerados();
            huevorefri.FechaDeCaducidad = "24/ Diciembre/ 2021";
            huevorefri.NumeroDeLote = 10179380;
            huevorefri.FechaDeEnvasado = "20/ Octubre/ 2020";
            huevorefri.PaisDeOrigen = "Mexico";
            huevorefri.CodigodelOSA = "A#29301";
            huevorefri.TempDeManteReco = "De 32 a 45 °F (0 a 7,2 °C)";
            Console.WriteLine($"------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;  Console.WriteLine($"                    <<HUEVOS EN CASCARA REFRIGERADOS>>");
            Console.ResetColor();
            Console.WriteLine($" Fecha de Envasado: {huevorefri.FechaDeEnvasado}");
            Console.WriteLine($" Fecha de Caducidad: {huevorefri.FechaDeCaducidad} ");
            Console.WriteLine($" Pais de origen: {huevorefri.PaisDeOrigen}");
            Console.WriteLine($" No. Lote: {huevorefri.NumeroDeLote}");
            Console.WriteLine($" Código del organizmo de supervición alimentaria: {huevorefri.CodigodelOSA}");
            Console.WriteLine($" Temperatura de mantenimiento recomendada: {huevorefri.TempDeManteReco}");
            Console.WriteLine($"------------------------------------------------------------------------");
        }
    }
}
