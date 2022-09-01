using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Abstracta
{
    public abstract class Base
    {
        public int resultado { get; set; }
        public string saludo { get; set; }
        public string aPaterno { get; set; }
        public string nombre { get; set; }
        public string Bienvenida()
        {
            return "Saludo de Bienvenida";
        }
        public virtual int suma (int a, int b)
        {
            return a + b;
        }
        public  int sumaNumeros(int a, int b)
        {
            return a + b +10+5;
        }
    }
}
