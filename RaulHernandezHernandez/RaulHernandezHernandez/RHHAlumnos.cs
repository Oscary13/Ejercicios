using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaulHernandezHernandez
{
    class RHHAlumnos: RHHHerencia
    {
        public static List<RHHHerencia> ltDatos = new List<RHHHerencia>();
        public RHHAlumnos()
        {
            int otra = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Console.WriteLine("            Menu de Alumnos");
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Console.WriteLine("1. Alta de Alumnos ");
                Console.WriteLine("2. Limpiar lista ");
                Console.WriteLine("3. Conteo de elementos de la lista ");
                Console.WriteLine("4. Imprimir lista");
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Console.WriteLine("ingrese la opcion");
                int opc = int.Parse(Console.ReadLine());


                if (opc == 1)
                {
                    RHHAltaa();
                }
                else if (opc == 2)
                {
                    RHHLimpiar();
                }
                else if (opc == 3)
                {
                    RHHContar();
                }
                else if (opc == 4)
                {
                    RHHimprimir();
                }

                Console.WriteLine("Quieres regresar al menu:");
                Console.WriteLine("(1)= SI          (2)= NO");
                otra = int.Parse(Console.ReadLine());

            } while (otra == 1);
            Console.WriteLine("-Gracias por utilizar el programa listas de ALUMNOS-");
            Console.ReadKey();

        }

        public void RHHAltaa()
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
                Console.WriteLine("Escribe la Matricula");
                string Mat = Console.ReadLine();
                Console.WriteLine("Escribe la carrera");
                string carr = Console.ReadLine();
                Console.WriteLine("Escribe el grupo");
                int Grup = int.Parse(Console.ReadLine());

                ltDatos.Add(new RHHHerencia() { Nombre = nombre, aPaterno = AP, aMaterno = AM, telefono = Tel, Matricula = Mat, Carrera = carr, Grupo = Grup });

            }
        }
        public static void RHHimprimir()
        {
            foreach (RHHHerencia item in ltDatos)
            {
                Console.WriteLine("El nombre del alumno es " + item.Nombre + " " + item.aPaterno + " " + item.aMaterno + " con numero de telefono " + item.telefono + ", su numero de cedula es: " + item.cedula + " Numero de IMSS " + item.NoIMMS + ", su numero de materias es: " + item.Nomaterias);
            }
        }

        public static void RHHContar()
        {
            Console.WriteLine("TIENES " + ltDatos.Count() + "ELEMTOS EN TU LISTA");
        }
        public static void RHHLimpiar()
        {
            ltDatos.Clear();
            Console.WriteLine("LISTA VACIA ");
        }



    }
}
