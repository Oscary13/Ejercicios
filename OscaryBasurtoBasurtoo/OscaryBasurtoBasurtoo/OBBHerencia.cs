using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OscaryBasurtoBasurtoo
{
    class OBBHerencia : OBBDatosAlumnoDocente
    {
        List<string> OBBAlumnos = new List<string>();
        List<string> OBBDocentes = new List<string>();
        public string nom;
        public string ApellidoP;
        public string ApellidoM;
        public string Telefono;
        public string mail;
        public void OBBAltaDocente()
        {
            Console.Clear();
            Console.WriteLine($"   Escriba el Nombre del Docente:");
            nom = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"   Apellido Paterno del Docente:");
            ApellidoP = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"   Apellido Materno del Docente:");
            ApellidoM = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"   Escriba el Telefono del Docente:");
            Telefono = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"   Escriba el Email del Docente:");
            mail = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"   Ingrese la Cedula del Docente:");
            Cedula = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"   Ingrese el numero de IMSS del Docenteo:");
            NolMSS = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"   Ingrese el numero de materias del Docente: ");
            NoMaterias = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //Esta funcion añade la fruta que el usuario ingreso a la lista 
            OBBDocentes.Add($"La Cedeula del docente es: {Cedula}, con nombre: {nom} {ApellidoP} {ApellidoM}, su numero de telefono es: {Telefono}, y correo electronico {mail}, Su numero de IMSS es: {NolMSS}, y su numero de Materias es: {NoMaterias}");
        }
        public void OBBAltaAlumno()
        {
            Console.Clear();
            Console.WriteLine($"   Escriba el Nombre del Alumno:");
            nom = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"   Apellido Paterno del Alumno: ");
            ApellidoP = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"   Apellido Materno del Alumno: ");
            ApellidoM = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"   Escriba el Telefono del Alumno: ");
            Telefono = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"   Escriba el Email del Alumno:");
            mail = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"   Ingrese la Matricula del Alumno:");
            Matricula = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"   Ingrese la Carrera del Alumno:");
            Carrera = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"   Ingrese el grupo al que pertenece el Alumno: ");
            Grupo = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //Esta funcion añade la fruta que el usuario ingreso a la lista 
            OBBAlumnos.Add($"La matricula de alumno es : {Matricula}, con Nombre: {nom} {ApellidoP} {ApellidoM}, su numero telefonico es: {Telefono}, y correo electronico: {mail}, Cursando la carrera de: {Carrera}, en el grupo {Grupo} ");
        }
        public void OBBAlumnosConsulta()//Declaración del metodo de consulta frutas (ES EL QUE IMPRIME LOS ELEMTOS DE LA LISTA QUE SE INGRESARÓN ACTUALEMENTE)  
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.WriteLine("LAS LISTAS DE ALUMNOS SON LAS SIGUIENTES:");
            Console.ResetColor();
            Console.WriteLine("-----------------------------------------");
            foreach (string item in OBBAlumnos)//Este ciclo hace que se puedan imprimir todos los elemntos de la lista ingresados por el usuario 
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(item);//Hace que se impriman todos los elemntos de la lista que se guardaron en la varible item
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        public void OBBDocentesConsulta()//Declaración del metodo de consulta frutas (ES EL QUE IMPRIME LOS ELEMTOS DE LA LISTA QUE SE INGRESARÓN ACTUALEMENTE)  
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("LAS LISTAS DE DOCENTES SON LAS SIGUIENTES:");
            Console.ResetColor();
            Console.WriteLine("-----------------------------------------");
            Console.ResetColor();
            foreach (string item in OBBDocentes)//Este ciclo hace que se puedan imprimir todos los elemntos de la lista ingresados por el usuario 
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(item);//Hace que se impriman todos los elemntos de la lista que se guardaron en la varible item
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        public void OBBConteodeElementosAlumno()//Declaración del metodo de borrar frutas(BORRA UNA FRUTA DE LA LISTA) 
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.WriteLine($" TU LISTA TIENE {OBBAlumnos.Count()} ELEMENTOS");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------");

        }
        public void OBBConteodeElementosDocentes()//Declaración del metodo de borrar frutas(BORRA UNA FRUTA DE LA LISTA) 
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.WriteLine($" TU LISTA TIENE {OBBDocentes.Count()} ELEMENTOS");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------");
            

        }
        public void OBBAlumnosBorrar()//Declaración del metodo borrar lista(BORRA TODA LA LISTA INGRESADA) 
        {
            Console.Clear();
            OBBAlumnos.Clear();//Esta función es la que hace que se borre la lista
            Console.WriteLine("------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;Console.WriteLine($"            SE ELIMINO CORRECTAMENTE");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------");
        }
        public void OBBDocentesBorrar()//Declaración del metodo borrar lista(BORRA TODA LA LISTA INGRESADA) 
        {
            Console.Clear();
            OBBDocentes.Clear();//Esta función es la que hace que se borre la lista
            Console.WriteLine("------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"            SE ELIMINO CORRECTAMENTE");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------");
        }
    }
}
