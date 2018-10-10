using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios
{
    public class Numero_Controlador
    {
        public static bool Validar_Numero_Entero(char c)
        {
            if (Char.IsDigit(c)) return false;
            else if (Char.IsControl(c)) return false;
            else return true;
        }

        public static bool Validar_Numero_Decimal(string numero, char c)
        {
            bool esDecimal = false;
            int n;

            if (Char.IsDigit(c) || c == '.')
            {
                n = numero.Length;
                if (n == 0 && c == '.') return true;
                for (int i = 0; i < n; i++)
                {
                    if (numero[i] == '.' && !esDecimal)
                    {
                        esDecimal = true;
                        break;
                    }
                }
                if (esDecimal && c == '.') return true;
                return false;
            }
            else if (Char.IsControl(c)) return false;
            else return true;
        }
    }
}
