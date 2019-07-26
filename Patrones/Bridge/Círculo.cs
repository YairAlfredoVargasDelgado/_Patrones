using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Bridge
{
    public class Círculo : IFigura
    {
        public void Mostrar()
        {
            Console.WriteLine("Es un círculo");
        }
    }
}
