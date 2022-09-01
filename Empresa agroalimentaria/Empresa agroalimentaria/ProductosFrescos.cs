using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_agroalimentaria
{
    class ProductosFrescos : Herencia
    {

        public void pescadosfrescos()
        {
            ProductosFrescos pescadosF = new ProductosFrescos();
            pescadosF.FechaDeCaducidad = "25/ Marzo/ 2021";
            pescadosF.NumeroDeLote = 01360912;
            pescadosF.FechaDeEnvasado = "03/ Marzo/ 2021";
            pescadosF.PaisDeOrigen = "México";
            Console.WriteLine($"------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"                            <<PESCADOS FRESCOS>>");
            Console.ResetColor();
            Console.WriteLine($" Fecha de Envasado: {pescadosF.FechaDeEnvasado}");
            Console.WriteLine($" Fecha de Caducidad: {pescadosF.FechaDeCaducidad}");
            Console.WriteLine($" Pais de origen: {pescadosF.PaisDeOrigen}");
            Console.WriteLine($" No. Lote: {pescadosF.NumeroDeLote}");
            Console.WriteLine($"------------------------------------------------------------------------"); ;
        }
        public void KiloDeHuevo()
        {
            ProductosFrescos huevo = new ProductosFrescos();
            huevo.FechaDeCaducidad = "23/ Enero/ 2021";
            huevo.NumeroDeLote = 0036579128;
            huevo.FechaDeEnvasado = "01/ Marzo/ 2022";
            huevo.PaisDeOrigen = "México";
            Console.WriteLine($"------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"                            <<KILO DE HUEVO>>");
            Console.ResetColor();
            Console.WriteLine($" Fecha de Envasado: {huevo.FechaDeEnvasado}");
            Console.WriteLine($" Fecha de Caducidad: {huevo.FechaDeCaducidad} ");
            Console.WriteLine($" Pais de origen: {huevo.PaisDeOrigen}");
            Console.WriteLine($" No. Lote: {huevo.NumeroDeLote}");
            Console.WriteLine($"------------------------------------------------------------------------");
        }

    }
}
