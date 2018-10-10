using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios
{
    public class Password_Controlador
    {
        public static bool Validar_Password(char c)
        {
            if (Char.IsLetterOrDigit(c)) return false;
            else if (Char.IsControl(c)) return false;
            else return true;
        }
    }
}
