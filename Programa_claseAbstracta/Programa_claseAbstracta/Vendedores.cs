using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_claseAbstracta
{
    class Vendedores : Base_datos
    {
        public string RFCDelVendedor { get; set; }
        public string Genero { get; set; }
        public string TipoDeVendedor { get; set; }
        public void AltaVendedor(string nombre, string paterno, string materno, string direccion, string telefono, string mail, string RFC, string genero, string tipoVendedor, List<Vendedores> ltvendedor)
        {

            ltvendedor.Add(new Vendedores() { nombre = nombre, aPaterno = paterno, aMaterno = materno, direccion = direccion, telefono = telefono, mail = mail, RFCDelVendedor = RFC, Genero = genero, TipoDeVendedor = tipoVendedor });

        }

        public void BajaVendedor(List<Vendedores> ltvendedor)
        {
            Console.WriteLine("INGRESE EL RFC DEL VENDEDOR A DAR DE BAJA");
            string RFCdelcliente = Console.ReadLine();
            Console.Clear();
            int cont = 0;
            int indice = -1;
            foreach (Vendedores item in ltvendedor)
            {
                if (item.RFCDelVendedor == RFCdelcliente)
                {
                    indice = cont;
                }
                cont++;
            }
            if (indice > -1)
            {
                ltvendedor.RemoveAt(indice);
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("    El registro se removio correctamente");
                Console.WriteLine("------------------------------------------------");
            }
            else
            {
                noexiste();
            }

        }

        public void EdicionProveedor(List<Vendedores> ltvendedor)
        {
            List<Vendedores> ltAlterna = new List<Vendedores>();

            Console.WriteLine("Ingresa el RFC del vendedor a modificar");
            string RFC = Console.ReadLine();
            int opc = menuEdicionP();
            Console.Clear();
            foreach (Vendedores item in ltvendedor)
            {
                ltAlterna.Add(item);
                if (item.RFCDelVendedor == RFC)
                {
                    nombre = item.nombre;
                    aPaterno = item.aPaterno;
                    aMaterno = item.aMaterno;
                    direccion = item.direccion;
                    telefono = item.telefono;
                    mail = item.mail;
                    RFCDelVendedor = item.RFCDelVendedor;
                    Genero = item.Genero;
                    TipoDeVendedor = item.TipoDeVendedor;
                }
            }
            ltvendedor.Clear();
            if (opc == 1)
            {
                Console.WriteLine("Ingresa el nuevo nombre");
                nombre = Console.ReadLine();
            }
            else if (opc == 2)
            {
                Console.WriteLine("Ingresa el nuevo Apellido Paterno");
                aPaterno = Console.ReadLine();
            }
            else if (opc == 3)
            {
                Console.WriteLine("Ingresa el nuevo Apellido Materno");
                aMaterno = Console.ReadLine();
            }
            else if (opc == 4)
            {
                Console.WriteLine("Ingresa la nueva dirección");
                direccion = Console.ReadLine();
            }
            else if (opc == 5)
            {
                Console.WriteLine("Ingresa el nuevo telefono");
                telefono = Console.ReadLine();
            }
            else if (opc == 6)
            {
                Console.WriteLine("Ingresa el nuevo email");
                mail = Console.ReadLine();
            }
            else if (opc == 7)
            {
                Console.WriteLine("Ingresa el nuevo Genero del vendedor");
                Genero = Console.ReadLine();

            }

            else if (opc == 8)
            {
                Console.WriteLine("Ingresa el nuevo Tipo de vendedor");
                TipoDeVendedor = Console.ReadLine();
            }
            foreach (Vendedores item in ltAlterna)
            {
                if (item.RFCDelVendedor == RFC)
                {
                    ltvendedor.Add(new Vendedores() { nombre = nombre, aPaterno = aPaterno, aMaterno = aMaterno, direccion = direccion, telefono = telefono, mail = mail, RFCDelVendedor = RFCDelVendedor, Genero = Genero, TipoDeVendedor = TipoDeVendedor });
                    Console.Clear();
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("        El registro se edito con exito");
                    Console.WriteLine("------------------------------------------------");
                }
                else
                {
                    ltvendedor.Add(item);
                    Console.Clear();
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("            El registro no se edito");
                    Console.WriteLine("------------------------------------------------");
                }
            }
        }



        public int menuEdicionP()
        {

            Boolean val;
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("     Sistema de Clientes y Vendedores -OBB-");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("                (1).- Nombre");
                Console.WriteLine("                (2).- Apellido Paterno");
                Console.WriteLine("                (3).- Apellido Materno");
                Console.WriteLine("                (4).- Dirección");
                Console.WriteLine("                (5).- Telefono");
                Console.WriteLine("                (6).- email");
                Console.WriteLine("                (7).- Genero");
                Console.WriteLine("                (8).- Tipo de vendedor");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Seleccione una opcion a editar: ");
                opc = int.Parse(Console.ReadLine());
                val = valida(opc, 8);
            } while (val);
            return opc;

        }

        public static Boolean valida(int opcion, int tamaño)
        {
            if (opcion < 1 || opcion > 8)
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


        public void ConsultaVendedor(int opcBuscar, List<Vendedores> ltvendedor)
        {
            string RFC;
            string nombre, paterno, materno;
            if (opcBuscar == 1)
            {
                Console.WriteLine("Ingrese la RFC del Vendedor");
                RFC = Console.ReadLine();
                foreach (Vendedores item in ltvendedor)
                {
                    if (RFC == item.RFCDelVendedor)
                    {
                        Console.Clear();
                        Console.WriteLine($"El nombre del Vendedor es: {item.nombre} {item.aPaterno} {item.aMaterno} y con numero de Telefono: {item.telefono}, mail: {mail}, dirección: {item.direccion}, RFC: {item.RFCDelVendedor}, de Genero: {item.Genero}, de Tipo: {item.TipoDeVendedor} ");
                    }
                    else
                    {
                        noexiste();
                    }
                }
            }
            else if (opcBuscar == 2)
            {
                Console.WriteLine("Ingrese el Nombre del Vendedor");
                nombre = Console.ReadLine();
                foreach (Vendedores item in ltvendedor)
                {
                    if (nombre == item.nombre)
                    {
                        Console.Clear();
                        Console.WriteLine($"El nombre del Vendedor es: {item.nombre} {item.aPaterno} {item.aMaterno} y con numero de Telefono: {item.telefono}, mail: {mail}, dirección: {item.direccion}, RFC: {item.RFCDelVendedor}, de Genero: {item.Genero}, de Tipo: {item.TipoDeVendedor} ");
                    }
                    else
                    {
                        noexiste();
                    }
                }
            }
            else if (opcBuscar == 3)
            {
                Console.WriteLine("Ingrese el Apellido Paterno del Vendedor");
                paterno = Console.ReadLine();
                foreach (Vendedores item in ltvendedor)
                {
                    if (paterno == item.aPaterno)
                    {
                        Console.Clear();
                        Console.WriteLine($"El nombre del Vendedor es: {item.nombre} {item.aPaterno} {item.aMaterno} y con numero de Telefono: {item.telefono}, mail: {mail}, dirección: {item.direccion}, RFC: {item.RFCDelVendedor}, de Genero: {item.Genero}, de Tipo: {item.TipoDeVendedor} ");
                    }
                    else
                    {
                        noexiste();
                    }
                }
            }
            else if (opcBuscar == 4)
            {
                Console.WriteLine("Ingrese el Apellido Materno del Vendedor");
                materno = Console.ReadLine();
                foreach (Vendedores item in ltvendedor)
                {
                    if (materno == item.aMaterno)
                    {
                        Console.Clear();
                        Console.WriteLine($"El nombre del Vendedor es: {item.nombre} {item.aPaterno} {item.aMaterno} y con numero de Telefono: {item.telefono}, mail: {mail}, dirección: {item.direccion}, RFC: {item.RFCDelVendedor}, de Genero: {item.Genero}, de Tipo: {item.TipoDeVendedor} ");
                    }
                    else
                    {
                        noexiste();
                    }
                }
            }

        }
        public static void noexiste()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("            El registro NO existe");
            Console.WriteLine("------------------------------------------------");

        }

    }
}
