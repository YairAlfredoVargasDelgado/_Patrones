using Patrones.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones
{
    public abstract class Figura
    {
        IColor color;

        public Figura(IColor color)
        {
            this.color = color;
        }

        public abstract void Mostrar();
    }
}
