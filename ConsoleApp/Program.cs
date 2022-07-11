using System;
using ClassLibrary;
namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var local4 = new LocalComercial(5, "Lavalle 321", 2, 9000, 3000, Inmueble.Estado.alquiler, 34);
            var local2 = new LocalComercial(7, "Florida 546", 2, 9000, 3000, Inmueble.Estado.alquiler, 23);
            var departamento1 = new Departamento(1, "carlos calvo 2102", 2, 35000, 8000, Inmueble.Estado.alquiler, 7, 54);
            var departamento2 = new Departamento(6, "9 de julio 4309", 3, 880000, 0, Inmueble.Estado.venta, 8, 43);
            var casa1 = new Casa(2, "Rivadavia 1132", 4, 50000, 0, Inmueble.Estado.alquiler, true, 45);
            var casa2 = new Casa(3, "Av Callao 3211", 5, 60000, 2000, Inmueble.Estado.alquiler, true, 56);
            var cliente1 = new Cliente("Luis", "Ortega", 345465, true, 70000, Cliente.Garantia.GarantiaProp);
            var casa3 = new Casa(4, "Paso 983", 3, 15000000, 0, Inmueble.Estado.venta, true, 67);
            var cliente2 = new Cliente("Carlos", "Perez", 34546534, false, 50000, Cliente.Garantia.sinGarantia);
            

            var inmobiliaria = new Inmobiliaria();
            inmobiliaria.Ingresar(casa1);
            inmobiliaria.Ingresar(departamento1);
            inmobiliaria.Ingresar(casa2);
            inmobiliaria.Ingresar(casa3);
            inmobiliaria.Ingresar(departamento2);
            inmobiliaria.Ingresar(local2);
            inmobiliaria.Ingresar(local4);

            inmobiliaria.Resiquitos(cliente1);
            

            //inmobiliaria.Resiquitos(inquilino2);



        }
    }
}
