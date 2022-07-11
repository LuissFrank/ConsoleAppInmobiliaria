using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Departamento: Inmueble
    {
        public Departamento(int id, string domicilio, int ambientes, double precio, double expensas, Estado estado, int piso, double metrosCuadrados) : base(id, domicilio, ambientes, precio, expensas, estado, metrosCuadrados)
        {
            this.Piso = piso;
        }
        public int Piso { get; private set; }
        public override double Impuestos()
        {
            var imp = 0;
            if (TipoEstado == Estado.venta)
            {
                imp = 4500;
            }
            else if (TipoEstado == Estado.alquiler)
            {
                imp = 6000;
            }

            return imp;
        }



    }
}
