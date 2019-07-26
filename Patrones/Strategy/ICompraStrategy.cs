using Patrones.Facade;

namespace Patrones.Strategy
{
    public interface ICompraStrategy
    {
        string Comprar(Producto producto, uint cantidad);
    }
}