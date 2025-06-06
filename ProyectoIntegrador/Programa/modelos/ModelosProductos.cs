using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.Programa.modelos
{
       public class ModelosProductos
        {
            int id_producto;
            string nombre;
            string cantidad;
            decimal precio;
            string descripcion;
            string detalles;

            public int id_produc { get => id_producto; set => id_producto = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Cantidad { get => cantidad; set => cantidad = value; }
            public decimal Precio { get => precio; set => precio = value; }
            public string Descripcion { get => descripcion; set => descripcion = value; }
            public string Detalles { get => detalles; set => detalles = value; }
    }
}

