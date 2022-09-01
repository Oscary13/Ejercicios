using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Raul_Autos_Vendedores
{
    class Program
    {
        public static List<Vendedor> ltvendedor = new List<Vendedor>();
        public static List<Vehiculo> ltvehiculo = new List<Vehiculo>();
        static void Main(string[] args)
        {
            int opc, opc2, otra;
            menu();
            Console.WriteLine(" Digita la opcion que deseas ");
            opc = int.Parse(Console.ReadLine());
            if (opc == 1)
            {
                do
                {
                    menudos();
                    opc2 = int.Parse(Console.ReadLine());
                    if (opc2 == 1)
                    {
                        AltaVendedor();
                    }
                    else if (opc2 == 2)
                    {
                        bajaVendedor();
                    }
                    else if (opc2 == 3)
                    {
                        editarVendedor(ltvendedor);
                    }
                    else if (opc2 == 4)
                    {
                        ImprimirVendedor();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" Quieres hacer otra operación ");
                    Console.WriteLine("           (1): SI ");
                    Console.WriteLine("           (2): NO ");
                    otra = int.Parse(Console.ReadLine());
                } while (otra == 1);

            }
            else if (opc == 2)
            {
                do
                {
                    menudos();
                    opc2 = int.Parse(Console.ReadLine());
                    if (opc2 == 1)
                    {
                        AltaVehiculo();
                    }
                    else if (opc == 2)
                    {
                        bajaVehiculo();
                    }
                    else if (opc2 == 3)
                    {
                        editarVehiculo(ltvehiculo);
                    }
                    else if (opc2 == 4)
                    {
                        ImprimirVehiculo();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" Quieres hacer otra operación ");
                    Console.WriteLine("           (1): SI ");
                    Console.WriteLine("           (2): NO ");
                    otra = int.Parse(Console.ReadLine());
                } while (otra == 1);

            }
        }
        public static void menu()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("                AUTOS");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("           (1)  Vendedor");
            Console.WriteLine("           (2)  Vehiculo");
            Console.WriteLine("-----------------------------------");
        }
        public static void menudos()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("             (1) Alta");
            Console.WriteLine("             (2) Baja");
            Console.WriteLine("             (3) Editar");
            Console.WriteLine("             (4) Imprimir");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("SELECCIONE UNA OPCION");
        }
        public static void AltaVendedor()
        {
            Console.Clear();
            Console.WriteLine("Ingrese su nombre ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su mail");
            string correo = Console.ReadLine();
            Console.WriteLine("Ingrese su telefono");
            string telefono = Console.ReadLine();
            ltvendedor.Add(new Vendedor() { Nombre = nombre, Correo = correo, Telefono = telefono });
        }
        public static void ImprimirVendedor()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("----- Imprimir datos -----");
            foreach (Vendedor item in ltvendedor)
            {
                Console.WriteLine(item.Nombre + " " + item.Correo + " " + item.Telefono);
            }
        }
        public static void AltaVehiculo()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del vehiculo");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el modelo del vehiculo");
            string modelo = Console.ReadLine();
            Console.WriteLine("Ingrese el color del vehiculo");
            string color = Console.ReadLine();
            ltvehiculo.Add(new Vehiculo() { Nombre = nombre, Modelo = modelo, Color = color });

        }
        public static void ImprimirVehiculo()
        {
            Console.Clear();
            Console.WriteLine("------- Lista de Vehiculos Actuales -------");
            foreach (Vehiculo item in ltvehiculo)
            {
                Console.WriteLine(item.Nombre + " " + item.Modelo + " " + item.Color);
            }
        }
        public static void bajaVendedor()
        {
            Console.Clear();
            Console.WriteLine("Ingresa el nombre del vendedor que se dara de baja");
            string nombre = Console.ReadLine();
            int cont = 0;
            int indice = -1;

            foreach (Vendedor item in ltvendedor)
            {
                if (item.Nombre == nombre)
                {
                    indice = cont;
                }
                cont++;
            }
            if (indice > -1)
            {
                ltvendedor.RemoveAt(indice);
                Console.WriteLine("------ Registro eliminado ------ ");
            }
        }
        public static void bajaVehiculo()
        {
            Console.Clear();
            Console.WriteLine("ingresa el nombre del Vehiculo que se dara de baja ");
            string nombre = Console.ReadLine();
            int cont = 0;
            int indice = -1;

            foreach (Vehiculo item in ltvehiculo)
            {
                if (item.Nombre == nombre)
                {
                    indice = cont;
                }
                cont++;
            }
            if (indice > -1)
            {
                ltvehiculo.RemoveAt(indice);
                Console.WriteLine("------ Registro eliminado ------ ");
            }
        }
        public static void editarVendedor(List<Vendedor> ltvendedor)
        {

            List<Vendedor> ltalterna = new List<Vendedor>();
            foreach (Vendedor item in ltvendedor)
            {
                ltalterna.Add(item);
            }

            Console.WriteLine("ingrese el nombre del vendedor a editar");
            string nombre = Console.ReadLine();
            int opc = MenuEdicion();
            ltvendedor.Clear();

            if (opc == 1)
            {
                Console.WriteLine("ingrese el correo nuevo");
                string correo = Console.ReadLine();

                foreach (Vendedor item in ltalterna)
                {
                    if (item.Nombre == nombre)
                    {
                        ltvendedor.Add(new Vendedor() { Nombre = item.Nombre, Correo = correo, Telefono = item.Telefono });
                    }
                    else
                    {
                        ltvendedor.Add(item);
                    }
                }
                Console.WriteLine("------- Registro editado -------");
            }
            else if (opc == 2)
            {
                Console.WriteLine("ingrese el telefono nuevo");
                string telefono = Console.ReadLine();

                foreach (Vendedor item in ltalterna)
                {
                    if (item.Nombre == nombre)
                    {
                        ltvendedor.Add(new Vendedor() { Nombre = item.Nombre, Correo = item.Correo, Telefono = item.Telefono });
                    }
                    else
                    {
                        ltvendedor.Add(item);
                    }
                }
                Console.WriteLine("------- Registro editado -------");
            }

        }
        public static void editarVehiculo(List<Vehiculo> ltvehiculo)
        {

            List<Vehiculo> ltalterna = new List<Vehiculo>();
            foreach (Vehiculo item in ltvehiculo)
            {
                ltalterna.Add(item);
            }

            Console.WriteLine("ingrese el nombre del vehiculo a editar");
            string nombre = Console.ReadLine();
            int opc = MenuEdicion2();
            ltvehiculo.Clear();

            if (opc == 1)
            {
                Console.WriteLine("ingrese el nuevo modelo del vehiculo");
                string modelo = Console.ReadLine();

                foreach (Vehiculo item in ltalterna)
                {
                    if (item.Nombre == nombre)
                    {
                        ltvehiculo.Add(new Vehiculo() { Nombre = item.Nombre, Modelo = modelo, Color = item.Color });
                    }
                    else
                    {
                        ltvehiculo.Add(item);
                    }
                }
                Console.WriteLine("------- Registro editado -------");
            }
            else if (opc == 2)
            {
                Console.WriteLine("ingrese el nuevo color del vehiculo");
                string color = Console.ReadLine();

                foreach (Vehiculo item in ltalterna)
                {
                    if (item.Nombre == nombre)
                    {
                        ltvehiculo.Add(new Vehiculo() { Nombre = item.Nombre, Modelo = item.Modelo, Color = color });
                    }
                    else
                    {
                        ltvehiculo.Add(item);
                    }
                }
                Console.WriteLine("------- Registro editado -------");
            }

        }
        public static int MenuEdicion2()
        {
            Boolean val;
            int opc;
            do
            {

                Console.Clear();
                Console.WriteLine("-------------------------------");
                Console.WriteLine("         (1)  MODELO");
                Console.WriteLine("         (2)  COLOR");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("     seleccione una opcion");
                opc = int.Parse(Console.ReadLine());
                val = valida(opc, 2);
            } while (val);
            return opc;
        }
        public static int MenuEdicion()
        {
            Boolean val;
            int opc;
            do
            {

                Console.Clear();
                Console.WriteLine("-------------------------------");
                Console.WriteLine("          (1) CORREO");
                Console.WriteLine("          (2) TELEFONO");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("seleccione una opcion");
                opc = int.Parse(Console.ReadLine());
                val = valida(opc, 2);
            } while (val);
            return opc;
        }
        public static Boolean valida(int opcion, int tamaño)
        {
            if (opcion < 1 || opcion > tamaño)
            {
                Console.WriteLine("la opcion es invalida");
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
