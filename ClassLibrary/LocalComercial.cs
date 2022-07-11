using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LocalComercial : Inmueble
    {
        public LocalComercial(int id, string domicilio, int ambientes, double precio, double expensas, Estado estado, double metrosCuadrados) : base(id, domicilio, ambientes, precio, expensas, estado, metrosCuadrados)
        {

        }


        public override double Impuestos()
        {
            var imp = 0;
            if (TipoEstado == Estado.alquiler)
            {
                imp = 4500;
            }
            else if (TipoEstado == Estado.venta)
            {
                imp = 5500;
            }
            return imp;
        }

        
    }
}
