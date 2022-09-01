using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> midiccionario = new Dictionary<int, string>();
            Hashtable Tabla = new Hashtable(midiccionario);
            int aa;
            do
            {
                Console.Clear();
                Console.WriteLine("----------------------- Menu Tablas Hash -----------------------");
                Console.WriteLine("(1).- Insertar Elemento a la Tablas Hash ");
                Console.WriteLine("(2).- Imprimir");
                Console.WriteLine("(3).- Borrar ");
                Console.WriteLine("----------------------------------------------------------------");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Cuantas personas desea ingresar");
                        int cuantos = int.Parse(Console.ReadLine());
                        Console.Clear();
                        for (int i = 0; i < cuantos; i++)
                        {
                            Console.WriteLine("Ingrese una Llave primaria elemento");
                            int LLp = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el nombre de la persona");
                            string nombre = Console.ReadLine();
                            Tabla.Add(LLp, nombre);



                        }


                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.WriteLine("                     LOS DATOS INGRESADOS SON:");
                        Console.WriteLine("----------------------------------------------------------------");

                        foreach (DictionaryEntry elemento in Tabla)
                        {
                            Console.WriteLine($"Llave Primaria: {elemento.Key} Nombre: {elemento.Value}");
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Ingresa la llave primaria del elemento que desea borrar");
                        int borrar = int.Parse(Console.ReadLine());
                        Tabla.Remove(borrar);
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.WriteLine("                 ELEMNTO BORRADO CORRECTAMENTE");
                        Console.WriteLine("----------------------------------------------------------------");
                        break;

                }
                Console.WriteLine("");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("Desea realizar otra opereción");
                Console.WriteLine("(1).- SI");
                Console.WriteLine("(2).- NO");
                Console.WriteLine("----------------------------------------------------------------");
                aa = int.Parse(Console.ReadLine());
            } while (aa == 1);

            Console.ReadKey();
        } 
    }
}
