using System.Collections.Generic;

namespace Patrones.Facade
{
    public class Inventario
    {
        private static IList<Producto> Productos { get; set; }

        public Inventario(IList<Producto> productos)
        {
            Productos = productos;
        }

        public static Producto BuscarProducto(Producto producto)
        {
            foreach (Producto p in Productos)
            {
                if (p.Nombre == producto.Nombre) return p;
            }
            return null;
        }

        public string SacarProducto(Producto producto, uint cantidad)
        {
            foreach(Producto p in Productos) {
                if (p.Nombre == producto.Nombre)
                {
                    if (Existencias(producto) > cantidad)
                    {
                        p.Cantidad -= cantidad;
                        return "Retiro exitoso";
                    }
                    else
                    {
                        return "No hay suficientes productos : " + producto.Nombre;
                    }
                }
            }
            return "Este producto no está regitrado";
        }

        public static string AgregarProducto(Producto producto, uint cantidad)
        {
            Producto p = BuscarProducto(producto);
            if (p == null)
            {
                p.Cantidad += cantidad;
                Productos.Add(p);
            } else
            {
                p.Cantidad += cantidad;
            }
            return "Registro exitoso";
        }

        public static int Existencias(Producto producto)
        {
            foreach(Producto p in Productos)
                if (p.Nombre == producto.Nombre) return (int)p.Cantidad;
            return -1;
        }
    }
}
