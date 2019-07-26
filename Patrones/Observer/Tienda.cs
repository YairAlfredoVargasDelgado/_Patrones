using Patrones.Facade;

namespace Patrones.Observer
{
    public class Tienda : Publisher
    {
        public Inventario Inventario { get; set; }

        public void AgregarProducto(Producto producto, uint cantidad)
        {
            Inventario.AgregarProducto(producto, cantidad);
            Notify("Ha llegado el " + producto.Nombre);
        }
    }
}
