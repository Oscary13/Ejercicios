using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesProveedores
{
    class Program
    {
        public static List<Clientes> ltcliente = new List<Clientes>();
        public static List<Proveedores> ltproveedor = new List<Proveedores>();
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
                    tipo = "Proveedor";
                }
                int opc2 = menuDos(tipo);

                Clientes cl = new Clientes();
                Proveedores pr = new Proveedores();
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
                    Console.WriteLine("Escriba el telefono: ");
                    string tel = Console.ReadLine();
                    Console.WriteLine("Escriba el Email: ");
                    string mail = Console.ReadLine();
                    Console.WriteLine("Escriba el RFC: ");
                    string rfc = Console.ReadLine();
                    Console.WriteLine("Escriba su direccion: ");
                    string direc = Console.ReadLine();
                    Console.WriteLine("Escriba su Codigo Postal: ");
                    string cp = Console.ReadLine();
                    if (opc == 1)//Alta de cliente
                    {
                        Console.WriteLine("Ingrese su numero de cliente: ");
                        int noClient = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese su edad: ");
                        int edad = int.Parse(Console.ReadLine());
                        cl.AltaClinte(nom, pat, mat, tel, rfc, mail, direc, cp, noClient, edad, ltcliente);

                    }
                    else if (opc == 2)//Alta provedor
                    {
                        Console.WriteLine("Ingrese la razón social: ");
                        string rSocial = Console.ReadLine();
                        Console.WriteLine("Ingrese el numero de proveedor: ");
                        int numProveedor = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el tipo Proveedor: ");
                        string tipoProveedor = Console.ReadLine();
                        pr.AltaProveedor(nom, pat, mat, tel, rfc, mail, direc, cp, rSocial, numProveedor, tipoProveedor, ltproveedor);
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
                        pr.BajaProveedor(ltproveedor);
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
                        pr.EdicionProveedor(ltproveedor);
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
                    else if (opc == 2 )
                    {
                        Console.Clear();
                        pr.ConsultaProveedor(opcBuscar, ltproveedor);
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
            Console.WriteLine("Gracias por utilizar el sitema -OBB-");
            Console.ReadKey();

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
        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("     Sistema de Clientes y Proveedores 3221");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("1.- Clientes");
            Console.WriteLine("2.- Proveedores");
        }
        public static int menuDos(string tipo)
        {
            int opc;
            Boolean val;
            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(" Sistema de Clientes y Proveedores 3221");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("1.- Alta " + tipo);
                Console.WriteLine("2.- Baja " + tipo);
                Console.WriteLine("3.- Edición " + tipo);
                Console.WriteLine("4.- Consulta " + tipo );
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Seleccione una opcion: ");
                opc = int.Parse(Console.ReadLine());
                val = valida2(opc, 4);
            } while (val);
            return opc;

        }
        public static int menuBusqueda()
        {
            Boolean val;
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("     Sistema de Clientes y Proveedores 3221");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("(1).- Busqueda por Id ");
                Console.WriteLine("(2).- Busqueda por Nombre");
                Console.WriteLine("(3).- Busqueda por Apellido Paterno ");
                Console.WriteLine("(4).- Busqueda por Apellido Materno ");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Seleccione una opcion: ");
                opc = int.Parse(Console.ReadLine());
                val = valida2(opc, 4);
            } while (val);
            return opc;
        }

    }
}
