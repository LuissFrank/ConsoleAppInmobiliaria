using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Casa: Inmueble
    {
        public Casa(int id, string domicilio, int ambientes, double precio, double expensas, Estado estado, bool jardin, double metrosCuadrados) : base(id, domicilio, ambientes, precio, expensas, estado, metrosCuadrados)
        {
            this.Jardin = jardin;
        }
        public bool Jardin { get; set; }
        public override double Impuestos()
        {
            var imp = 0;
            if (TipoEstado == Estado.venta)
            {
                imp = 9000;
            }
            else if (TipoEstado == Estado.alquiler)
            {
                imp = 7000;
            }

            return imp;
        }
    }
}
