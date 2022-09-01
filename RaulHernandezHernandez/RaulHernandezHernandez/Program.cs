using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaulHernandezHernandez
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean val;
            int opc;
            string tipo;
            do
            {
                PEmenu();
                Console.WriteLine("Seleccione una opción");
                opc = int.Parse(Console.ReadLine());
                val = PEvalida(opc, 2);
            } while (val);
            if (opc == 1)
            {
                RHHAlumnos RHH = new RHHAlumnos();
                Console.ReadKey();
            }

            else
            {
                RHHDocentes RHH = new RHHDocentes();
                Console.ReadKey();

            }
        }
        public static void PEmenu()
        {
            Console.Clear();
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine("    PROGRAMA LISTAS ALUMNOS Y DOCENTES");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine("1. Alumnos");
            Console.WriteLine("2. Docentes ");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        }
        public static Boolean PEvalida(int opcion, int tamanio)
        {
            if (opcion < 1 || opcion > tamanio)
            {
                Console.WriteLine("ERROR, esta operacion no es posible ");
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
