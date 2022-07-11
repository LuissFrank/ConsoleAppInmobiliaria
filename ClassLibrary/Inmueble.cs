using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Inmueble
    {
        public Inmueble(int id, string domicilio, int ambientes, double precio, double expensas, Estado estado, double metrosCuadrados)
        {
            this.Id = id;
            this.Domicilio = domicilio;
            this.Ambientes = ambientes;
            this.Precio = precio;
            this.Expensas = expensas;
            this.TipoEstado = estado;
            this.MetrosCuadrados = metrosCuadrados;
        }
        public int Id { get; private set; }
        public string Domicilio { get; private set; }
        public int Ambientes { get; private set; }
        public double Precio { get; private set; }
        public double Expensas { get; private set; }
        public enum Estado
        {
            venta,
            alquiler,
        }
        public Estado TipoEstado { get; set; }
        public double MetrosCuadrados { get; set; }

        public abstract double Impuestos();

    }
}
