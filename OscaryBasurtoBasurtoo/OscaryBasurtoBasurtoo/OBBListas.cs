using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OscaryBasurtoBasurtoo
{
    class OBBListas : OBBHerencia
    {
        public OBBListas()
        {
            int otra = 0; 
            do 
            {
                int op;
                string tipo;
                do
                {
                    Console.Clear();
                    Console.WriteLine("------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("             LISTAS ALUMNOS Y DOCENTES");
                    Console.ResetColor();
                    Console.WriteLine("------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("   1.- ALUMNO");
                    Console.WriteLine("   2.- DOCENTE");
                    Console.ResetColor();
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Seleccione una opcion: ");
                    op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        tipo = "Alumno";
                    }
                    else
                    {
                        tipo = "Docente";
                    }

                } while (op <1  | op > 2);

                Console.Clear();
                Console.WriteLine("------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("             LISTAS ALUMNOS Y DOCENTES");
                Console.ResetColor();
                Console.WriteLine("------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("   (1).- Alta " + tipo);
                Console.WriteLine("   (2).- Limpiar listas " + tipo);
                Console.WriteLine("   (3).- Conteo de elementos de la lista " + tipo);
                Console.WriteLine("   (4).- Imprimir listas " + tipo);
                Console.ResetColor();
                Console.WriteLine("------------------------------------------------");
                Console.Write("Seleccione una opcion: ");
                int opc = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    if (opc == 1) 
                    {
                        OBBAltaAlumno(); 
                    }
                    else if (opc == 2) 
                    {
                        OBBAlumnosBorrar();
                    }
                    else if (opc == 3)
                    {
                        OBBConteodeElementosAlumno();
                    }
                    else if (opc == 4)
                    {
                        OBBAlumnosConsulta();
                    }
                }
                else if (op ==2)
                {
                    if (opc == 1) 
                    {
                        OBBAltaDocente(); 
                    }
                    else if (opc == 2)  
                    {
                        OBBDocentesBorrar(); 
                    }
                    else if (opc == 3)
                    {
                        OBBConteodeElementosDocentes();
                    }
                    else if (opc == 4) 
                    {
                        OBBDocentesConsulta();
                    }

                }
                Console.WriteLine();
                Console.WriteLine("----------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("    Desea realizar otra operación:");
                Console.ResetColor();
                Console.WriteLine("----------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("(1).- SI");
                Console.WriteLine("(2).- no");
                Console.ResetColor();
                otra = int.Parse(Console.ReadLine());
            } while (otra == 1);
            Console.WriteLine("GRACIAS POR UTILIZAR EL SISTEMA  -LISTAS DE ALUMNOS Y DOCENTES-   _ OBB_");
 
        }
        
    }
}
