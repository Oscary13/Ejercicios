using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_pixis_players
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkRed;Console.WriteLine("           THE PIXS PLAYERS ");
            Console.ForegroundColor = ConsoleColor.White;Console.WriteLine("><><><><><><><><><><><><><><><><><><><");
            Console.ForegroundColor = ConsoleColor.Green;Console.WriteLine("             BIENVENIDO");
            Console.ForegroundColor = ConsoleColor.White;Console.WriteLine("><><><><><><><><><><><><><><><><><><><");
            Console.ForegroundColor = ConsoleColor.White;Console.WriteLine("--------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;Console.Write("----------");
            Console.ForegroundColor = ConsoleColor.DarkBlue;Console.Write("# PRECIONA ENTER #");
            Console.ForegroundColor = ConsoleColor.White;Console.Write("----------");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;Console.WriteLine(  "Para rentar o comprar un videojuego, es necesario verificar algunos de sus datos ");
            Console.ForegroundColor = ConsoleColor.White;Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.Write("¿Eres mayor de edad?");
            Console.Write("  (Si) o (No):  ");
            Console.ForegroundColor = ConsoleColor.Blue; string desicion = Console.ReadLine();
            Console.Clear();
            if (desicion == "Si" | desicion == "si" | desicion == "SI" | desicion == "sI")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("                           ¡Hey! ¡no tan rapido¡");
                Console.WriteLine(" Ahora verificaremos tu edad, ¡Tendras que ingresar datos personales! ");
                Console.WriteLine("                 Descuida; no tienes de que preocuparte");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White; Console.Write(">>>>>>>>>>>>>>>>>>> Preciona");
                Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write(" \"ENTER\" ");
                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("para continuar <<<<<<<<<<<<<<<<<<");
                Console.ReadKey(); Console.Clear();
                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("----------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Ingresa tu nombre completo:");
                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("----------------------------");
                Console.ForegroundColor = ConsoleColor.Blue; String nombre = Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("----------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Ingresa el " + "\"día\"" + " en el que naciste, 2 dijitos:");
                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("----------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Blue; int dia = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("---------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Ingresa el " + "\"mes\"" + " en el que naciste, 2 dijitos:");
                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("---------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Blue; int mes = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Ingresa el " + "\"año\"" + " en el que naciste, 4 dijitos:");
                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-------------------------------------------");

                Console.ForegroundColor = ConsoleColor.Blue; int año = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue; DateTime obb = DateTime.Parse($"{dia}/{mes}/{año}");
                TimeSpan edad = DateTime.Now.Subtract(obb);
                Console.WriteLine("Tu edad es:" + edad.TotalDays/365);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Ingresa tu correo electrónico:");
                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("------------------------------------");
                Console.ForegroundColor = ConsoleColor.Blue; String correo = Console.ReadLine();
                Console.Clear();
                if (edad.TotalDays / 365 >= 18 & edad.TotalDays / 365 <= 80)
                {

                    Console.ForegroundColor = ConsoleColor.White; Console.WriteLine ("          Acceso consedido: ");
                    Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("     \"CLIENTE MAYOR DE EDAD\" ");
                    Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(">>>>>>>>>>>>> ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("\"ENTER\"");
                    Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" <<<<<<<<<<<<<<");
                    Console.ReadKey(); Console.Clear();
                    Console.Write("Buena elcción, ¡tenemos los mejores videojuegos!");
                    Console.WriteLine(" Digite el numero de una de las opciones");
                    Console.WriteLine("");
                    int opciones = 0;
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Blue; Console.Write("(1).- ");
                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("Comprar un videojuego");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Blue; Console.Write("(2).- ");
                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("Rentar un videojuego");
                        int eleccion = int.Parse(Console.ReadLine());
                        if (eleccion == 1)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("----------------------------# CATALAGO #----------------------------");
                            Videojuegos j1 = new Videojuegos();
                            Console.ForegroundColor = ConsoleColor.Green; j1.name = "Grand Theft Auto IV";
                            j1.costo = "$ 1,000";
                            Console.WriteLine("(1): " + j1.name + "                           Costo: " + j1.costo);
                            Videojuegos j2 = new Videojuegos();
                            Console.ForegroundColor = ConsoleColor.Green; j2.name = "The Legend of Zelda: Ocarina of Time";
                            j2.costo = "$ 1,200";
                            Console.WriteLine("(2): " + j2.name + "          Costo: " + j2.costo);
                            Videojuegos j3 = new Videojuegos();
                            Console.ForegroundColor = ConsoleColor.Green; j3.name = "Halo: Combat Evolved";
                            j3.costo = "$ 900";
                            Console.WriteLine("(3): " + j3.name + "                          Costo: " + j3.costo);
                            Videojuegos j4 = new Videojuegos();
                            Console.ForegroundColor = ConsoleColor.Green; j4.name = "Resident Evil 4";
                            j4.costo = "$ 500";
                            Console.WriteLine("(4): " + j4.name + "                               Costo: " + j4.costo);
                            Videojuegos j5 = new Videojuegos();
                            Console.ForegroundColor = ConsoleColor.Green; j5.name = "Grand Theft Auto: San Andreas";
                            j5.costo = "$ 1,500";
                            Console.WriteLine("(5): " + j5.name + "                 Costo: " + j5.costo);
                            Videojuegos j6 = new Videojuegos();
                            Console.ForegroundColor = ConsoleColor.Green; j6.name = "Grand Theft Auto: Vice City";
                            j6.costo = "$ 800";
                            Console.WriteLine("(6): " + j6.name + "                   Costo: " + j6.costo);
                            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("-----------------------------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("      Escribe el numero del videojuego que deseas comprar:");
                            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("------------------------------------------------------------------");

                            int opcion = int.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (opcion)
                            {
                                case 1:
                                    {
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("--------------------------- TIKET DE ACCESO ---------------------------");
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("----------------------------  JUEGO RENTADO:  -------------------------");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("(1): " + j1.name + "           mmm   Costo: " + j1.costo);
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        break;
                                    }
                                case 2:
                                    {

                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("--------------------------- TIKET DE ACCESO ---------------------------");
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("----------------------------  JUEGO RENTADO:  -------------------------");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("(2): " + j2.name + "          Costo: " + j2.costo);
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("--------------------------- TIKET DE ACCESO ---------------------------");
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("----------------------------  JUEGO RENTADO:  -------------------------");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("(3): " + j3.name + "                          Costo: " + j3.costo);
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("--------------------------- TIKET DE ACCESO ---------------------------");
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("----------------------------  JUEGO RENTADO:  -------------------------");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("(4): " + j4.name + "                               Costo: " + j4.costo);
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("--------------------------- TIKET DE ACCESO ---------------------------");
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("----------------------------  JUEGO RENTADO:  -------------------------");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("(5): " + j5.name + "                 Costo: " + j5.costo);
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                      
                                        


                                        break;
                                    }
                                case 6:
                                    {
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("--------------------------- TIKET DE ACCESO ---------------------------");
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("----------------------------  JUEGO RENTADO:  -------------------------");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("(6): " + j6.name + "          Costo: " + j6.costo);
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");

                                        break;
                                    }


                                default:
                                    Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(" ERROR -_- ");
                                    break;
                            }
                        }
                        else if (eleccion == 2)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("----------------------------# CATALAGO #----------------------------");
                            Videojuegos j1 = new Videojuegos();
                            Console.ForegroundColor = ConsoleColor.Blue; j1.name = "Grand Theft Auto IV";
                            j1.costo = "$ 1,000";
                            Console.WriteLine("(1): " + j1.name + "                           Costo: " + j1.costo);
                            Videojuegos j3 = new Videojuegos();
                            Console.ForegroundColor = ConsoleColor.Blue; j3.name = "Halo: Combat Evolved";
                            j3.costo = "$ 900";
                            Console.WriteLine("(2): " + j3.name + "                          Costo: " + j3.costo);
                            Videojuegos j2 = new Videojuegos();
                            Console.ForegroundColor = ConsoleColor.Blue; j2.name = "The Legend of Zelda: Ocarina of Time";
                            j2.costo = "$ 1,200";
                            Console.WriteLine("(3): " + j2.name + "          Costo: " + j2.costo);
                            Videojuegos j4 = new Videojuegos();
                            Console.ForegroundColor = ConsoleColor.Blue; j4.name = "Resident Evil 4";
                            j4.costo = "$ 500";
                            Console.WriteLine("(4): " + j4.name + "                               Costo: " + j4.costo);
                            Videojuegos j6 = new Videojuegos();
                            Console.ForegroundColor = ConsoleColor.Blue; j6.name = "Grand Theft Auto: Vice City";
                            j6.costo = "$ 800";
                            Console.WriteLine("(5): " + j6.name + "                Costo: " + j6.costo);
                            Videojuegos j5 = new Videojuegos();
                            Console.ForegroundColor = ConsoleColor.Blue; j5.name = "Grand Theft Auto: San Andreas";
                            j5.costo = "$ 1,500";
                            Console.WriteLine("(6): " + j5.name + "                 Costo: " + j5.costo);

                            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("Escribe el numero del videojuego que deseas Rentar :");
                            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("------------------------------------------------------------------");



                            int opcion = int.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (opcion)
                            {

                                case 1:
                                    {
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("--------------------------- TIKET DE ACCESO ---------------------------");
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("----------------------------  JUEGO RENTADO:  -------------------------");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("(1): " + j1.name + "            Costo: " + j1.costo);
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                      

                                        break;
                                    }
                                case 2:
                                    {
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("--------------------------- TIKET DE ACCESO ---------------------------");
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("----------------------------  JUEGO RENTADO:  -------------------------");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("(2): " + j3.name + "                          Costo: " + j3.costo);
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");

                                        
                             
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("--------------------------- TIKET DE ACCESO ---------------------------");
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("----------------------------  JUEGO RENTADO:  -------------------------");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("(3): " + j2.name + "          Costo: " + j2.costo);
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");

                                        
                                       

                                        break;
                                    }
                                case 4:
                                    {
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("--------------------------- TIKET DE ACCESO ---------------------------");
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("----------------------------  JUEGO RENTADO:  -------------------------");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("(4): " + j4.name + "                               Costo: " + j4.costo);
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                      


                                        break;
                                    }
                                case 5:
                                    {
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("--------------------------- TIKET DE ACCESO ---------------------------");
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("----------------------------  JUEGO RENTADO:  -------------------------");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("(5): " + j6.name + "                Costo: " + j6.costo);
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        

                                        break;
                                    }
                                case 6:
                                    {
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("--------------------------- TIKET DE ACCESO ---------------------------");
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("----------------------------  JUEGO RENTADO:  -------------------------");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("(6): " + j5.name + "                 Costo: " + j5.costo);
                                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                                        break;
                                    }


                                default:
                                    Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(" ERROR -_- ");
                                    break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("¡OPCION INCORRECTA!  X . X");

                        }

                        double edad2 = edad.TotalDays / 365;
                        int conv = Convert.ToInt32 (edad2);
                        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($" Nombre :{nombre}    Fecha de Nacimiento :{dia}/{mes}/{año} ");
                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine($"                    EDAD DEL CLIENTE:  {conv}                        ");
                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"                   CORREO ELECTRÓNICO : {correo}                    ");
                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("-                     --HORA DE IMPRECION DEL TIKET--                 -");
                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Green; DateTime fh = DateTime.Now;
                        Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine($"                           {fh.ToString()}");
                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-----------------------------------------------------------------------");
                        Console.WriteLine(" ");
                        Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("¿Desea realizar otra compra o renta ;?");
                        Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("(1).- SI                         (2).- NO");
                        opciones = int.Parse(Console.ReadLine());
                        Console.Clear();
                          
                    } while (opciones ==1);
                }
                else if (edad.TotalDays / 365 < 17 & edad.TotalDays / 365 > 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White; Console.WriteLine (       "Acceso denegado:");
                    Console.ForegroundColor = ConsoleColor.White; Console.WriteLine ("-----------------------------");
                    Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("\"CLIENTE MENOR DE EDAD\" =(");
                    Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("------------------------------");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-------------------------");
                    Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("¡EDAD INCORRECTA!  X . X");
                    Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("-------------------------");
                }
               

            }
            else if (desicion == "No" | desicion == "no" | desicion == "nO" | desicion == "NO")
            {
                Console.Write(" -- Puedes solicitar ayuda a un mayor para realizar la renta y/o compra --cc");
                Console.WriteLine("De preferencia tu: ");
                Console.WriteLine(">> Mamá  ;)");
                Console.WriteLine(">> Papá  -_-");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERROR   ");
                Console.WriteLine(" =( ");

            }
            Console.WriteLine("- GRACIAS POR SU COMPRA VUELVA PRONTO -"); 
            Console.ReadKey();


        }
    }
}
