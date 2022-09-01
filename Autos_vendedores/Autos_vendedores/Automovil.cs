using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos_vendedores
{
    class Automovil
    {
        public string NombreDelVeiculo;
        public string Modelo;
        public string Color;

        public void EdicionAutomovil(List<Automovil> ltAuto)
        {
            Console.Clear();
            List<Automovil> ltAlterna = new List<Automovil>();
            Console.WriteLine("Ingresa el Modelo del Automovil a editar ");
            string modelo = Console.ReadLine();
            Console.Clear();
            int opc = menuEdicionAutomovil();
            foreach (Automovil item in ltAuto)
            {
                ltAlterna.Add(item);
                if (item.Modelo == modelo)
                {
                    NombreDelVeiculo = item.NombreDelVeiculo;
                    Modelo = item.Modelo; 
                    Color = item.Color;
                }
            }
            Console.Clear();
            ltAuto.Clear();
            if (opc == 1)
            {
                Console.WriteLine("Ingresa el nuevo Nombre del Veiculo");
                NombreDelVeiculo = Console.ReadLine();
            }
            else if (opc == 2)
            {
                Console.WriteLine("Ingresa el nuevo Modelo ");
                Modelo = Console.ReadLine();

            }
            else if (opc == 3)
            {
                Console.WriteLine("Ingresa el nuevo Color");
                Color = Console.ReadLine();
            }
            foreach (Automovil item in ltAlterna)
            {
                if (item.Modelo == modelo)
                {
                    Console.Clear();
                    ltAuto.Add(new Automovil() { NombreDelVeiculo = NombreDelVeiculo, Modelo = Modelo, Color = Color });
                    Console.WriteLine(">>>>> El registro se edito con exito <<<<<");
                }
                else
                {
                    ltAuto.Add(item);
                }
            }
        }
        public int menuEdicionAutomovil()
        {
            Boolean val;
            int opc;
            do
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("                      EDICIÓN");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("  (1).- Nombre del Veiculo");
                Console.WriteLine("  (2).- Modelo");
                Console.WriteLine("  (3).- Color");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Seleccione una opcion a editar: ");
                opc = int.Parse(Console.ReadLine());
                val = valida3(opc, 3);
            } while (val);
            return opc;

        }
        public static Boolean valida3(int opcion, int tamaño)
        {
            if (opcion < 1 || opcion > 3)
            {
                Console.Clear();
                Console.WriteLine("La opccion seleccionada es invalida........");
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
