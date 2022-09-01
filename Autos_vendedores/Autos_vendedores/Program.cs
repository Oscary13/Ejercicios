using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos_vendedores
{
    class Program
    {
        public static List<Automovil> ltAuto = new List<Automovil>();
        public static List<Vendedor> ltVendedor = new List<Vendedor>();
        static void Main(string[] args)
        {
            Vendedor v = new Vendedor();
            Automovil A = new Automovil();
            Boolean val;
            int opc, otra;
            string tipo;
            do
            {
                do
                {
                    Console.Clear();
                    menu(); 
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("              Seleccione una opcion: ");
                    Console.WriteLine("------------------------------------------------");
                    opc = int.Parse(Console.ReadLine());
                    val = valida(opc, 4);
                } while (val);
                if (opc == 1)
                {
                    tipo = "AUTOMOVIL";
                }
                else
                {
                    tipo = "VENDEDOR";
                }


                int opc2 = menuDos(tipo);
                if (opc2 == 1)
                {
                    if (opc == 1)
                    {
                        AltaAutomovil();
                    }
                    else if (opc == 2)
                    {
                        AltaVendedor();
                    }
                }
                else if (opc2 == 2)
                {
                    if (opc == 1)
                    {
                        BajaAutomovil();
                    }
                    else if (opc == 2)
                    {
                        BajaVendedor();
                    }
                }
                else if (opc2 == 3)
                {
                    if (opc == 1)
                    {
                        A.EdicionAutomovil(ltAuto);
                    }
                    else if (opc == 2)
                    {
                        v.EdicionVendedor(ltVendedor);
                    }
                }
                else if (opc2 == 4)
                {
                    if (opc == 1)
                    {
                        ImprimirAutomovil();
                    }
                    else if (opc == 2)
                    {
                        ImprimirVendeor();
                    }
                }
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("        Desea realizar otra operación: ");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("(1).- SI ");
                Console.WriteLine("(2).- NO ");
                otra = int.Parse(Console.ReadLine());

            } while (otra == 1);

        }

        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("             AUTODS Y VENDEDORES -OBB-");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(" (1).- AUTOMOVIL");
            Console.WriteLine(" (2).- VENDEOR");
            Console.WriteLine("------------------------------------------------");
        }
        public static int menuDos(string tipo)
        {
            int opc;
            Boolean val2;
            do
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("             AUTOS Y VENDEDORES -OBB-");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("(1).- ALTA " + tipo);
                Console.WriteLine("(2).- BAJA " + tipo);
                Console.WriteLine("(3).- EDICIÓN " + tipo);
                Console.WriteLine("(4).- IMPRIMIR " + tipo);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Seleccione una opcion: ");
                opc = int.Parse(Console.ReadLine());
                val2 = valida2(opc, 4);
            } while (val2);
            return opc;

        }
        public static Boolean valida(int opcion, int tamaño)
        {
            if (opcion < 1 || opcion > 2)
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
        public static Boolean valida2(int opcion, int tamaño)
        {
            if (opcion < 1 || opcion > 4)
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
        public static void AltaAutomovil()
        {
            Console.Clear();
            Console.WriteLine("                       ALTA");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Escriba el nombre del AUTOMOVIL: ");
            string nomAuto = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Escriba el Modelo del AUTOMOVIL: ");
            string modelo = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Escriba el Color del AUTOMOVIL: ");
            string color = Console.ReadLine();
            Console.WriteLine();
            ltAuto.Add(new Automovil() { NombreDelVeiculo = nomAuto, Modelo = modelo, Color = color });
        }
        public static void ImprimirAutomovil()
        {
            Console.Clear();
            Console.WriteLine("                               IMPRIMIR");
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (Automovil item in ltAuto )
            {
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine($" Nombre del veiculo: {item.NombreDelVeiculo} Modelo: {item.Modelo} Color:  {item.Color}");
                Console.WriteLine("--------------------------------------------------------------------");
            }
        }
        public static void AltaVendedor()
        {
            Console.Clear();
            Console.WriteLine("                       ALTA");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Escriba el nombre del VENDEDOR: ");
            string nomVen = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Escriba el Telefono del VENDEDOR: ");
            string tel = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Escriba el Mail del VENDEDOR: ");
            string meil = Console.ReadLine();
            Console.WriteLine();
            ltVendedor.Add(new Vendedor() { NombreDelVendedor = nomVen, Telefono = tel, Mail = meil });
        }
        public static void ImprimirVendeor()
        {
            Console.Clear();
            Console.WriteLine("                               IMPRIMIR");
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (Vendedor item in ltVendedor)
            {
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine($" Nombre del Vendedor:  {item.NombreDelVendedor} Telefono:  {item.Telefono} Mail: {item.Mail}");
                Console.WriteLine("--------------------------------------------------------------------");
            }


        }
        public static void BajaAutomovil()
        {
            Console.Clear();
            Console.WriteLine("INGRESE EL MODELO DEL AUTOMOVIL A DAR DE BAJA");
            string nom = Console.ReadLine();
            int cont = 0;
            int indice = -1;
            foreach (Automovil item in ltAuto)
            {
                if (item.Modelo == nom)
                {
                    indice = cont;
                }
                cont++;
            }
            if (indice > -1)
            {
                ltAuto.RemoveAt(indice);
            }
            Console.WriteLine();
            Console.WriteLine(">>>>> El registro se removio correctamente <<<<<");
        }
        public static void BajaVendedor()
        {
            Console.Clear();
            Console.WriteLine("INGRESE EL NOMBRE DEL VENDEDOR A DAR DE BAJA");
            string nom = Console.ReadLine();
            int cont = 0;
            int indice = -1;
            foreach (Vendedor item in ltVendedor)
            {
                if (item.NombreDelVendedor == nom)
                {
                    indice = cont;
                }
                cont++;
            }
            if (indice > -1)
            {
                ltVendedor.RemoveAt(indice);
            }
            Console.WriteLine();
            Console.WriteLine(">>>>> El registro se removio correctamente <<<<<");
        }

       
        
       
        
    }


}
