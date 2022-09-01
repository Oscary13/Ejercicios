using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaListas
{
    class numeros
    {
        List<int> ltEdades = new List<int>();
        public numeros()
        {
            int otra = 0;
            do
            {
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Console.WriteLine("        Menu de Numeros");
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Console.WriteLine("(1) para: Alta de numeros");
                Console.WriteLine("(2) para: Baja de numeros");
                Console.WriteLine("(3) para Edición de numeros");
                Console.WriteLine("(4) para  Consulta de numeros");
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Console.WriteLine("Ingrese una opcion");
                int opc = int.Parse(Console.ReadLine());
                if (opc == 1) 
                {
                    altaEdades();
                }
                else if (opc == 2) 
                {

                }
                else if (opc == 3) 
                {

                }
                else if (opc == 4)
                {
                    consultaEdades();
                }
                Console.WriteLine("¿Desea regresar al menu?");
                Console.WriteLine("(1) Sí            (2) No");
                otra = int.Parse(Console.ReadLine());
            } while (otra == 1);
            Console.WriteLine("Gracias por utilizar el sistema ");

            Console.ReadKey();
        }
        public void altaEdades()
        {
            Console.WriteLine("Ingrese la cantidad de numero a agregar: ");
            int tamano = int.Parse(Console.ReadLine());

            for (int i = 0; i < tamano; i++)
            {
                Console.WriteLine("Ingrese un numero ");
                int n = int.Parse(Console.ReadLine());
                ltEdades.Add(n);
            }
        }
        public void consultaEdades()
        {
            foreach (int item in ltEdades)
            {
                Console.WriteLine(item);
            }
        }
    }
}
