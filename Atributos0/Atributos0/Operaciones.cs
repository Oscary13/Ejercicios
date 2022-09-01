using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos0
{
    class Operaciones
    {
        public int num1;
        public int num2;
        public void suma(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("El resultado de la suma es: " + sum);

        }
        public int resta(int num1, int num2)
        {
            int rest = num1 - num2;
            return rest;
        }

        public int multi(int num1, int num2)
        {
            int multi = num1 * num2;
            return multi;
        }

        public double divi(double num1, double num2)
        {
            double divi = num1 / num2;
            return divi;
        }

    }
}
