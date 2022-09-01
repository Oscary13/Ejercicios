using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaGenericaDobleOBB
{
    class ListaGenericaDoble
    {
        class Nodo
        {
            public int info;
            public Nodo ant, sig;
        }

        private Nodo raiz;

        public ListaGenericaDoble()
        {
            raiz = null;
        }

        void Insertar(int pos, int x)
        {
            if (pos <= Cantidad() + 1)
            {
                Nodo nuevo = new Nodo();
                nuevo.info = x;
                if (pos == 1)
                {
                    nuevo.sig = raiz;
                    if (raiz != null)
                        raiz.ant = nuevo;
                    raiz = nuevo;
                }
                else if (pos == Cantidad() + 1)
                {
                    Nodo reco = raiz;
                    while (reco.sig != null)
                    {
                        reco = reco.sig;
                    }
                    reco.sig = nuevo;
                    nuevo.ant = reco;
                    nuevo.sig = null;
                }
                else
                {
                    Nodo reco = raiz;
                    for (int f = 1; f <= pos - 2; f++)
                        reco = reco.sig;
                    Nodo siguiente = reco.sig;
                    reco.sig = nuevo;
                    nuevo.ant = reco;
                    nuevo.sig = siguiente;
                    siguiente.ant = nuevo;
                }
            }
        }

        public int Extraer(int pos)
        {
            if (pos <= Cantidad())
            {
                int informacion;
                if (pos == 1)
                {
                    informacion = raiz.info;
                    raiz = raiz.sig;
                    if (raiz != null)
                        raiz.ant = null;
                }
                else
                {
                    Nodo reco;
                    reco = raiz;
                    for (int f = 1; f <= pos - 2; f++)
                        reco = reco.sig;
                    Nodo prox = reco.sig;
                    reco.sig = prox.sig;
                    Nodo siguiente = prox.sig;
                    if (siguiente != null)
                        siguiente.ant = reco;
                    informacion = prox.info;
                }
                return informacion;
            }
            else
                return int.MaxValue;
        }

        public void Borrar(int pos)
        {
            if (pos <= Cantidad())
            {
                if (pos == 1)
                {
                    raiz = raiz.sig;
                    if (raiz != null)
                        raiz.ant = null;
                }
                else
                {
                    Nodo reco;
                    reco = raiz;
                    for (int f = 1; f <= pos - 2; f++)
                        reco = reco.sig;
                    Nodo prox = reco.sig;
                    prox = prox.sig;
                    reco.sig = prox;
                    if (prox != null)
                        prox.ant = reco;
                }
            }
        }

        public void Intercambiar(int pos1, int pos2)
        {
            if (pos1 <= Cantidad() && pos2 <= Cantidad())
            {
                Nodo reco1 = raiz;
                for (int f = 1; f < pos1; f++)
                    reco1 = reco1.sig;
                Nodo reco2 = raiz;
                for (int f = 1; f < pos2; f++)
                    reco2 = reco2.sig;
                int aux = reco1.info;
                reco1.info = reco2.info;
                reco2.info = aux;
            }
        }

        public int Mayor()
        {
            if (!Vacia())
            {
                int may = raiz.info;
                Nodo reco = raiz.sig;
                while (reco != null)
                {
                    if (reco.info > may)
                        may = reco.info;
                    reco = reco.sig;
                }
                return may;
            }
            else
                return int.MaxValue;
        }

        public int PosMayor()
        {
            if (!Vacia())
            {
                int may = raiz.info;
                int x = 1;
                int pos = x;
                Nodo reco = raiz.sig;
                while (reco != null)
                {
                    if (reco.info > may)
                    {
                        may = reco.info;
                        pos = x;
                    }
                    reco = reco.sig;
                    x++;
                }
                return pos;
            }
            else
                return int.MaxValue;
        }

        public int Cantidad()
        {
            int cant = 0;
            Nodo reco = raiz;
            while (reco != null)
            {
                reco = reco.sig;
                cant++;
            }
            return cant;
        }

        public bool Ordenada()
        {
            if (Cantidad() > 1)
            {
                Nodo reco1 = raiz;
                Nodo reco2 = raiz.sig;
                while (reco2 != null)
                {
                    if (reco2.info < reco1.info)
                    {
                        return false;
                    }
                    reco2 = reco2.sig;
                    reco1 = reco1.sig;
                }
            }
            return true;
        }

        public bool Existe(int x)
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                if (reco.info == x)
                    return true;
                reco = reco.sig;
            }
            return false;
        }

        public bool Vacia()
        {
            if (raiz == null)
                return true;
            else
                return false;
        }

        public void Imprimir()
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                Console.Write(reco.info + "-");
                reco = reco.sig;
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        { 
            ListaGenericaDoble lg = new ListaGenericaDoble();
            int opc, respuesta;

            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                    Console.WriteLine("               Lista Generica Doble");
                    Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                    Console.WriteLine("(1) para: Alta de numeros");
                    Console.WriteLine("(2) para: Imprimir");
                    Console.WriteLine("(3) para: Borrar el primero");
                    Console.WriteLine("(4) para: Extraer el segundo numero");
                    Console.WriteLine("(5) para: Intercambiar el primero con el tercero");
                    Console.WriteLine("(6) para: Inprimir información");
                    Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                    Console.WriteLine();
                    Console.WriteLine("Ingrese una opcion");
                    opc = int.Parse(Console.ReadLine());
                } while (opc < 1 | opc > 6);
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingrese cuantos numero desea ingresar");
                        int opc2 = int.Parse(Console.ReadLine());
                        for (int i = 0; i < opc2; i++)
                        {
                            Console.WriteLine($"Ingrese el numero {i + 1}");
                            int n2 = int.Parse(Console.ReadLine());
                            lg.Insertar(i+1, n2);
                        }

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine($"-----------------------------------------");
                        Console.WriteLine($"      LOS NUMEROS INGRESADOS SON: ");
                        Console.WriteLine($"-----------------------------------------");
                        lg.Imprimir();

                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine($"-----------------------------------------");
                        Console.WriteLine("        Luego de Borrar el primero");
                        Console.WriteLine($"-----------------------------------------");
                        lg.Borrar(1);
                        lg.Imprimir();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine($"-----------------------------------------");
                        Console.WriteLine("       Luego de Extraer el segundo");
                        Console.WriteLine($"-----------------------------------------");
                        lg.Extraer(2);
                        lg.Imprimir();

                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine($"--------------------------------------------------------");
                        Console.WriteLine("    Luego de Intercambiar el primero con el tercero");
                        Console.WriteLine($"--------------------------------------------------------");
                        lg.Intercambiar(1, 3);
                        lg.Imprimir();
                        break;
                    case 6:
                        Console.Clear();
                        if (lg.Existe(20))
                        {
                            Console.WriteLine($"-----------------------------------------");
                            Console.WriteLine("      Se encuentra el 20 en la lista");
                            Console.WriteLine($"-----------------------------------------");
                        }
                        else
                        {
                            Console.WriteLine($"-----------------------------------------");
                            Console.WriteLine("    No se encuentra el 20 en la lista");
                            Console.WriteLine($"-----------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine($"-----------------------------------------");
                            Console.WriteLine("    La posición del mayor es:" + lg.PosMayor());
                            Console.WriteLine($"-----------------------------------------");
                        }
                        if (lg.Ordenada())
                        {
                            Console.WriteLine($"-----------------------------------------");
                            Console.WriteLine("  La lista está ordenada de menor a mayor");
                            Console.WriteLine($"-----------------------------------------");
                        }
                        else
                        {
                            Console.WriteLine($"---------------------------------------------");
                            Console.WriteLine("  La lista no está ordenada de menor a mayor");
                            Console.WriteLine($"----------------------------------------------");
                        }
                        break;
                }
                Console.WriteLine("-----------------------------");
                Console.WriteLine(" ¿QUIERES REGRESAR AL MENU?");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("         (1) .- SI");
                Console.WriteLine("         (2) .- NO");
                respuesta = int.Parse(Console.ReadLine());
            } while (respuesta == 1);


           
            Console.ReadKey();
        }

    }
}
