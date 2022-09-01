using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_claseAbstracta
{
    class Program
    {
        public static List<Clientes> ltcliente = new List<Clientes>();
        public static List<Vendedores> ltvendedor = new List<Vendedores>();
        static void Main(string[] args)
        {
            int otra;
            Boolean val;
            int opc;
            string tipo;
            do
            {
                do
                {
                    menu();
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Seleccione una opcion: ");
                    opc = int.Parse(Console.ReadLine());
                    val = valida(opc, 2);

                } while (val);
                if (opc == 1)
                {
                    tipo = "Cliente";
                }
                else
                {
                    tipo = "Vendedor";
                }
                int opc2 = menuDos(tipo);
                Clientes cl = new Clientes();
                Vendedores ven = new Vendedores();
                if (opc2 == 1)//Alta
                {
                    Console.Clear();
                    Console.WriteLine($"------------------- Alta {tipo} ----------------");
                    Console.WriteLine("Escriba el nombre: ");
                    string nom = Console.ReadLine();
                    Console.WriteLine("Escriba el apellido Paterno: ");
                    string pat = Console.ReadLine();
                    Console.WriteLine("Escriba el apellido Materno: ");
                    string mat = Console.ReadLine();
                    Console.WriteLine("Escriba su direccion: ");
                    string direc = Console.ReadLine();
                    Console.WriteLine("Escriba el telefono: ");
                    string tel = Console.ReadLine();
                    Console.WriteLine("Escriba el Email: ");
                    string mail = Console.ReadLine();
                    if (opc == 1)//Alta de cliente
                    {
                        Console.WriteLine("Ingrese la zona del cliente: ");
                        string zona = Console.ReadLine();
                        Console.WriteLine("Ingrese el ID del cliente: ");
                        int ID = int.Parse(Console.ReadLine());
                        cl.AltaClinte(nom, pat, mat, direc, tel, mail, zona, ID, ltcliente);

                    }
                    else if (opc == 2)//Alta provedor
                    {
                        Console.WriteLine("Ingrese el RFC del vendedor: ");
                        string RFC = Console.ReadLine();
                        Console.WriteLine("Ingrese el Genero del vendedor: ");
                        string genero = Console.ReadLine();
                        Console.WriteLine("Ingrese el tipo Proveedor: ");
                        string tipoVendedor = Console.ReadLine();
                        ven.AltaVendedor(nom, pat, mat, direc, tel, mail, RFC, genero, tipoVendedor, ltvendedor);
                    }


                }

                else if (opc2 == 2)//Baja
                {
                    if (opc == 1)
                    {
                        Console.Clear();
                        cl.BajaClinte(ltcliente);
                    }
                    else if (opc == 2)
                    {
                        Console.Clear();
                        ven.BajaVendedor(ltvendedor);
                    }
                }
                else if (opc2 == 3)//Edidcion
                {
                    if (opc == 1)
                    {
                        Console.Clear();
                        cl.EdicionClinte(ltcliente);
                    }
                    else if (opc == 2)
                    {
                        Console.Clear();
                        ven.EdicionProveedor(ltvendedor);
                    }
                }
                else if (opc2 == 4)//Consulta
                {

                    int opcBuscar = menuBusqueda();
                    if (opc == 1)
                    {
                        Console.Clear();
                        cl.ConsultaCliente(opcBuscar, ltcliente);

                    }
                    else if (opc == 2)
                    {
                        Console.Clear();
                        ven.ConsultaVendedor(opcBuscar, ltvendedor);
                    }


                }
                Console.WriteLine("");
                Console.WriteLine(">>>>> Preciona ENTER para continuar <<<<<");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("         Desea realizar otra operación:");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("                   (1).- SI");
                Console.WriteLine("                   (2).- NO");
                otra = int.Parse(Console.ReadLine());
            } while (otra ==1);
            Console.Clear();
            Console.WriteLine("Gracias por utilizar el sitema -OBB-");
            Console.ReadKey();
        }

        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("     Sistema de Clientes y Vendedores -OBB-");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("               (1).- Clientes");
            Console.WriteLine("               (2).- Vendedores");
        }
        public static Boolean valida(int opcion, int tamaño)
        {
            if (opcion < 1 || opcion > 2)
            {
                Console.WriteLine("La opccion seleccionada es invalida........");
                Console.ReadKey();
                return true;

            }
            else
            {
                return false;
            }
        }

        public static int menuDos(string tipo)
        {
            int opc;
            Boolean val;
            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(" Sistema de Clientes y Vendedores -OBB-");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("         (1).- Alta " + tipo);
                Console.WriteLine("         (2).- Baja " + tipo);
                Console.WriteLine("         (3).- Edición " + tipo);
                Console.WriteLine("         (4).- Consulta " + tipo);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Seleccione una opcion: ");
                opc = int.Parse(Console.ReadLine());
                val = valida2(opc, 4);
            } while (val);
            return opc;

        }

        public static Boolean valida2(int opcion, int tamaño)
        {
            if (opcion < 1 || opcion > 4)
            {
                Console.WriteLine("La opccion seleccionada es invalida........");
                Console.ReadKey();
                return true;

            }
            else
            {
                return false;
            }
        }
        public static int menuBusqueda()
        {
            Boolean val;
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("        Sistema de Clientes y Vendedores -OBB-");
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("(1).- Busqueda por Id para cliente, RFC para vendedor");
                Console.WriteLine("(2).- Busqueda por Nombre");
                Console.WriteLine("(3).- Busqueda por Apellido Paterno ");
                Console.WriteLine("(4).- Busqueda por Apellido Materno ");
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Seleccione una opcion: ");
                opc = int.Parse(Console.ReadLine());
                val = valida2(opc, 4);
            } while (val);
            return opc;
        }
    }
}
