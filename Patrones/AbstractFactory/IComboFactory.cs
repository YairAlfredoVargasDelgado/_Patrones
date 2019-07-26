using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.AbstractFactory
{
    public interface IComboFactory
    {
        Hamburguesa CrearHamburguesa();

        Gaseosa CrearGaseosa();

        Frito CrearFrito();
    }
}
