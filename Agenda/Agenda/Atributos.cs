using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Atributos
    {
        public string nombre;
        public string Apaterno;
        public string Amaterno;
        public string telefono;
        public void EdicionClinte(List<Atributos>ltnuevo)
        {
            Console.Clear();
            List<Atributos> ltAlterna = new List<Atributos>();
            Console.WriteLine("Ingresa el Nombre del contacto");
            string nom2 = Console.ReadLine();
            Console.Clear();
            int opc = menuEdicion();
            foreach (Atributos item in ltnuevo)
            {
                ltAlterna.Add(item);
                if (item.nombre == nom2)
                {
                    nombre = item.nombre;
                    Apaterno = item.Apaterno;
                    Amaterno = item.Amaterno;
                    telefono = item.telefono;
                }
            }
            ltnuevo.Clear();
            Console.Clear();
            if (opc == 1)
            {
                Console.WriteLine("Ingresa el nuevo nombre");
                nombre = Console.ReadLine();
            }
            else if (opc == 2)
            {
                Console.WriteLine("Ingresa el nuevo Apellido Paterno");
                Apaterno = Console.ReadLine();
            }
            else if (opc == 3)
            {
                Console.WriteLine("Ingresa el nuevo Apellido Materno");
                Amaterno = Console.ReadLine();

            }
            else if (opc == 4)
            {
                Console.WriteLine("Ingresa el nuevo Telefono");
                telefono = Console.ReadLine();
            }
            foreach (Atributos item in ltAlterna)
            {
                if (item.nombre == nom2)
                {
                    Console.Clear();
                    ltnuevo.Add(new Atributos() { nombre = nombre, Apaterno = Apaterno, Amaterno = Amaterno, telefono = telefono });
                    Console.WriteLine(">>>>> El registro se edito con exito <<<<<");
                }
                else
                {
                    ltnuevo.Add(item);
                }
            }
        }
        public static int menuEdicion()
        {
            Boolean val;
            int opc;
            do
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("                      EDICIÓN");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("  (1).- Nombre");
                Console.WriteLine("  (2).- Apellido Paterno");
                Console.WriteLine("  (3).- Apellido Materno");
                Console.WriteLine("  (4).- Telefono");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Seleccione una opcion a editar: ");
                opc = int.Parse(Console.ReadLine());
                val = valida3(opc, 4);
            } while (val);
            return opc;

        }
        public static Boolean valida3(int opcion, int tamaño)
        {
            if (opcion < 1 || opcion > 4)
            {
                Console.Clear();
                Console.WriteLine("La opccion seleccionada es invalida........");
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
