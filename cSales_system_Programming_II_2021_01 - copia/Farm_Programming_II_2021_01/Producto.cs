using System;
using System.Collections.Generic;
using System.Text;

namespace sales_system_Programming_II_2021_01
{
    public class Producto
    {

        public String Nombre;

        public float Precio;

        public float Unidades;

        public int ContadorUnidades;



        public float PrecioRealUnidades()
        {

            return Precio * Unidades;

        }



        




    }
}
