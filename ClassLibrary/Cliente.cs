using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Cliente
    {
        public Cliente(string nombre, string apellido, int dni, bool recibo, int sueldo, Garantia garantia) 
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
            this.ReciboSueldo = recibo;
            this.Sueldo = sueldo;
            this.GarantiaTipo = garantia;
        }
        public string Nombre {get;set;}
        public string Apellido {get;set;}
        public int DNI {get;set;}
        public bool ReciboSueldo { get; private set; }
        public int Sueldo { get; private set; }
        public enum Garantia
        {
            GarantiaProp,
            Seguro,
            sinGarantia
        }
        public Garantia GarantiaTipo { get; private set; }
        
    }
}
