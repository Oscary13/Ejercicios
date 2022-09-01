using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validar
{
    class Productos
    {
        public void menuproductos()
        {
            int opc = 0;
            Boolean resp;
            do
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("                  Menu de productos");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("1.- Ferreteria");
                Console.WriteLine("2.- Abarrotes");
                Console.WriteLine("3.- Vinos y licores");
                Console.WriteLine("4.- Farmacia");
                Console.WriteLine("5.- Jugeteria");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Seleccione el numero de la opcion que desee");
                opc = int.Parse(Console.ReadLine());
                resp = Valida(opc, 5);

            } while (resp);

            switch (opc)
            {
                case 1:
                    menuFerreteria();
                    break;
                case 2:
                    menuAbarrotes();
                    break;
                case 3:
                    menuVinosYLicores();
                    break;
                case 4:
                    menuFarmacia();
                    break;
                case 5:
                    menuJugueteria();
                    break;
            }


        }
        public Boolean Valida(int opcion, int rango)
        {
            if (opcion < 1 || opcion > rango)
            {
                Console.WriteLine(" La opcion que ingreso es incorrecta, validar e intentar nuevamente........... ENTER para continuar..");
                Console.ReadKey();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void menuFerreteria()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("                     Menu Ferreteria");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Id -----------------    NOMBRE   ----------- precio");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("(1) ------------------  Martillo  ----------- $ 200");
            Console.WriteLine("(2) ------------------  Taladro  ------------ $ 200");
            Console.WriteLine("(3) ------------------  Desarmador  --------- $  35");
            Console.WriteLine("(4) ------------------  Pala  --------------- $ 250");
            Console.WriteLine("(5) ------------------  Pico  --------------- $ 320");
            Console.WriteLine("(6) ------------------  Cemento  ------------ $ 140");
            Console.WriteLine("(7) ------------------  Tornillo  ----------- $  10");
            Console.WriteLine("---------------------------------------------------");
            int suma = 0;
            int otro = 0;
            do
            {
                int[] arreglo = new int[7];
                for (int i = 0; i < 7; i++)
                {
                    arreglo[0] = 200;
                    arreglo[1] = 200;
                    arreglo[2] = 35;
                    arreglo[3] = 250;
                    arreglo[4] = 320;
                    arreglo[5] = 140;
                    arreglo[6] = 10;

                }
                Console.WriteLine("Ingresa el Id del producto que desees:");
                int opc = int.Parse(Console.ReadLine());
                suma = suma + arreglo[opc - 1];
                Console.WriteLine("¿Desea agregar algo mas?");
                Console.WriteLine("(1).- SI");
                Console.WriteLine("(2).- NO");
                otro = int.Parse(Console.ReadLine());
                Boolean resp = Valida(opc, 7);

            } while (otro == 1);
            Console.WriteLine("El precio total de tus productos es: $" + suma);
        }
        public void menuAbarrotes()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("                     Menu Abarrotes");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Id -----------------    NOMBRE   ---- precio x kilo");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("(1) ------------------  Frijo  ---------------$  30");
            Console.WriteLine("(2) ------------------  Arroz  -------------- $  25");
            Console.WriteLine("(3) ------------------  Huevo  -------------- $  36");
            Console.WriteLine("(4) ------------------  Jamón  -------------- $  60");
            Console.WriteLine("(5) ------------------  Azúcar -------------- $  20");
            Console.WriteLine("---------------------------------------------------");

            int suma = 0;
            int otro = 0;
            do
            {
                int[] arreglo = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    arreglo[0] = 30;
                    arreglo[1] = 25;
                    arreglo[2] = 36;
                    arreglo[3] = 60;
                    arreglo[4] = 20;

                }
                Console.WriteLine("Ingresa el Id del producto que desees:");
                int opc = int.Parse(Console.ReadLine());
                suma = suma + arreglo[opc - 1];
                Console.WriteLine("¿Desea agregar algo mas?");
                Console.WriteLine("(1).- SI");
                Console.WriteLine("(2).- NO");
                otro = int.Parse(Console.ReadLine());
                Boolean resp = Valida(opc, 5);
            } while (otro == 1);
            Console.WriteLine("El precio total de tus productos es: $" + suma);
        }
        public void menuVinosYLicores()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("                  Menu Vinos y licores");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Id -----------------    NOMBRE   ----------- precio");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("(1) ------------------  Vodka  -------------  $ 100");
            Console.WriteLine("(2) ------------------  Torres10  ----------  $ 200");
            Console.WriteLine("(3) ------------------  Tonalla  ------------ $  10");
            Console.WriteLine("(4) ------------------  DonRamon  ----------- $ 150");
            Console.WriteLine("(5) ------------------  Bacardí ------------- $ 180");
            Console.WriteLine("(6) ------------------  Black and white ----- $ 220");
            Console.WriteLine("---------------------------------------------------");
            int suma = 0;
            int otro = 0;
            do
            {
                int[] arreglo = new int[6];
                for (int i = 0; i < 6; i++)
                {
                    arreglo[0] = 100;
                    arreglo[1] = 200;
                    arreglo[2] = 10;
                    arreglo[3] = 150;
                    arreglo[4] = 180;
                    arreglo[5] = 220;

                }
                Console.WriteLine("Ingresa el Id del producto que desees:");
                int opc = int.Parse(Console.ReadLine());
                suma = suma + arreglo[opc - 1];
                Console.WriteLine("¿Desea agregar algo mas?");
                Console.WriteLine("(1).- SI");
                Console.WriteLine("(2).- NO");
                otro = int.Parse(Console.ReadLine());
                Boolean resp = Valida(opc, 6);

            } while (otro == 1);
            Console.WriteLine("El precio total de tus productos es: $" + suma);
        }
        public void menuFarmacia()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("                  Menu Farmacia");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Id -----------------    NOMBRE   ----------- precio");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("(1) ------------------  Clonazepam  --------  $ 100");
            Console.WriteLine("(2) ------------------  Paracetamol --------  $  40");
            Console.WriteLine("(3) ------------------  Jarabe para la tos  - $  18");
            Console.WriteLine("(4) ------------------  Xanax  -------------- $ 215");
            Console.WriteLine("(5) ------------------  Next ---------------- $  25");
            Console.WriteLine("(6) ------------------ Alcohol -------------- $  15");
            Console.WriteLine("(7) ------------------ Vendas --------------- $  20");
            Console.WriteLine("(8) ------------------ Gasas ---------------- $   5");
            Console.WriteLine("(9) ------------------ Curitas -------------- $   2");
            Console.WriteLine("---------------------------------------------------");
            int suma = 0;
            int otro = 0;
            do
            {
                int[] arreglo = new int[7];
                for (int i = 0; i < 7; i++)
                {
                    arreglo[0] = 100;
                    arreglo[1] = 40;
                    arreglo[2] = 18;
                    arreglo[3] = 215;
                    arreglo[4] = 25;
                    arreglo[5] = 15;
                    arreglo[6] = 20;
                    arreglo[7] = 5;
                    arreglo[8] = 2;


                }
                Console.WriteLine("Ingresa el Id del producto que desees:");
                int opc = int.Parse(Console.ReadLine());
                suma = suma + arreglo[opc - 1];
                Console.WriteLine("¿Desea agregar algo mas?");
                Console.WriteLine("(1).- SI");
                Console.WriteLine("(2).- NO");
                otro = int.Parse(Console.ReadLine());
                Boolean resp = Valida(opc, 9);

            } while (otro == 1);
            Console.WriteLine("El precio total de tus productos es: $" + suma);
        }
        public void menuJugueteria()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("                    Menu Jugueteria");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Id -----------------    NOMBRE   ------------ precio");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("(1) ------------------  MaxSteel  ----------  $  160");
            Console.WriteLine("(2) ------------------  Barbie  ------------- $  150");
            Console.WriteLine("(3) ------------------  Nenuco  ------------- $   18");
            Console.WriteLine("(4) ------------------  Legos figura  ------- $  100");
            Console.WriteLine("(5) ------------------  Next ---------------- $   25");
            Console.WriteLine("(6) ------------------  Terreneitor -------- $  1500");
            Console.WriteLine("----------------------------------------------------");
            int suma = 0;
            int otro = 0;
            do
            {
                int[] arreglo = new int[6];
                for (int i = 0; i < 6; i++)
                {
                    arreglo[0] = 160;
                    arreglo[1] = 150;
                    arreglo[2] = 18;
                    arreglo[3] = 100;
                    arreglo[4] = 25;
                    arreglo[5] = 1500;

                }
                Console.WriteLine("Ingresa el Id del producto que desees:");
                int opc = int.Parse(Console.ReadLine());
                suma = suma + arreglo[opc - 1];
                Console.WriteLine("¿Desea agregar algo mas?");
                Console.WriteLine("(1).- SI");
                Console.WriteLine("(2).- NO");
                otro = int.Parse(Console.ReadLine());
                Boolean resp = Valida(opc, 6);

            } while (otro == 1);
            Console.WriteLine("El precio total de tus productos es: $" + suma);
        }
    }
}
