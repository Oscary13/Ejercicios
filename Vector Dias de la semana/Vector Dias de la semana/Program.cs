using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector_Dias_de_la_semana
{
    class Program
    {
        static void Main(string[] args)
		{
			string[] D = new string[7];

			for (int i = 0; i < D.Length; i++)
			{
				Console.WriteLine("Escriba el dia" );
				D[i] = Console.ReadLine();

			}
			Console.WriteLine(" ");
			Console.WriteLine("Dias de la semana");
			Console.WriteLine(D[0]);
			Console.WriteLine(D[1]);
			Console.WriteLine(D[2]);
			Console.WriteLine(D[3]);
			Console.WriteLine(D[4]);
			Console.WriteLine(D[5]);
			Console.WriteLine(D[6]);
			Console.ReadKey();
		}

	}
}
