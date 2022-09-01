using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendedores_pat
{
    class clientes : @base
    {
        public string zona { get; set; }
        public int id_cliente { get; set; }

        public void editar1(List<clientes> cli)
        {
            List<clientes> c = new List<clientes>();

            Console.WriteLine("Ingrese el id");
            int idcliente = int.Parse(Console.ReadLine());
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("                 EDITAR");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("1- Nombre");
            Console.WriteLine("2- Apellido paterno");
            Console.WriteLine("3- Apellido materno");
            Console.WriteLine("4- Telfono");
            Console.WriteLine("5- Zona");
            Console.WriteLine("6- Id_cliente");
            Console.WriteLine("7- Direccion");
            Console.WriteLine("8- mail");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("Selecione lo que quiera editar");
            int opc = int.Parse(Console.ReadLine());
            foreach (clientes pp in cli)
            {
                c.Add(pp);

            }
            cli.Clear();
            switch (opc)
            {
                case 1:

                    Console.WriteLine("Escribe el nuevo nombre");
                    string nom = Console.ReadLine();
                    foreach (clientes ap in c)
                    {
                        if (ap.id_cliente == idcliente)
                        {
                            cli.Add(new clientes()
                            {
                                nombre = nom,
                                apaterno = ap.apaterno,
                                amaterno = ap.amaterno,
                                direc = ap.direc,
                                tel = ap.tel,
                                mail = ap.mail,
                                id_cliente = ap.id_cliente,
                                zona = ap.zona
                            });
                        }
                        else
                        {
                            cli.Add(ap);
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Escribe el nuevo apellido paterno");
                    string apaterno = Console.ReadLine();
                    foreach (clientes ap in c)
                    {
                        if (ap.id_cliente == idcliente)
                        {
                            cli.Add(new clientes()
                            {
                                nombre = ap.nombre,
                                apaterno = apaterno,
                                amaterno = ap.amaterno,
                                direc = ap.direc,
                                tel = ap.tel,
                                mail = ap.mail,
                                id_cliente = ap.id_cliente,
                                zona = ap.zona
                            });
                        }
                        else
                        {
                            cli.Add(ap);
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Escribe el nuevo apellido materno");
                    string amaterno = Console.ReadLine();
                    foreach (clientes ap in c)
                    {
                        if (ap.id_cliente == idcliente)
                        {
                            cli.Add(new clientes()
                            {
                                nombre = ap.nombre,
                                apaterno = ap.apaterno,
                                amaterno = amaterno,
                                direc = ap.direc,
                                tel = ap.tel,
                                mail = ap.mail,
                                id_cliente = ap.id_cliente,
                                zona = ap.zona
                            });
                        }
                        else
                        {
                            cli.Add(ap);
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("Escribe el nuevo telefono");
                    string telefono = Console.ReadLine();
                    foreach (clientes ap in c)
                    {
                        if (ap.id_cliente == idcliente)
                        {
                            cli.Add(new clientes()
                            {
                                nombre = ap.nombre,
                                apaterno = ap.apaterno,
                                amaterno = ap.amaterno,
                                direc = ap.direc,
                                tel = ap.tel,
                                mail = ap.mail,
                                id_cliente = ap.id_cliente,
                                zona = ap.zona
                            });
                        }
                        else
                        {
                            cli.Add(ap);
                        }
                    }
                    break;
                case 5:
                    Console.WriteLine("Ingresa la nueva zona");
                    string zonaa = Console.ReadLine();
                    foreach (clientes ap in c)
                    {
                        if (ap.id_cliente == idcliente)
                        {
                            cli.Add(new clientes()
                            {
                                nombre = ap.nombre,
                                apaterno = ap.apaterno,
                                amaterno = ap.amaterno,
                                direc = ap.direc,
                                tel = ap.tel,
                                mail = ap.mail,
                                id_cliente = ap.id_cliente,
                                zona = zonaa
                            });
                        }
                        else
                        {
                            cli.Add(ap);
                        }
                    }
                    break;
                case 6:
                    Console.WriteLine("Ingresa el nuevo id");
                    string id = Console.ReadLine();
                    foreach (clientes ap in c)
                    {
                        if (ap.id_cliente == idcliente)
                        {
                            cli.Add(new clientes()
                            {
                                nombre = ap.nombre,
                                apaterno = ap.apaterno,
                                amaterno = ap.amaterno,
                                direc = ap.direc,
                                tel = ap.tel,
                                mail = ap.mail,
                                id_cliente = ap.id_cliente,
                                zona = ap.zona
                            });
                        }
                        else
                        {
                            cli.Add(ap);
                        }
                    }
                    break;
                case 7:
                    Console.WriteLine("ingresa la nueva direccion");
                    string dir = Console.ReadLine();
                    foreach (clientes ap in c)
                    {
                        if (ap.id_cliente == idcliente)
                        {
                            cli.Add(new clientes()
                            {
                                nombre = ap.nombre,
                                apaterno = ap.apaterno,
                                amaterno = ap.amaterno,
                                direc = dir,
                                tel = ap.tel,
                                mail = ap.mail,
                                id_cliente = ap.id_cliente,
                                zona = ap.zona
                            });
                        }
                        else
                        {
                            cli.Add(ap);
                        }
                    }
                    break;
                case 8:
                    Console.WriteLine("ingresa el nuevo mail");
                    string mail = Console.ReadLine();
                    foreach (clientes ap in c)
                    {
                        if (ap.id_cliente == idcliente)
                        {
                            cli.Add(new clientes()
                            {
                                nombre = ap.nombre,
                                apaterno = ap.apaterno,
                                amaterno = ap.amaterno,
                                direc = ap.direc,
                                tel = ap.tel,
                                mail = mail,
                                id_cliente = ap.id_cliente,
                                zona = ap.zona
                            });
                        }
                        else
                        {
                            cli.Add(ap);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("***Opcion es incorrecta**");
                    break;

            }


        }

    }
}
