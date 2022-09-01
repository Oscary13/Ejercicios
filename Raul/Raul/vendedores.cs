using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendedores_pat
{
    class vendedores : @base
    {
        public string rfc { get; set; }
        public string genero { get; set; }
        public string tipo_vendedor { get; set; }

        public void editar1(List<vendedores> ven)
        {
            List<vendedores> v = new List<vendedores>();

            Console.WriteLine("Ingrese el nombre del vendedor a editar");
            string nomm = Console.ReadLine();
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("                  EDITAR");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("1- Nombre");
            Console.WriteLine("2- Apellido paterno");
            Console.WriteLine("3- Apellido materno");
            Console.WriteLine("4- Telfono");
            Console.WriteLine("5- RFC");
            Console.WriteLine("6- Genero");
            Console.WriteLine("7- Tipo de vendedor");
            Console.WriteLine("8- Direccion");
            Console.WriteLine("9- Mail");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("Selecione a editar");
            int opc = int.Parse(Console.ReadLine());
            foreach (vendedores pp in ven)
            {
                v.Add(pp);

            }
            ven.Clear();
            switch (opc)
            {
                case 1:

                    Console.WriteLine("Escribe el nuevo nombre");
                    string nom = Console.ReadLine();
                    foreach (vendedores ap in v)
                    {
                        if (ap.nombre == nomm)
                        {
                            ven.Add(new vendedores()
                            {
                                nombre = nom,
                                apaterno = ap.apaterno,
                                amaterno = ap.amaterno,
                                direc = ap.direc,
                                tel = ap.tel,
                                mail = ap.mail,
                                rfc = ap.rfc,
                                genero = ap.genero,
                                tipo_vendedor = ap.tipo_vendedor
                            });
                        }
                        else
                        {
                            ven.Add(ap);
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Escribe el nuevo apellido paterno");
                    string apaterno = Console.ReadLine();
                    foreach (vendedores ap in v)
                    {
                        if (ap.nombre == nomm)
                        {
                            ven.Add(new vendedores()
                            {
                                nombre = ap.nombre,
                                apaterno = apaterno,
                                amaterno = ap.amaterno,
                                direc = ap.direc,
                                tel = ap.tel,
                                mail = ap.mail,
                                rfc = ap.rfc,
                                genero = ap.genero,
                                tipo_vendedor = ap.tipo_vendedor
                            });
                        }
                        else
                        {
                            ven.Add(ap);
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Escribe el nuevo apellido materno");
                    string amaterno = Console.ReadLine();
                    foreach (vendedores ap in v)
                    {
                        if (ap.nombre == nomm)
                        {
                            ven.Add(new vendedores()
                            {
                                nombre = ap.nombre,
                                apaterno = ap.apaterno,
                                amaterno = amaterno,
                                direc = ap.direc,
                                tel = ap.tel,
                                mail = ap.mail,
                                rfc = ap.rfc,
                                genero = ap.genero,
                                tipo_vendedor = ap.tipo_vendedor
                            });
                        }
                        else
                        {
                            ven.Add(ap);
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("Escribe el nuevo telefono");
                    string telefono = Console.ReadLine();
                    foreach (vendedores ap in v)
                    {
                        if (ap.nombre == nomm)
                        {
                            ven.Add(new vendedores()
                            {
                                nombre = ap.nombre,
                                apaterno = ap.apaterno,
                                amaterno = ap.amaterno,
                                direc = ap.direc,
                                tel = ap.tel,
                                mail = ap.mail,
                                rfc = ap.rfc,
                                genero = ap.genero,
                                tipo_vendedor = ap.tipo_vendedor
                            });
                        }
                        else
                        {
                            ven.Add(ap);
                        }
                    }
                    break;
                case 5:
                    Console.WriteLine("Escribe el nuevo RFC");
                    string rfc = Console.ReadLine();
                    foreach (vendedores ap in v)
                    {
                        if (ap.nombre == nomm)
                        {
                            ven.Add(new vendedores()
                            {
                                nombre = ap.nombre,
                                apaterno = ap.apaterno,
                                amaterno = ap.amaterno,
                                direc = ap.direc,
                                tel = ap.tel,
                                mail = ap.mail,
                                rfc = rfc,
                                genero = ap.genero,
                                tipo_vendedor = ap.tipo_vendedor
                            });
                        }
                        else
                        {
                            ven.Add(ap);
                        }
                    }
                    break;
                case 6:
                    Console.WriteLine("Escribe el nuevo genero");
                    string gen = Console.ReadLine();
                    foreach (vendedores ap in v)
                    {
                        if (ap.nombre == nomm)
                        {
                            ven.Add(new vendedores()
                            {
                                nombre = ap.nombre,
                                apaterno = ap.apaterno,
                                amaterno = ap.amaterno,
                                direc = ap.direc,
                                tel = ap.tel,
                                mail = ap.mail,
                                rfc = ap.rfc,
                                genero = gen,
                                tipo_vendedor = ap.tipo_vendedor
                            });
                        }
                        else
                        {
                            ven.Add(ap);
                        }
                    }
                    break;
                case 7:
                    Console.WriteLine("Escibe el nuevo tipo de vendedor");
                    string tip_ven = Console.ReadLine();
                    foreach (vendedores ap in v)
                    {
                        if (ap.nombre == nomm)
                        {
                            ven.Add(new vendedores()
                            {
                                nombre = ap.nombre,
                                apaterno = ap.apaterno,
                                amaterno = ap.amaterno,
                                direc = ap.direc,
                                tel = ap.tel,
                                mail = ap.mail,
                                rfc = ap.rfc,
                                genero = ap.genero,
                                tipo_vendedor = tip_ven
                            });
                        }
                        else
                        {
                            ven.Add(ap);
                        }
                    }
                    break;
                case 8:
                    Console.WriteLine("Escribe el nuevo direccion");
                    string dir = Console.ReadLine();
                    foreach (vendedores ap in v)
                    {
                        if (ap.nombre == nomm)
                        {
                            ven.Add(new vendedores()
                            {
                                nombre = ap.nombre,
                                apaterno = ap.apaterno,
                                amaterno = ap.amaterno,
                                direc = dir,
                                tel = ap.tel,
                                mail = ap.mail,
                                rfc = ap.rfc,
                                genero = ap.genero,
                                tipo_vendedor = ap.tipo_vendedor
                            });
                        }
                        else
                        {
                            ven.Add(ap);
                        }
                    }
                    break;
                case 9:
                    Console.WriteLine("Escribe el nuevo mail");
                    string maill = Console.ReadLine();
                    foreach (vendedores ap in v)
                    {
                        if (ap.nombre == nomm)
                        {
                            ven.Add(new vendedores()
                            {
                                nombre = ap.nombre,
                                apaterno = ap.apaterno,
                                amaterno = ap.amaterno,
                                direc = ap.direc,
                                tel = ap.tel,
                                mail = maill,
                                rfc = ap.rfc,
                                genero = ap.genero,
                                tipo_vendedor = ap.tipo_vendedor
                            });
                        }
                        else
                        {
                            ven.Add(ap);
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
