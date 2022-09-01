using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesProveedores
{
    class Proveedores : Herencia
    {

        public string razonSocial;
        public int noProveedor;
        public string tipoProveedor;
        public void AltaProveedor(string nombre, string paterno, string materno, string telefono, string rfc, string mail, string direccion, string CP, string razonSocial, int NumProveedor, string tipo, List<Proveedores> ltproveedores)
        {

            ltproveedores.Add(new Proveedores() { nombre = nombre, aPaterno = paterno, aMaterno = materno, telefono = telefono, RFC = rfc, mail = mail, direccion = direccion, razonSocial = razonSocial, noProveedor = NumProveedor, tipoProveedor = tipo });
            //Console.WriteLine($"El nombre del cliente es: {nombre} {aPaterno} {aMaterno} y con numero de Telefono: {telefono} RFC: {RFC}, mail {mail}, dirección {direccion} {CP}, con numero de proveedor: {NumProveedor},  razon social: {razonSocial} y tipo de proveedor: {tipoProveedor}");
        }
        public void BajaProveedor(List<Proveedores>ltproveedores)
        {
            Console.WriteLine("INGRESE EL ELEMENTO A DAR DE BAJA");
            int noProveedor = int.Parse(Console.ReadLine());
            int cont = 0;
            int indice = -1;
            foreach (Proveedores item in ltproveedores)
            {
                if (item.noProveedor == noProveedor)
                {
                    indice = cont;
                }
                cont++;
            }
            if (indice > -1)
            {
                ltproveedores.RemoveAt(indice);
            }
            Console.WriteLine(">>>>> El registro se removio correctamente <<<<<");
        }
        public void EdicionProveedor(List<Proveedores> ltproveedores)
        {
            List<Proveedores> ltAlterna = new List<Proveedores>();
           
            Console.WriteLine("Ingresa el numero de cliente a modificar");
            int noProveedor = int.Parse(Console.ReadLine());
            int opc = menuEdicionP();
            foreach (Proveedores item in ltproveedores)
            {
                ltAlterna.Add(item);
                if (item.noProveedor == noProveedor)
                {
                    nombre = item.nombre;
                    aPaterno = item.aPaterno;
                    aMaterno = item.aMaterno;
                    telefono = item.telefono;
                    mail = item.mail;
                    RFC = item.RFC;
                    direccion = item.direccion;
                    CP = item.CP;
                    razonSocial = item.razonSocial;
                    tipoProveedor = item.tipoProveedor;
                    noProveedor = item.noProveedor;
                }
            }
            ltproveedores.Clear();
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
                Console.WriteLine("Ingresa el nuevo telefono");
                telefono = Console.ReadLine();
            }
            else if (opc == 5)
            {
                Console.WriteLine("Ingresa el nuevo email");
                mail = Console.ReadLine();
            }
            else if (opc == 6)
            {
                Console.WriteLine("Ingresa el nuevo RFC");
                RFC = Console.ReadLine();

            }
            else if (opc == 7)
            {
                Console.WriteLine("Ingresa la nueva dirección");
                direccion = Console.ReadLine();
            }
            else if (opc == 8)
            {
                Console.WriteLine("Ingresa el nuevo CP");
                CP = Console.ReadLine();
            }
            else if (opc == 9)
            {
                Console.WriteLine("Ingresa la nueva Razon social");
                razonSocial = Console.ReadLine();
            }
            else if (opc == 10)
            {
                Console.WriteLine("Ingresa el nuevo Tipo de proveedor");
                tipoProveedor = Console.ReadLine();

            }
            foreach (Proveedores item in ltAlterna)
            {
                if (item.noProveedor == noProveedor)
                {
                    ltproveedores.Add(new Proveedores() { nombre = nombre, aPaterno = aPaterno, aMaterno = aMaterno, telefono = telefono, direccion = direccion, CP = CP, mail = mail, RFC = RFC, razonSocial = razonSocial, tipoProveedor = tipoProveedor, noProveedor = noProveedor });
                    Console.WriteLine();
                    Console.WriteLine(">>>>> El registro se edito con exito <<<<<");
                }
                else
                {
                    ltproveedores.Add(item);

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
                Console.WriteLine("     Sistema de Clientes y Proveedores 3221");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("(1).- Nombre");
                Console.WriteLine("(2).- Apellido Paterno");
                Console.WriteLine("(3).- Apellido Materno");
                Console.WriteLine("(4).- Telefono");
                Console.WriteLine("(5).- email");
                Console.WriteLine("(6).- RFC");
                Console.WriteLine("(7).- Dirección");
                Console.WriteLine("(8).- CP");
                Console.WriteLine("(9).- Razon social");
                Console.WriteLine("(10).- Tipo de proveedor");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Seleccione una opcion a editar: ");
                opc = int.Parse(Console.ReadLine());
                val = valida(opc, 10);
            } while (val);
            return opc;

        }
        public static Boolean valida(int opcion, int tamaño)
        {
            if (opcion < 1 || opcion > 10)
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
        public void ConsultaProveedor(int opcBuscar, List<Proveedores> ltProveedores)
        {
            int id;
            string nombre, paterno, materno;
            if (opcBuscar == 1)
            {
                Console.WriteLine("Ingrese el Numero de Proveedor");
                id = int.Parse(Console.ReadLine());
                foreach (Proveedores item in ltProveedores)
                {
                    if (id == item.noProveedor)
                    {
                        Console.WriteLine($"El nombre del Proveedor es: {item.nombre} {item.aPaterno} {item.aMaterno} y con numero de Telefono: {item.telefono} RFC: {item.RFC}, mail {mail}, dirección {item.direccion} {item.CP}, con numero de proveedor: {item.noProveedor},  razon social: {item.razonSocial} y tipo de proveedor: {item.tipoProveedor}");
                    }
                }
            }
            else if (opcBuscar == 2)
            {
                Console.WriteLine("Ingrese el Nombre del Proveedor");
                nombre = Console.ReadLine();
                foreach (Proveedores item in ltProveedores)
                {
                    if (nombre == item.nombre)
                    {
                        Console.WriteLine($"El nombre del Proveedor es: {item.nombre} {item.aPaterno} {item.aMaterno} y con numero de Telefono: {item.telefono} RFC: {item.RFC}, mail {mail}, dirección {item.direccion} {item.CP}, con numero de proveedor: {item.noProveedor},  razon social: {item.razonSocial} y tipo de proveedor: {item.tipoProveedor}");

                    }
                }
            }
            else if (opcBuscar == 3)
            {
                Console.WriteLine("Ingrese el Apellido Paterno del Proveedor");
                paterno = Console.ReadLine();
                foreach (Proveedores item in ltProveedores)
                {
                    if (paterno == item.aPaterno)
                    {
                        Console.WriteLine($"El nombre del Proveedor es: {item.nombre} {item.aPaterno} {item.aMaterno} y con numero de Telefono: {item.telefono} RFC: {item.RFC}, mail {mail}, dirección {item.direccion} {item.CP}, con numero de proveedor: {item.noProveedor},  razon social: {item.razonSocial} y tipo de proveedor: {item.tipoProveedor}");

                    }
                }
            }
            else if (opcBuscar == 4)
            {
                Console.WriteLine("Ingrese el Apellido Materno del Proveedor");
                materno = Console.ReadLine();
                foreach (Proveedores item in ltProveedores)
                {
                    if (materno == item.aMaterno)
                    {
                        Console.WriteLine($"El nombre del Proveedor es: {item.nombre} {item.aPaterno} {item.aMaterno} y con numero de Telefono: {item.telefono} RFC: {item.RFC}, mail {mail}, dirección {item.direccion} {item.CP}, con numero de proveedor: {item.noProveedor},  razon social: {item.razonSocial} y tipo de proveedor: {item.tipoProveedor}");
                    }
                }
            }

        }
    }
}
