using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen3_OscaryBasurtoBasurto
{
    class Program
    {
        public static List<OscaryBasurtoBasurto> ltdatos = new List<OscaryBasurtoBasurto>();

        static void Main(string[] args)
        {
            int otra;
            do
            {
                Console.WriteLine("Bienbenido al sistema de ordenamiento");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("(1).- Alta");
                Console.WriteLine("(2).- Imprimir");
                Console.WriteLine("(3).- Ordenar");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("(SELECCIONE UNA OPCION");
                int opc = int.Parse(Console.ReadLine());
                if (opc == 1)
                {
                    alta();
                }
                else if (opc == 2)
                {
                    imprimir();
                }
                else if (opc == 3)
                {
                    ordenar();
                }
                else
                {
                    Console.WriteLine("Opcion incorrecra.......");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" Quieres hacer otra operación ");
                Console.WriteLine("           (1): SI ");
                Console.WriteLine("           (2): NO ");
                otra = int.Parse(Console.ReadLine());
            } while (otra == 1);


            Console.ReadKey();


        }
        public static void alta()
        {
            int num;
            Console.WriteLine("    ¿Cuantos registros quieres realizar?");
            Console.WriteLine("------------------------------------------------");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Ingresa la matricula:");
                int matricula = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el nombre:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingresa el apellido paterno:");
                string apaterno = Console.ReadLine();
                Console.WriteLine("Ingresa el apellido materno:");
                string amaterno = Console.ReadLine();
                Console.WriteLine("Ingresa la edad:");
                int edad = int.Parse(Console.ReadLine());
                ltdatos.Add(new OscaryBasurtoBasurto() { matricula = matricula, nombre = nombre, apaterno = apaterno, amaterno = amaterno, edad = edad });
                Console.WriteLine("----------------------------------------------");
            }
        }
        public static void imprimir()
        {
            Console.WriteLine("DATOS REGOSTRADOS:");
            Console.WriteLine("-------------------");
            foreach (OscaryBasurtoBasurto item in ltdatos)
            {
                Console.WriteLine($"MATRICULA: {item.matricula} NOMBRE: {item.nombre} APELLIDO PATERNO: {item.apaterno}  APELLIDO MATERNO: {item.amaterno} EDAD: {item.edad}");
            }
        }
        public static void ordenar()
        {
            int[] arraynum = new int[10];

            foreach (OscaryBasurtoBasurto item in ltdatos)
            {
                for (int i = 0; i < ltdatos.Count; i++)
                {
                    arraynum[i] = item.matricula;
                }

            }
            string cadena = "";
            Console.WriteLine("             MATRICULAS ORDENADOS");
            Console.WriteLine("----------------------------------------------");
            foreach (var item2 in arraynum)
            {
                cadena = cadena + "         " + item2;
            }
            Console.WriteLine(cadena);
        }



    }
}
