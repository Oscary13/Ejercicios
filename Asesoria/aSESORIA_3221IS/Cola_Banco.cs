using System;
using System.Collections;
using System.Text;

namespace aSESORIA_3221IS
{
    class Cola_Banco
    {
        Queue fila = new Queue();
        Queue caja1 = new Queue();
        Queue caja2 = new Queue();
        
        public void menu()
        {
            int opcion, respuesta;

            do
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("                   MENU");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("   (1).- ASIGNAR FICHA");
                Console.WriteLine("   (2).- ATENDIDA");
                Console.WriteLine("   (3).- MOSTRAR FILA");
                Console.WriteLine("   (4).- ELIMINAR DE CAJA 1");//COLA ------DESENCOLAR
                Console.WriteLine("   (5).- ELIMINAR DE CAJA 2");//COLA ------DESENCOLAR
                Console.WriteLine("---------------------------------------");
                opcion = int.Parse(Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        //metodo asigne ficha
                        Console.Clear();
                        asignar_ficha(ref fila);
                        break;
                    case 2:
                        //metodo atienda al cliente
                        Console.Clear();
                        atender(ref fila);
                        break;
                    case 3:
                        //metodo muestre la fila
                        Console.Clear();
                        mostrar(fila);
                        break;
                    case 4:
                        //metodo Desencolar caja 1
                        Console.Clear();
                        desencolar_eliminarcaja1(ref caja1);
                        break;
                    case 5:
                        //metodo Desencolar caja 2
                        Console.Clear();
                        desencolar_eliminarcaja2(ref caja2);
                        break;
                    default:
                        Console.WriteLine("NO EXISTE ESA OPCIÓN");
                        break;

                }
                Console.WriteLine("-----------------------------");
                Console.WriteLine(" ¿QUIERES REGRESAR AL MENU?");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("         (1) .- SI");
                Console.WriteLine("         (2) .- NO");
                respuesta = int.Parse(Console.ReadLine());
            } while (respuesta == 1);
        }
        public void asignar_ficha(ref Queue cola)
        {
            String num_ficha = ficha();
            cola.Enqueue(num_ficha);
            Console.WriteLine("LA FICHA ASIGNADA ES: "+num_ficha );
        }

        public string ficha()
        {
            Random aleatorio = new Random();
            string letra = "BIS-";
            int numero = aleatorio.Next(1, 20);
            string num_ficha = letra + numero.ToString();
            return num_ficha;
        }

        public void atender(ref Queue cola)
        {
            if(cola.Count>0)
            {
                cajero(ref caja1,ref caja2, ref cola);
            }
            else
            {
                Console.WriteLine("LA COLA ESTA VACIA");
            }
        }

        public void cajero(ref Queue caja1, ref Queue caja2,ref Queue cola)
        {
            if(caja1.Count==0)
            {
                string elemento;
                elemento = cola.Dequeue().ToString();
                Console.WriteLine("LA FICHA ATENDIDA ES: " + elemento);
                Console.WriteLine("EN LA CAJERO 1");
                caja1.Enqueue(elemento);
            }
            else
            {
                if(caja2.Count==0)
                {
                    string elemento;
                    elemento = cola.Dequeue().ToString();
                    Console.WriteLine("LA FICHA ATENDIDA ES: " + elemento);
                    Console.WriteLine("EN LA CAJERO 2");
                    caja2.Enqueue(elemento);
                }
                else Console.WriteLine("CAJEROS OCUPADOS");
            }
        }


        public void mostrar(Queue cola)
        {
            Console.WriteLine("----  LA FILA  ----");
            foreach(string dato in cola)
            {
                Console.Write(dato +"     ");
                Console.WriteLine();
            }
        }


        public string desencolar_eliminarcaja1(ref Queue caja1)
        {

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("  SE ELIMINO CORRECTAMENTE LA CAJA 1 ");
            Console.WriteLine("---------------------------------------");
            string elemento = caja1.Dequeue().ToString();
            return elemento;
        }
        public string desencolar_eliminarcaja2(ref Queue caja2)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("  SE ELIMINO CORRECTAMENTE LA CAJA 2 ");
            Console.WriteLine("---------------------------------------");
            string elemento = caja2.Dequeue().ToString();
            return elemento;
        }


    }

    

}
