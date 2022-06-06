using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
    public class ProductosBL
    {
        public List<producto> ObtenerProductos()
        {

            var producto1 = new producto();
            producto1.Id = 1;
            producto1.Descripcion = "Pizza 6 quesos";
            producto1.Precio = 200;

            var producto2 = new producto();
            producto2.Id = 2;
            producto2.Descripcion = "Pizza 4 estaciones";
            producto2.Precio = 250;

            var producto3 = new producto();
            producto3.Id = 3;
            producto3.Descripcion = "Pizza jamón y queso";
            producto3.Precio = 150;

            var producto4 = new producto();
            producto4.Id = 4;
            producto4.Descripcion = "Pizza cencilla";
            producto4.Precio = 180;

            var ListadeProductos = new List<producto>();
            ListadeProductos.Add(producto1);
            ListadeProductos.Add(producto2);
            ListadeProductos.Add(producto3);


            return ListadeProductos;


        }
    }
}
