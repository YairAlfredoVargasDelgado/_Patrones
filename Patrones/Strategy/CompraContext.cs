using Patrones.Facade;

namespace Patrones.Strategy
{
    public class CompraContext
    {
        public ICompraStrategy Strategy { get; set; }
        
        public string Comprar(Producto producto, uint cantidad)
        {
            return Strategy.Comprar(producto, cantidad);
        }
    }
}
