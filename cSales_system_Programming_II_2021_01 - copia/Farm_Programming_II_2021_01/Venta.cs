using System;
using System.Collections.Generic;
using System.Text;

namespace sales_system_Programming_II_2021_01
{
    class Venta
    {

        public Vendedor[] Vendedores = new Vendedor[3];

        public Producto[] Productos = new Producto[3];

        public String Comentario;

        public int ContadorProducto = 0;

        public int ContadorVendedores = 0;


        public void AñadirProducto(Producto newProductos)
        {

            Productos[ContadorProducto] = newProductos;

            ContadorProducto++;

        }

        public void AñadirVendedor(Vendedor newVendedor)
        {

            Vendedores[ContadorVendedores] = newVendedor;

            ContadorVendedores++;

        }

        public float ObtenertotalVentas()
        {
            float totalVentas = 0;
            for (int i = 0; i < ContadorVendedores; i++)
            {

                totalVentas = totalVentas + Productos[i].PrecioRealUnidades();

            }
            return totalVentas;

            


        }
    }
}
