using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_claseAbstracta
{
    class Clientes: Base_datos 
    {
        public string Zona { get; set; }
        public int IDcliente { get; set; }
        public void AltaClinte(string nombre, string paterno, string materno, string direccion, string telefono, string mail, string zona, int id,  List<Clientes> ltcliente)
        {
            ltcliente.Add(new Clientes() {nombre=nombre, aPaterno = paterno, aMaterno= materno, direccion = direccion, telefono = telefono, mail = mail, Zona = zona, IDcliente = id });
            
        }

        public void BajaClinte(List<Clientes> ltcliente)
        {
            Console.WriteLine($"INGRESE EL ID DEL CLIENTE A DAR DE BAJA");
            int ID = int.Parse(Console.ReadLine());
            Console.Clear();
            int cont = 0;
            int indice = -1;
            foreach (Clientes item in ltcliente)
            {
                if (item.IDcliente == ID)
                {
                    indice = cont;
                }
                cont++;
            }
            if (indice > -1)
            {
                ltcliente.RemoveAt(indice);
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("    El registro se removio correctamente");
                Console.WriteLine("------------------------------------------------");
            }
            else
            {
                noexiste();
            }
        }

        public void EdicionClinte(List<Clientes> ltcliente)
        {
            List<Clientes> ltAlterna = new List<Clientes>();

            Console.WriteLine("Ingresa la ID del cliente a modificar");
            int ID  = int.Parse(Console.ReadLine());
            int opc = menuEdicionC();
            Console.Clear();
            foreach (Clientes item in ltcliente)
            {
                ltAlterna.Add(item);
                if (item.IDcliente == ID)
                {
                    nombre = item.nombre;
                    aPaterno = item.aPaterno;
                    aMaterno = item.aMaterno;
                    direccion = item.direccion;
                    telefono = item.telefono;
                    mail = item.mail;
                    Zona = item.Zona;
                    IDcliente = item.IDcliente;
                }
            }
            ltcliente.Clear();
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
                Console.WriteLine("Ingresa la nueva Zona del cliente");
                Zona = Console.ReadLine();


            }
            
            foreach (Clientes item in ltAlterna)
            {
                if (item.IDcliente == ID)
                {

                    ltcliente.Add(new Clientes() { nombre = nombre, aPaterno = aPaterno, aMaterno = aMaterno, direccion = direccion, telefono = telefono,  mail = mail, Zona = Zona, IDcliente = IDcliente });
                    Console.Clear();
                    Console.WriteLine(">>>>> El registro se edito con exito <<<<<");

                }
                else
                {
                    ltcliente.Add(item);
                    Console.Clear();
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("            El registro no se edito");
                    Console.WriteLine("------------------------------------------------");
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
                Console.WriteLine("     Sistema de Clientes y Vendedores -OBB-");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("                (1).- Nombre");
                Console.WriteLine("                (2).- Apellido Paterno");
                Console.WriteLine("                (3).- Apellido Materno");
                Console.WriteLine("                (4).- Dirección");
                Console.WriteLine("                (5).- Telefono");
                Console.WriteLine("                (6).- email");
                Console.WriteLine("                (7).- Zona");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Seleccione una opcion a editar: ");
                opc = int.Parse(Console.ReadLine());
                val = valida(opc, 7);
            } while (val);
            return opc;

        }
        public static Boolean valida(int opcion, int tamaño)
        {
            if (opcion < 1 || opcion > 7)
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

        public void ConsultaCliente(int opcBuscar, List<Clientes> ltcliente)
        {
            int id;
            string nombre, paterno, materno;
            if (opcBuscar == 1)
            {
                Console.WriteLine("Ingrese la ID del Cliente");
                id = int.Parse(Console.ReadLine());
                foreach (Clientes item in ltcliente)
                {
                    if (id == item.IDcliente)
                    {
                        Console.Clear();
                        Console.WriteLine($"El nombre del cliente es: {item.nombre} {item.aPaterno} {item.aMaterno}, con numero de Telefono: {item.telefono}, mail {item.mail}, dirección: {item.direccion} en la Zona: {item.Zona}, Con ID: {item.IDcliente}");
                    }
                    else
                    {
                        noexiste();
                    }
                }
            }
            else if (opcBuscar == 2)
            {
                Console.WriteLine("Ingrese el Nombre de Cliente");
                nombre = Console.ReadLine();
                foreach (Clientes item in ltcliente)
                {
                    if (nombre == item.nombre)
                    {
                        Console.Clear();
                        Console.WriteLine($"El nombre del cliente es: {item.nombre} {item.aPaterno} {item.aMaterno}, con numero de Telefono: {item.telefono}, mail {item.mail}, dirección: {item.direccion} en la Zona: {item.Zona}, Con ID: {item.IDcliente}");
                    }
                    else
                    {
                        noexiste();
                    }
                }
            }
            else if (opcBuscar == 3)
            {
                Console.WriteLine("Ingrese el Apellido Paterno del Cliente");
                paterno = Console.ReadLine();
                foreach (Clientes item in ltcliente)
                {
                    if (paterno == item.aPaterno)
                    {
                        Console.Clear();
                        Console.WriteLine($"El nombre del cliente es: {item.nombre} {item.aPaterno} {item.aMaterno}, con numero de Telefono: {item.telefono}, mail {item.mail}, dirección: {item.direccion} en la Zona: {item.Zona}, Con ID: {item.IDcliente}");
                    }
                    else
                    {
                        noexiste();
                    }
                }
            }
            else if (opcBuscar == 4)
            {
                Console.WriteLine("Ingrese el Apellido Materno del Cliente");
                materno = Console.ReadLine();
                foreach (Clientes item in ltcliente)
                {
                    if (materno == item.aMaterno)
                    {
                        Console.Clear();
                        Console.WriteLine($"El nombre del cliente es: {item.nombre} {item.aPaterno} {item.aMaterno}, con numero de Telefono: {item.telefono}, mail {item.mail}, dirección: {item.direccion} en la Zona: {item.Zona}, Con ID: {item.IDcliente}");
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
