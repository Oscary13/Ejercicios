using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validar
{
    class Valida
    {
        public string user = "Sistemas";
        public string password = "12345";

        public string ValidaDatosAcceso(string usuario, string contraseña)
        {
            if (usuario == user)
            {
                if (password == contraseña)
                {
                    return "ok";


                }
                else
                {
                    return "La contraseña es incorrecta, validar e intentar nuevamente";
                }
            }
            else
            {
                return "El usuario que ingreso es incorrecto, validar e intentar nuevamente";
            }
            return "";
        }

    }
}
