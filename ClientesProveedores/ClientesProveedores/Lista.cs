using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesProveedores
{
    class Lista
    {
        List<string> lFrutas = new List<string>(); // Creamos la lista de frutas 
        public Lista() // Declaración de un metodo de construccion 
        {
            int otra = 0; //Declaración de la variable para prefuntar si quiere realizar otra operacion
            do //Inicio del Ciclo do (elque hace que se repita)
            {
                Console.Clear(); //Limpia lo que esta en pantalla 
                Console.WriteLine("------------------------"); //Se manda a pantalla guiones medios 
                Console.WriteLine("    Menu de Frutas"); //se manda a pantalla el titulo del menu
                Console.WriteLine("------------------------"); // Se manda a pantalla guiones medios 
                Console.WriteLine("1.- Alta de frutas"); //Se manda a pantalla la opción de alta frutas
                Console.WriteLine("2.- Baja de frutas"); //Se manda a pantalla la opción de baja frutas 
                Console.WriteLine("3.- Edicion de frutas"); //Se manda a pantalla la opción Edicion de frutas 
                Console.WriteLine("4.- Consulta de frutas"); //Se manda a pantalla la opción Consulta de frutas 
                Console.WriteLine("5.- Borrar lista"); //Se manda a pantalla la opción  Borrar lista
                Console.WriteLine("Ingrese una opción:"); //Solicitamos que el usuario ingrese el numero de unas de las opciones 
                Console.WriteLine("------------------------"); //Se manda a pantalla guiones medios 
                int opc = int.Parse(Console.ReadLine()); //Se guarda la opción que el alumno ingrese 
                if (opc == 1) //Condición que se ejerce si el usuario ingresa el numero 1 
                {
                    altafrutas(); //Se hace el llamado al metodo alta de frutas O
                }
                else if (opc == 2) //Condición que se ejerce si el usuario ingresa el numero 2 
                {
                    borrarfruta();//Se hace el llamado al metodo Borrar frutas 
                }
                else if (opc == 3)//Condición que se ejerce si el usuario ingresa el numero 3
                {
                    edicion();//Se hace el llamado al metodo Edicion
                }
                else if (opc == 4)//Condición que se ejerce si el usuario ingresa el numero 4 
                {
                    consultaFrutas();//Se hace el llamado al metodo consulta de frutas 
                }
                else if (opc == 5)//Condición que se ejerce si el usuario ingresa el numero 5 
                {
                    borrarLista();//Se hace el llamado al metodo Borrar la lista 
                }
                Console.WriteLine("Desea realizar otra operación:");//Se manda a pantalla la pregunta "si desea hacer otra operación" 
                Console.WriteLine("1.- SI");//Se manda a pantalla la opcion si
                Console.WriteLine("2.- no");//Se manda a pantalla la opcion no
                otra = int.Parse(Console.ReadLine());//Se guarda  la opcion de la pregunta "si desea hacer otra operación"
            } while(otra == 1);//Se cierra el Ciclo do (elque hace que se repita)
            Console.WriteLine("Gracias por utilizar frutas....");//Se manda a pantalla el mensaje de " gracias por utilizar el programa 
            Console.ReadKey();//Esta opción hace que se detenga el proceso hasta que preciones una tecla   
        }
        public void altafrutas()//Declaración del metodo de alta Frutas ( INGRESA FRUTAS A LA LISTA)
        {
            Console.WriteLine("Ingresa la cantidad de frutas a agregar");//Se solicita al usuario que ingrese la cantidad de objetos que itroducira a la lista 
            int tam = int.Parse(Console.ReadLine());//Se guarda el numero de veces que se introducira una fruta a la lista 
            for (int i = 0; i < tam; i++)//Se inicia el ciclo que pide al usuario que ingrese una fruta y se repite conforme el numero que el usuario ingrese
            {
                Console.WriteLine("Ingrese la fruta");//Se pide al usuario que ingrese el nombre de una fruta 
                string frut = Console.ReadLine();//Se guarda y se lee el nombre de las fruta que el usuario ingreso 
                lFrutas.Add(frut);//Esta funcion añade la fruta que el usuario ingreso a la lista 
            }
           
        }
        
        public void consultaFrutas()//Declaración del metodo de consulta frutas (ES EL QUE IMPRIME LOS ELEMTOS DE LA LISTA QUE SE INGRESARÓN ACTUALEMENTE)  
        {
            foreach (string item in lFrutas)//Este ciclo hace que se puedan imprimir todos los elemntos de la lista ingresados por el usuario 
            {
                Console.WriteLine(item);//Hace que se impriman todos los elemntos de la lista que se guardaron en la varible item
            }
        }
        public void borrarfruta()//Declaración del metodo de borrar frutas(BORRA UNA FRUTA DE LA LISTA) 
        {
            int cont = lFrutas.Count();//Se define un contador (Su funcion es contar cuantos elemtos se ingresaron a la lista)
            Console.WriteLine("Que fruta desea eliminar de la lista");// Se le pregunta al usuario cual es la fruta que eliminara 
            string frut = Console.ReadLine();// Se lee y guarda la fruta que el usuario quiere eliminar 

            lFrutas.Remove(frut);//Esta funcion es la que elimina la fruta de la lista 
            if (cont > lFrutas.Count)// Este if lo que hace es verificar si la fruta que ingreso el usuario existe en la lista para poderla borrar y manda un mensaje 
            {
                Console.WriteLine();// Se imprime un salto de linea 
                Console.WriteLine("--------------------------------------------------");//Se manda a pantalla guiones medios 
                Console.WriteLine("El elemento de la lista se elimino correctamente: ");//Se manda a pantalla el mensaje de que el elemento de la lista se borro correctamente 
                Console.WriteLine("--------------------------------------------------");//Se manda a pantalla guiones medios 
                Console.WriteLine();

            }
            else//Este else lo que hace es que si la fruta que ingreso el usuario no existe en la lista que ingreso le mande un mensaje 
            {
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");//Se manda a pantalla guiones medios 
                Console.WriteLine("Error :(      Este elemnto no existe en la lista: ");//Se manda a pantalla el mensaje de que el elemento de la lista no existe y no se borro 
                Console.WriteLine("--------------------------------------------------");//Se manda a pantalla guiones medios 
                Console.WriteLine();
            }
        }
        public void borrarLista()//Declaración del metodo borrar lista(BORRA TODA LA LISTA INGRESADA) 
        {
            lFrutas.Clear();//Esta función es la que hace que se borre la lista
        }
        public void edicion()//Declaración del metodo edición frutas(BORRA UNA FRUTA Y LA REMPLAZA) 
        {
            List<string> lFedit = new List<string>();//Declaracion de una lista temporal que nos servira para remplazar el elemento de la lista
            int existe = 0;// Se asigna una variable que se utilizara para verificar si la fruta que ingreso  el usuario existe en la lista 
            Console.WriteLine("Ingrese la fruta a editar");// Se le pide al usuario que ingrese la fruta que eliminara 
            string fruta = Console.ReadLine();//Se leé y guarda la fruta que ingreso el usuario
            
            foreach ( string item in lFrutas) //Ciclo para la verificacion de que la futa ingresada existe en la lista
            {
                if (fruta == item)//Este if verifica si la futa ingresada es coincide con alguna de la lista ya existente 
                {
                    existe = 1;//La comparación es correcta y se le da valor a nuestra variable
                }
            }
            if (existe == 1)// Verifica si se le asigno valor a nuetra variable que nos indica que la fruta ingresada y la existente coinciden 
            {
                Console.WriteLine("Ingrese Nueva");//Se manda a pantalla que el usuario ingrese La fruta nueva
                string Nfruta = Console.ReadLine();//Se leé y guarda la fruta nueva que ingreso el usuario 
                foreach (string item in lFrutas)//Ciclo que hace que nuestra fruta nueva sea añadida 
                {
                    if (item == fruta)//Este if compara si nuestra fruta es igual o no a item
                    {
                        lFedit.Add(Nfruta);//Se  añade la nueva fruta a la lista 
                    }
                    else
                    {
                        lFedit.Add(item);// Se Añade el itema la lista
                    }
                }
                lFrutas.Clear();//Borra la lista 
                foreach (string item in lFedit)//Este ciclo es el que permite añadir el item a la lista 
                {
                    lFrutas.Add(item);//Se añade el item a la lista 
                }
            }
            else//Este else hace que si no coinciden  la fruta ingresada y la existente mande un mensaje 
            {
                Console.WriteLine("La fruta no existe");// se imprime en pantalla el mensaje de que la fruta que ingreso no existe 
            }
        }
    }
}
