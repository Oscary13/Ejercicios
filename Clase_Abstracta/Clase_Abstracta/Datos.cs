using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Abstracta
{
    class Datos : Base
    {
        public override int suma(int a, int b)
        {
            return a+b+100;
        }
    }
}
