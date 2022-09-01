using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos_vendedores
{
    class Vendedor
    {
        public string NombreDelVendedor;
        public string Telefono;
        public string Mail;
        public void EdicionVendedor(List<Vendedor> ltVendedor)
        {
            Console.Clear();
            List<Vendedor> ltAlterna = new List<Vendedor>();
            
            Console.WriteLine("Ingresa el Nomnbre del Vendedor a editar");
            string nomVendedor = Console.ReadLine();
            Console.Clear();
            int opc = menuEdicionVendedor();
            foreach (Vendedor item in ltVendedor)
            {
                ltAlterna.Add(item);
                if (item.NombreDelVendedor == nomVendedor)
                {
                    NombreDelVendedor = item.NombreDelVendedor;
                    Telefono = item.Telefono; 
                    Mail = item.Mail;
                }
            }
            Console.Clear();
            ltVendedor.Clear();
            if (opc == 1)
            {
                Console.WriteLine("Ingresa el nuevo Nombre del Vendedor");
                NombreDelVendedor = Console.ReadLine();
            }
            else if (opc == 2)
            {
                Console.WriteLine("Ingresa el nuevo Telefono ");
                Telefono = Console.ReadLine();
            }
            else if (opc == 3)
            {
                Console.WriteLine("Ingresa el nuevo Mail");
                Mail = Console.ReadLine();

            }
            foreach (Vendedor item in ltAlterna)
            {
                if (item.NombreDelVendedor == nomVendedor)
                {
                    Console.Clear();
                    ltVendedor.Add(new Vendedor() { NombreDelVendedor = NombreDelVendedor, Telefono = Telefono, Mail = Mail });
                    Console.WriteLine(">>>>> El registro se edito con exito <<<<<");
                }
                else
                {
                    ltVendedor.Add(item);
                }
            }
        }
        public int menuEdicionVendedor()
        {
            Boolean val;
            int opc;
            do
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("                      EDICIÓN");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("  (1).- Nombre del Vendedor");
                Console.WriteLine("  (2).- Telefono");
                Console.WriteLine("  (3).- Mail");
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
