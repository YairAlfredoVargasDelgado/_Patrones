using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patrones.Facade;

namespace Patrones.Strategy
{
    public class ChequeStrategy : ICompraStrategy
    {
        public string Comprar(Producto producto, uint cantidad)
        {
            return "Se compraron " + cantidad + " de " + producto.Nombre + "s con cheque";
        }
    }
}
