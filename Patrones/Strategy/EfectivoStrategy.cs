using Patrones.Facade;

namespace Patrones.Strategy
{
    public class EfectivoStrategy : ICompraStrategy
    {
        public string Comprar(Producto producto, uint cantidad)
        {
            return "Se compraron " + cantidad + " de " + producto.Nombre + "s con efectivo";
        }
    }
}
