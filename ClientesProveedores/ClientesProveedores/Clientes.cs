using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesProveedores
{
    class Clientes : Herencia
    {

        public int edad;
        public int noCliente;
        public void AltaClinte(string nombre, string paterno, string materno, string telefono, string rfc, string mail, string direccion, string CP, int noCliente, int Edad, List<Clientes> ltCliente)
        {
            ltCliente.Add(new Clientes() { noCliente = noCliente, nombre = nombre, aPaterno = paterno, aMaterno = materno, direccion = direccion, telefono = telefono, CP = CP, edad = Edad, mail = mail, RFC = rfc });
            //Console.WriteLine($"El nombre del cliente es: {nombre} {aPaterno} {aMaterno}, con numero de Telefono: {telefono} RFC: {RFC}, mail {mail}, dirección {direccion} {CP}, con numero de cliente: {noCliente}, y edad {Edad}");
        }
        public void BajaClinte(List<Clientes> ltCliente)
        {
            Console.WriteLine("INGRESE EL ELEMENTO A DAR DE BAJA");
            int noCliente = int.Parse(Console.ReadLine());
            int cont = 0;
            int indice = -1;
            foreach (Clientes item in ltCliente)
            {
                if (item.noCliente == noCliente)
                {
                    indice = cont;
                }
                cont++;
            }
            if (indice > -1)
            {
                ltCliente.RemoveAt(indice);
            }
            Console.WriteLine(">>>>> El registro se removio correctamente <<<<<");
        }

        public void EdicionClinte(List<Clientes> ltCliente)
        {
            List<Clientes> ltAlterna = new List<Clientes>();

            Console.WriteLine("Ingresa el numero de cliente a modificar");
            int noCliente = int.Parse(Console.ReadLine());
            int opc = menuEdicionC();

            foreach (Clientes item in ltCliente)
            {
                ltAlterna.Add(item);
                if (item.noCliente == noCliente)
                {
                    nombre = item.nombre;
                    aPaterno = item.aPaterno;
                    aMaterno = item.aMaterno;
                    telefono = item.telefono;
                    mail = item.mail;
                    RFC = item.RFC;
                    direccion = item.direccion;
                    CP = item.CP;
                    edad = item.edad;
                }
            }
            ltCliente.Clear();
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
                Console.WriteLine("Ingresa la nueva edad");
                edad = int.Parse(Console.ReadLine());
            }
            foreach (Clientes item in ltAlterna)
            {
                if (item.noCliente == noCliente)
                {

                    ltCliente.Add(new Clientes() { nombre = nombre, aPaterno = aPaterno, aMaterno = aMaterno, telefono = telefono, direccion = item.direccion, CP = CP, edad = edad, mail = mail, RFC = RFC, noCliente = noCliente });
                    Console.WriteLine(">>>>> El registro se edito con exito <<<<<");

                }
                else
                {
                    ltCliente.Add(item);
                }
            }
        }
        public int menuEdicionC()
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
                Console.WriteLine("(9).- Edad");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Seleccione una opcion a editar: ");
                opc = int.Parse(Console.ReadLine());
                val = valida(opc, 9);
            } while (val);
            return opc;

        }
        public void ConsultaCliente(int opcBuscar, List<Clientes> ltClientes)
        {
            int id;
            string nombre, paterno, materno;
            if (opcBuscar == 1)
            {
                Console.WriteLine("Ingrese el Numero de Cliente");
                id = int.Parse(Console.ReadLine());
                foreach (Clientes item in ltClientes)
                {
                    if (id == item.noCliente)
                    {
                        Console.WriteLine($"El nombre del cliente es: {item.nombre} {item.aPaterno} {item.aMaterno}, con numero de Telefono: {item.telefono} RFC: {item.RFC}, mail {item.mail}, dirección {item.direccion} {item.CP}, con numero de cliente: {item.noCliente}, y edad {item.edad}");
                    }
                }
            }
            else if (opcBuscar == 2)
            {
                Console.WriteLine("Ingrese el Nombre de Cliente");
                nombre = Console.ReadLine();
                foreach (Clientes item in ltClientes)
                {
                    if (nombre == item.nombre)
                    {
                        Console.WriteLine($"El nombre del cliente es: {item.nombre} {item.aPaterno} {item.aMaterno}, con numero de Telefono: {item.telefono} RFC: {item.RFC}, mail {item.mail}, dirección {item.direccion} {item.CP}, con numero de cliente: {item.noCliente}, y edad {item.edad}");
                    }
                }
            }
            else if (opcBuscar == 3)
            {
                Console.WriteLine("Ingrese el Apellido Paterno del Cliente");
                paterno = Console.ReadLine();
                foreach (Clientes item in ltClientes)
                {
                    if (paterno == item.aPaterno)
                    {
                        Console.WriteLine($"El nombre del cliente es: {item.nombre} {item.aPaterno} {item.aMaterno}, con numero de Telefono: {item.telefono} RFC: {item.RFC}, mail {item.mail}, dirección {item.direccion} {item.CP}, con numero de cliente: {item.noCliente}, y edad {item.edad}");
                    }
                }
            }
            else if (opcBuscar == 4)
            {
                Console.WriteLine("Ingrese el Apellido Materno del Cliente");
                materno = Console.ReadLine();
                foreach (Clientes item in ltClientes)
                {
                    if (materno == item.aMaterno)
                    {
                        Console.WriteLine($"El nombre del cliente es: {item.nombre} {item.aPaterno} {item.aMaterno}, con numero de Telefono: {item.telefono} RFC: {item.RFC}, mail {item.mail}, dirección {item.direccion} {item.CP}, con numero de cliente: {item.noCliente}, y edad {item.edad}");
                    }
                }
            }


        }
        public static Boolean valida(int opcion, int tamaño)
        {
            if (opcion < 1 || opcion > 9)
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

    }
}
