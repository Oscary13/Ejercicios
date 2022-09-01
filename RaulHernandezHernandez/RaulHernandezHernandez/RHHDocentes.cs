using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaulHernandezHernandez
{
    class RHHDocentes : RHHHerencia
    {
        public static List<RHHHerencia> ltDatos = new List<RHHHerencia>();


        public RHHDocentes()
        {
            int otra = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Console.WriteLine("           Menu de Docentes");
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Console.WriteLine("1. Alta de Docente ");
                Console.WriteLine("2. Limpiar lista ");
                Console.WriteLine("3. Conteo de elementos de la lista ");
                Console.WriteLine("4. Imprimir lista");
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Console.WriteLine("ingrese la opción");
                int opc = int.Parse(Console.ReadLine());


                if (opc == 1)
                {
                    RHHDAlta();
                }
                else if (opc == 2)
                {
                    RHHDLimpiar();
                }
                else if (opc == 3)
                {
                    RHHDContar();
                }
                else if (opc == 4)
                {
                    RHHDimprimir();
                }

                Console.WriteLine("Quieres regresar al menu:");
                Console.WriteLine("(1)= SI          (2)= NO");
                otra = int.Parse(Console.ReadLine());

            } while (otra == 1);
            Console.WriteLine("-Gracias por utilizar el programa listas de DOCENTES-");
            Console.ReadKey();

        }

        public void RHHDAlta()
        {
            Console.WriteLine("Cuantos elemntos tendra la lista: ");
            int noElem = int.Parse(Console.ReadLine());
            int Id = 0;

            for (int i = 0; i < noElem; i++)
            {
                if (ltDatos.Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    Id = ltDatos.Count() + 1;
                }
                Console.WriteLine("Escribe el nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("Escribe el apellido paterno");
                string AP = Console.ReadLine();
                Console.WriteLine("Escribe el apellido materno");
                string AM = Console.ReadLine();

                Console.WriteLine("Escribe el telefono");
                string Tel = Console.ReadLine();
                Console.WriteLine("Escribe la cedula");
                string Ced = Console.ReadLine();
                Console.WriteLine("Escribe el Numero de IMSS");
                int Imss = int.Parse(Console.ReadLine());
                Console.WriteLine("Escribe el numero de materias");
                int Materias = int.Parse(Console.ReadLine());

                ltDatos.Add(new RHHHerencia() { Nombre = nombre, aPaterno = AP, aMaterno = AM, telefono = Tel, cedula = Ced, NoIMMS = Imss, Nomaterias = Materias });

            }
        }
        public static void RHHDLimpiar()
        {
            ltDatos.Clear();
        }
        public static void RHHDimprimir()
        {
            foreach (RHHHerencia item in ltDatos)
            {
                Console.WriteLine("Los datos son  con nombre " + item.Nombre + " " + item.aPaterno + " " + item.aMaterno + " y numero de telefono " + item.telefono + " Numero de cedula " + item.cedula + " Numero de IMSS " + item.NoIMMS + " Numero de materias" + item.Nomaterias);
            }
        }
        public static void RHHDContar()
        {
            Console.WriteLine("el numero de docentes en la lista es de " + ltDatos.Count);
        }

    }
}
