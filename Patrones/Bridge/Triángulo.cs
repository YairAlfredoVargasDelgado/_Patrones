using Patrones.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Bridge
{
    public class Triángulo : Figura
    {
        public Triángulo(IColor color) : base(color)
        {
        }

        public override void Mostrar()
        {
            Console.WriteLine("Es un triángulo de color ");
        }
        
    }
}
