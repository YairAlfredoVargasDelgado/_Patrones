using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Adapter
{
    public class Triángulo : IFigura
    {
        public float Base { get; set; }

        public float Altura { get; set; }

        void IFigura.Mostrar()
        {
            Console.WriteLine("Es un triángulo");
        }
        
        float IFigura.Área()
        {
            return Base * Altura / 2;
        }
    }
}
