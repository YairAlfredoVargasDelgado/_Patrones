using System.Collections.Generic;

namespace Patrones.Facade
{
    public class CompraFacade
    {
        private Inventario Inventario = new Inventario(new List<Producto>());
        private IList<Cliente> Clientes = new List<Cliente>();
        private Tienda Tienda = new Tienda();

        public CompraFacade() { }

        public string Comprar(Cliente cliente, Producto producto, uint cantidad)
        {
            if (Cliente.ClienteRegistrado(cliente, Clientes))
            {
                if (Inventario.BuscarProducto(producto) != null)
                {
                    if (Inventario.SacarProducto(producto, cantidad) == "Retiro exitoso")
                    {
                        if (cliente.Cuenta.Transferir(cantidad * producto.Precio, Tienda.Cuenta))
                        {
                            return "Compra exitosa";
                        }
                        Inventario.AgregarProducto(producto, cantidad);
                        return "Saldo insuficiente";
                    }
                    return "No hay suficientes productos";
                }
                return "Este producto no está registrado";
            }
            return "Este cliente no está registrado";
        }
    }
}
