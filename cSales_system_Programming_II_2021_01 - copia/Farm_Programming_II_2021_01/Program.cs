using System;

namespace sales_system_Programming_II_2021_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Producto Zapatos = new Producto();

            Zapatos.Nombre = "Zapatos";
            Zapatos.Precio = 1000;
            Zapatos.Unidades = 7;
            Zapatos.PrecioRealUnidades();
            //

            //
            Producto Camisas = new Producto();

            Camisas.Nombre = "Camisas";
            Camisas.Precio = 700;
            Camisas.Unidades = 3;
            Camisas.PrecioRealUnidades();
            //

            //
            Producto Buzos = new Producto();

            Buzos.Nombre = "Buzos";
            Buzos.Precio = 2000;
            Buzos.Unidades = 4;
            Zapatos.PrecioRealUnidades();
            //

            //
            Vendedor Vendedor1 = new Vendedor();

            Vendedor1.Edad = 20;
            Vendedor1.Nombre = "Camilo";
            Vendedor1.Producto = Camisas;
            //    

            //
            Vendedor Vendedor2 = new Vendedor();

            Vendedor2.Edad = 27;
            Vendedor2.Nombre = "Sara";
            Vendedor2.Producto = Zapatos;
            //    

            //
            Vendedor Vendedor3 = new Vendedor();

            Vendedor3.Edad = 18;
            Vendedor3.Nombre = "Willmar";
            Vendedor3.Producto = Buzos;
            //    


            //
            Venta NuevaVenta = new Venta();

            NuevaVenta.AñadirProducto(Camisas);
            NuevaVenta.AñadirVendedor(Vendedor1);
            NuevaVenta.ObtenertotalVentas();
            //

            Console.WriteLine("El vendedor:  " + Vendedor1.Nombre + " Vendio " + Camisas.Unidades + " Unidades de " + 
                                                                      Camisas.Nombre + " Al precio de " + Camisas.PrecioRealUnidades() + "$");

            Console.WriteLine("El vendedor:  " + Vendedor2.Nombre + " Vendio " + Zapatos.Unidades + " Unidades de " +
                                                                     Zapatos.Nombre + " Al precio de " + Zapatos.PrecioRealUnidades() + "$");

            Console.WriteLine("El vendedor:  " + Vendedor3.Nombre + " Vendio " + Buzos.Unidades + " Unidades de " +
                                                                     Buzos.Nombre + " Al precio de " + Buzos.PrecioRealUnidades() + "$");

            float Ventastotales = Camisas.PrecioRealUnidades() + Zapatos.PrecioRealUnidades() + Buzos.PrecioRealUnidades();


            Console.WriteLine("El toal de la suma de las ventas es : " + Ventastotales + "$");

            float MediaVentastotales = (Camisas.PrecioRealUnidades() + Zapatos.PrecioRealUnidades() + Buzos.PrecioRealUnidades()) / (3) ;

            Console.WriteLine("La media del precio total de las ventas es :  " + MediaVentastotales + "$");

        }
    }
}
