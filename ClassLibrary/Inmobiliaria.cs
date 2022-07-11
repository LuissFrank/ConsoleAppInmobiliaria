using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary
{
    public sealed class Inmobiliaria
    {
        private List<Inmueble> inmuebles { get; set; }
        private List<Inmueble> reservados { get; set; }
       


        public double Gastos { get { return 8000; } }

        //agregar un inmueble a la lista
        public void Ingresar(Inmueble inmuble)
        {
            if (inmuebles is null)
            {
                inmuebles = new List<Inmueble>();
            }
            inmuebles.Add(inmuble);
        }

        //listas por tipos
        public void Lista()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("          Lista de inmuebles:      ");
            Console.WriteLine("***********************************");
            foreach (Inmueble dep in inmuebles.OrderBy(x => x.Id))
            {
                if (dep.TipoEstado == Inmueble.Estado.venta)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("");
                    Console.WriteLine("Inmueble: " + dep.Id);
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Ubicacion: " + dep.Domicilio);
                    Console.WriteLine("Cantida de ambientes: " + dep.Ambientes);
                    Console.WriteLine("Precio: $" + dep.Precio);
                    Console.WriteLine("Precio en dolares: US$" + Convertidor.Conversor(dep.Precio));
                    Console.WriteLine("Expensas: $" + dep.Expensas);
                    Console.WriteLine("Metros cuadrados: " + dep.MetrosCuadrados);
                    Console.WriteLine("Tipo de transaccion: " + dep.TipoEstado);
                    Console.WriteLine("---------------------------------------");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("");
                    Console.WriteLine("Inmueble: " + dep.Id);
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Ubicacion: " + dep.Domicilio);
                    Console.WriteLine("Cantida de ambientes: " + dep.Ambientes);
                    Console.WriteLine("Precio: $" + dep.Precio);
                    Console.WriteLine("Precio en dolares: US$" +  Convertidor.Conversor(dep.Precio));
                    Console.WriteLine("Expensas: $" + dep.Expensas);
                    Console.WriteLine("Metros cuadrados: " + dep.MetrosCuadrados);
                    Console.WriteLine("Tipo de transaccion: " + dep.TipoEstado);
                    Console.WriteLine("---------------------------------------");
                }

            }
            Cant();
            CantCasa();
            Cantdpto();
            CantLocal();
            Busqueda();
        }
        public void ListaDpto()
        {
            foreach (Inmueble dep in inmuebles.Where(x => x.GetType() == typeof(Departamento)))
            {
                if (dep.TipoEstado == Inmueble.Estado.venta)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("");
                    Console.WriteLine("Inmueble: " + dep.Id);
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Ubicacion: " + dep.Domicilio);
                    Console.WriteLine("Cantida de ambientes: " + dep.Ambientes);
                    Console.WriteLine("Precio: $" + dep.Precio);
                    Console.WriteLine("Precio en dolares: US$" + Convertidor.Conversor(dep.Precio));
                    Console.WriteLine("Expensas: $" + dep.Expensas);
                    Console.WriteLine("Metros cuadrados: " + dep.MetrosCuadrados);
                    Console.WriteLine("Tipo de transaccion: " + dep.TipoEstado);
                    Console.WriteLine("---------------------------------------");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("");
                    Console.WriteLine("Inmueble: " + dep.Id);
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Ubicacion: " + dep.Domicilio);
                    Console.WriteLine("Cantida de ambientes: " + dep.Ambientes);
                    Console.WriteLine("Precio: $" + dep.Precio);
                    Console.WriteLine("Precio en dolares: US$" + Convertidor.Conversor(dep.Precio));
                    Console.WriteLine("Expensas: $" + dep.Expensas);
                    Console.WriteLine("Metros cuadrados: " + dep.MetrosCuadrados);
                    Console.WriteLine("Tipo de transaccion: " + dep.TipoEstado);
                    Console.WriteLine("---------------------------------------");
                }
            }
        }
        public void ListaCasa()
        {
            foreach (Inmueble dep in inmuebles.Where(x => x.GetType() == typeof(Casa)))
            {
                if (dep.TipoEstado == Inmueble.Estado.venta)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("");
                    Console.WriteLine("Inmueble: " + dep.Id);
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Ubicacion: " + dep.Domicilio);
                    Console.WriteLine("Cantida de ambientes: " + dep.Ambientes);
                    Console.WriteLine("Precio: $" + dep.Precio);
                    Console.WriteLine("Precio en dolares: US$" + Convertidor.Conversor(dep.Precio));
                    Console.WriteLine("Expensas: $" + dep.Expensas);
                    Console.WriteLine("Metros cuadrados: " + dep.MetrosCuadrados);
                    Console.WriteLine("Tipo de transaccion: " + dep.TipoEstado);
                    Console.WriteLine("---------------------------------------");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("");
                    Console.WriteLine("Inmueble: " + dep.Id);
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Ubicacion: " + dep.Domicilio);
                    Console.WriteLine("Cantida de ambientes: " + dep.Ambientes);
                    Console.WriteLine("Precio: $" + dep.Precio);
                    Console.WriteLine("Precio en dolares: US$" + Convertidor.Conversor(dep.Precio));
                    Console.WriteLine("Expensas: $" + dep.Expensas);
                    Console.WriteLine("Metros cuadrados: " + dep.MetrosCuadrados);
                    Console.WriteLine("Tipo de transaccion: " + dep.TipoEstado);
                    Console.WriteLine("---------------------------------------");
                }
            }
        }

        public void ListaLocal()
        {
            foreach (Inmueble dep in inmuebles.Where(x => x.GetType() == typeof(LocalComercial)))
            {
                if (dep.TipoEstado == Inmueble.Estado.venta)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("");
                    Console.WriteLine("Inmueble: " + dep.Id);
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Ubicacion: " + dep.Domicilio);
                    Console.WriteLine("Cantida de ambientes: " + dep.Ambientes);
                    Console.WriteLine("Precio: $" + dep.Precio);
                    Console.WriteLine("Precio en dolares: US$" + Convertidor.Conversor(dep.Precio));
                    Console.WriteLine("Expensas: $" + dep.Expensas);
                    Console.WriteLine("Metros cuadrados: " + dep.MetrosCuadrados);
                    Console.WriteLine("Tipo de transaccion: " + dep.TipoEstado);
                    Console.WriteLine("---------------------------------------");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("");
                    Console.WriteLine("Inmueble: " + dep.Id);
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Ubicacion: " + dep.Domicilio);
                    Console.WriteLine("Cantida de ambientes: " + dep.Ambientes);
                    Console.WriteLine("Precio: $" + dep.Precio);
                    Console.WriteLine("Precio en dolares: US$" + Convertidor.Conversor(dep.Precio));
                    Console.WriteLine("Expensas: $" + dep.Expensas);
                    Console.WriteLine("Metros cuadrados: " + dep.MetrosCuadrados);
                    Console.WriteLine("Tipo de transaccion: " + dep.TipoEstado);
                    Console.WriteLine("---------------------------------------");
                }
            }
        }

        //menu principal
        public void menu()
        {
            

            int op = 0;
            Console.WriteLine("Bienvenido: ");
            Console.WriteLine("ingrese la opcion que desea ver");
            Console.WriteLine("1)- lista de todos los inmuebles");
            Console.WriteLine("2)- buscar por tipo de inmueble");
            Console.WriteLine("3)- Administracion");
            Console.WriteLine("4)- salir");
            

            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Lista();
                    break;
                case 2:
                    TiposInmobiliaria();
                    break;
                case 3:
                    ListaReservados();
                    break;
                case 4:
                    Console.WriteLine("Hasta luego");
                    Environment.Exit(0);
                    break;

            }


        }

        //menu secundario de busqueda de tipo inmueble
        public void TiposInmobiliaria()
        {
            Console.WriteLine("Ingrese el tipo de inmueble que quiere buscar");
            Console.WriteLine("1) - Casas");
            Console.WriteLine("2)- Departamentos");
            Console.WriteLine("3) - Locales");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    ListaCasa();
                    Busqueda();
                    break;
                case 2:
                    ListaDpto();
                    Busqueda();
                    break;
                case 3:
                    ListaLocal();
                    Busqueda();
                    break;
                
            }
        }


        //busqueda por id para la venta.
        //al seleccionar el inmueble, ese inmueble se borra del listado.
        //y se ingresa a una lista nueva de reserva
        public void Busqueda()
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese el ID");
            int busquedaId = Convert.ToInt32(Console.ReadLine());

            foreach (Inmueble dep in inmuebles)
            {
                if (busquedaId == dep.Id)
                {
                    Console.WriteLine("Domilicio: " + dep.Domicilio);
                    Console.WriteLine("Cantidad de ambientes: " + dep.Ambientes);
                    Console.WriteLine("Precio: " + dep.Precio);
                    Console.WriteLine("Expensas: " + dep.Expensas);
                    Console.WriteLine("Metros cuadrados: " + dep.MetrosCuadrados);
                    Console.WriteLine("Gastos inmoboliarios: " + Gastos);
                    Console.WriteLine("Gastos impuestos: " + dep.Impuestos());
                    var total = dep.Precio + dep.Expensas + Gastos + dep.Impuestos();
                    if (dep.TipoEstado == Inmueble.Estado.venta)
                    {
                        Console.WriteLine("Usted Comprara el departamento  con un total de: $" + total);
                    }
                    else if (dep.TipoEstado == Inmueble.Estado.alquiler)
                    {
                        Console.WriteLine("Usted alquilara el departamento  con un total de: $" + total);


                    }
                    Console.ReadKey();
                    if (reservados is null)
                    {
                        reservados = new List<Inmueble>();
                    }
                    reservados.Add(dep);
                    inmuebles.Remove(dep);
                    menu();
                }


            }
        }

        //cantidad de inmuebles depende su tipo
        private void Cant()
        {
            var cant = inmuebles.Count();
            Console.WriteLine("Cantidad de inmuebles: " + cant);
        }

        private void Cantdpto()
        {
            var cant = inmuebles.Where(x => x.GetType() == typeof(Departamento)).Count();
            Console.WriteLine("Cantidad de Departamentos: " + cant);
        }
        private void CantCasa()
        {
            var cant = inmuebles.Where(x => x.GetType() == typeof(Casa)).Count();
            Console.WriteLine("Cantidad de casas: " + cant);
        }
        private void CantLocal()
        {
            var cant = inmuebles.Where(x => x.GetType() == typeof(LocalComercial)).Count();
            Console.WriteLine("Cantidad de locales: " + cant);
        }


        //funcion que chequea si el inquilino que va alquilar tiene garantia.
        public void Resiquitos(Cliente cli)
        {
            if (cli.ReciboSueldo == true && cli.GarantiaTipo != Cliente.Garantia.sinGarantia)
            {
                menu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Usted no esta apto para alquilar un departamento");
            }
        }
        

        



        //Muestra la recaudacion en base a la cantidad de inmueble en la lista de reserva
        public void recaudacion()
        {
            double recaudacion = 0;
            recaudacion = Gastos * reservados.Count;
            
            Console.WriteLine("------------------------------------");
            Console.WriteLine("La recaudacion es de: $" + recaudacion);
            Console.WriteLine("------------------------------------");
        }


        //metodo que muestra los datos de los inmuebles reservados
        //sino hay ningun inmueble en la lista esta la excepcion.
        public void ListaReservados()
        {
            try
            {
                foreach (Inmueble rep in reservados)
                {
                    Console.WriteLine("Departamentos en reserva: ");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Domiciilio: " + rep.Domicilio);
                    Console.WriteLine("Precio $" + rep.Precio);
                    Console.WriteLine("Movimiento: " + rep.TipoEstado);
                }
                recaudacion();
                menu();
            }
            catch(Exception)
            {
                Console.WriteLine("No hay inmuebles reservados");
                menu();
            }
        }
    }
}
