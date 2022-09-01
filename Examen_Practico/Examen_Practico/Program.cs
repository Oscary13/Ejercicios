using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Practico
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> comunistasOBB = new Stack<string>();
            Stack < string> MES = new Stack<string>();
            int opcion, x;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Yellow;  Console.WriteLine("|     BIENVENIDO A LA PILA DE VENTAS DE LOS COMUNISTAS     |");
                    Console.ResetColor();
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("|            SELECCIONA UNA OPCIÓN QUE REQUIERAS :         |");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("| (1).- AGREGAR COMUNISTAS A LA PILA                       |");
                    Console.WriteLine("| (2).- MOSTRAR PILA DE COMUNISTAS AGREGADOS               |");
                    Console.WriteLine("| (3).- VACIAR LA PILA                                     |");
                    Console.WriteLine("------------------------------------------------------------");
                    opcion = int.Parse(Console.ReadLine());
                } while (opcion < 1 | opcion > 3);

                switch (opcion)
                {
                    case 1:
                        agregarcomunista(ref comunistasOBB, ref MES);
                        break;
                    case 2:
                        mostrar(comunistasOBB,MES);
                        break;
                    case 3:
                        Vaciar(comunistasOBB, MES);
                        break;
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("---------------------------------------------");
                Console.WriteLine(" DESEAS REGRESAR AL MENU: ");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("(1).- SI");
                Console.WriteLine("(2).- NO");
                Console.ResetColor();
                x = int.Parse(Console.ReadLine());
            } while (x == 1);
        }
        static void agregarcomunista(ref Stack<string> comunistasOBB, ref Stack<string> MES)
        {
            int v1;
            int v2;
            int v3;
            int v4;
            int v5;
            double promedioVentas;
            Console.Clear();
            if (MES.Count == 0)
            {
                Console.WriteLine("-----------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;  Console.WriteLine("ESCRIBE EL NOMBRE DEL MES: ");
                Console.ResetColor();
                Console.WriteLine("-----------------------------------------");
                string mes = Console.ReadLine();
                MES.Push($"VENTAS CORRESPONDIENTES AL MES DE : {mes}");
            }
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("ESCRIBE EL NUMERO DE COMUNISTAS QUE AGREGARAS:");
            Console.ResetColor();
            Console.WriteLine("-------------------------------------------------");
            int comunista = int.Parse(Console.ReadLine());
            for (int i = 0; i < comunista; i++)
            {

                Console.Clear();
                Console.WriteLine("-------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"  Ingresa las ventas del comunista {i+1}:");
                Console.ResetColor();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"  No. Ventas de Abarrotes :  ");
                v1 = int.Parse(Console.ReadLine());
                Console.WriteLine($"  No. Ventas de Licores :  ");
                v2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"  No. Ventas de Bebidas :  ");
                v3 = int.Parse(Console.ReadLine());
                Console.WriteLine($"  No. Ventas de Materias primas :  ");
                v4 = int.Parse(Console.ReadLine());
                Console.WriteLine($"  No. Ventas de Electronicos :");
                v5 = int.Parse(Console.ReadLine());
                string R= "";
                string R2= "";
                if (v1 > v2 & v1 > v3 & v1 > v4 & v1 > v5)
                {
                    R = $"La venta MAS ALTA fue _Abarrotes_ con : {v1} ventas";
                }
                else if (v2 > v1 & v2 > v3 & v2 > v4 & v2 > v5)
                {
                    R = $"La venta MAS ALTA fue _Licores_ con : {v2} ventas";
                }
                else if (v3 > v1 & v3 > v2 & v3 > v4 & v3 > v5)
                {
                    R = $"La venta MAS ALTA fue _Bebidas_ con : {v3} ventas";

                }
                else if (v4 > v1 & v4 > v2 & v4 > v3 & v4 > v5)
                {
                    R = $"La venta MAS ALTA fue _Materias primas_ con : {v4} ventas";

                }
                else if (v5 > v1 & v5 > v2 & v5 > v3 & v5 > v4)
                {
                    R = $"La venta MAS ALTA fue _Electronicos_ con : {v5} ventas";
                }
                else
                {
                    R2 = " Tienes ventas ALTAS iguales";
                }
                if (v1 < v2 & v1 < v3 & v1 < v4 & v1 < v5)
                {
                    R2 = $"La venta MAS BAJA fue _Abarrotes_ con : {v1} ventas";

                }
                else if (v2 < v1 & v2 < v3 & v2 < v4 & v2 < v5)
                {
                    R2 = $"La venta MAS BAJA fue _Licores_ con : {v2} ventas";

                }
                else if (v3 < v1 & v3 < v2 & v3 < v4 & v3 < v5)
                {
                    R2 = $"La venta MAS BAJA fue _Bebidas_ con : {v3} ventas";

                }
                else if (v4 < v1 & v4 < v2 & v4 < v3 & v4 < v5)
                {
                    R2 = $"La venta MAS BAJA fue _Materias primas_ con : {v4} ventas";

                }
                else if (v5 < v1 & v5 < v2 & v5 < v3 & v5 < v4)
                {
                    R2 = $"La venta MAS BAJA fue _Electronicos_ con : {v5} ventas";

                }
                else
                {
                    R2 = " Tienes ventas BAJAS iguales";
                }
                promedioVentas = (v1 + v2 + v3 + v4 + v5)/5;
                comunistasOBB.Push($"El promedio de ventas del Comunista {i+1} es de {Math.Round(promedioVentas, 1)} ventas. {R}. {R2}");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(">>>>> PRECIONA ENTER PARA CONTINUAR <<<<<");
            Console.ResetColor();
            Console.ReadKey();
        }
        static void mostrar (Stack<string> comunistasOBB, Stack<string> MES)
        {
            Console.Clear();
            if (MES.Count > 0)
            {
                foreach (string item in MES)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("----------------------------------------");
                    Console.WriteLine(item);
                    Console.WriteLine("----------------------------------------");
                    Console.ResetColor();
                }
            }

            if (comunistasOBB.Count > 0)
            {
                foreach (string item in comunistasOBB)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine(item);
                }       
            }
            else
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("                  LA PILA ESTA VACIA :( ");
                Console.ResetColor();
                Console.WriteLine("----------------------------------------------------------");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(">>>>> PRECIONA ENTER PARA CONTINUAR <<<<<");
            Console.ResetColor();
            Console.ReadKey();
        }
        static void Vaciar(Stack<string> comunistasOBB, Stack<string> MES)
        {
            Console.Clear();
            comunistasOBB.Clear();
            MES.Clear();
            Console.WriteLine("--------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("SE ELIMINO LA PILA CORRECTAMENTE");
            Console.WriteLine("--------------------------------");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(">>>>> PRECIONA ENTER PARA CONTINUAR <<<<<");
            Console.ResetColor();
            Console.ReadKey();
        }

    }
}
