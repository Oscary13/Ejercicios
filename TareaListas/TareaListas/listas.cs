using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaListas
{

    class listas
    {
        List<string> ltstring = new List<string>();
        public listas()
        {
            int otra = 0;
            do
            {
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Console.WriteLine("        Menu de Strings");
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Console.WriteLine("(1) para: Alta de strings");
                Console.WriteLine("(2) para: Baja de strings");
                Console.WriteLine("(3) para Edición de strings");
                Console.WriteLine("(4) para  Consulta de strings");
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Console.WriteLine("Ingrese una opcion");
                int opc = int.Parse(Console.ReadLine());
                if (opc == 1) 
                {
                    altaString();
                }
                else if (opc == 2) 
                {

                }
                else if (opc == 3) 
                {

                }
                else if (opc == 4) 
                {
                    consultaString();
                }
                Console.WriteLine("¿Desea regresar al menu?");
                Console.WriteLine("(1) Sí            (2) No");
                otra = int.Parse(Console.ReadLine());
            } while (otra == 1);
            Console.WriteLine("Gracias por utilizar el sistema ");

            Console.ReadKey();
        }
        public void altaString()
        {
            Console.WriteLine("Ingrese la cantidad de strings a agregar:");
            int tamano = int.Parse(Console.ReadLine());

            for (int i = 0; i < tamano; i++)
            {
                Console.WriteLine("Ingrese un string");
                string s = Console.ReadLine();
                ltstring.Add(s);
            }
        }
        public void consultaString()
        {
            foreach (string item in ltstring)
            {
                Console.WriteLine(item);
            }
        }
    }
}
