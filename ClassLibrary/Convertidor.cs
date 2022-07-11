using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class Convertidor
    {
        public static double Dolar { get { return 128; } }

        public static double Conversor(double precio)
        {
            var precioConvertido =Convert.ToInt32(precio / Dolar);
            return precioConvertido;
        }
    }
}
