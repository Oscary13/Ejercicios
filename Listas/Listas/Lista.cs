using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Lista
    {
        List<string> lista4 = new List<string>();
        List<int> lista5 = new List<int>();
        public Lista()
        {
            Console.WriteLine("----------------------------------------------");
            Console.Write("Escribe el nombre de tu lista:  ");
            string nombreLista = Console.ReadLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
            int otra = 0;
            do
            {
                
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"      Menu de {nombreLista}");
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"(1).- Alta de {nombreLista}");
                Console.WriteLine($"(2).- Baja de {nombreLista}");
                Console.WriteLine($"(3).- Edicion de {nombreLista}");
                Console.WriteLine($"(4).- Consulta de {nombreLista}");

                Console.WriteLine();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Ingrese una opción:");
                Console.WriteLine("------------------------------------");
                
                int opc = int.Parse(Console.ReadLine());
                if (opc == 1)
                {
                    Console.WriteLine();
                    alta();
                }
                else if (opc == 2)
                {

                }
                else if (opc == 3)
                {

                }
                else if (opc == 4)
                {
                    Console.WriteLine();
                    consulta();
                }
                Console.WriteLine();
                Console.WriteLine("Desea realizar otra operación:");
                Console.WriteLine("1.- SI");
                Console.WriteLine("2.- no");
                otra = int.Parse(Console.ReadLine());
            } while (otra == 1);
            Console.WriteLine();
            Console.WriteLine("GRACIAS POR UTILIZAR EL SISTEMA OBB....");
            Console.ReadKey();
        }
        int opc2 = 0;
        public void alta()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("De que tipo deseas generar su lista:");
            Console.WriteLine();
            Console.WriteLine("(1).- Strings o palabras");
            Console.WriteLine("(2).- Numeros enteros");
            Console.WriteLine("------------------------------------");
            opc2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.Write("Ingrese la cantidad de elementos que contendra su lista: ");
            int tam = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------------");
            if (opc2 ==1 )
            {
                for (int i = 0; i < tam; i++)
                {
                    Console.WriteLine("Ingrese un elemnto a la lista");
                    string nuevo = Console.ReadLine();
                    lista4.Add(nuevo);
                }
            }
            else if (opc2 == 2)
            {
                for (int i = 0; i < tam; i++)
                {
                    Console.WriteLine("Ingrese un elemnto a la lista");
                    int nuevo = int.Parse(Console.ReadLine());
                    lista5.Add(nuevo);
                }

            }
           

        }
        public void consulta()
        {
            Console.WriteLine("           Esta es tu lista hasta el momento: ");
            Console.WriteLine("----------------------------------------------------------");
            if (opc2 == 1)
            {
               
                foreach (string item in lista4)
                {
                    Console.WriteLine(item);
                }
               
            }
            else if (opc2 == 2)
            {
                foreach (int item in lista5)
                {
                    Console.WriteLine(item);
                }

            }
            Console.WriteLine("----------------------------------------------------------");

        }
    }
}
