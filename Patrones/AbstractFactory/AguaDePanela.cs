using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.AbstractFactory
{
    public class AguaDePanela : Bebida
    {
        public override void Servir()
        {
            Console.WriteLine("Se sirvió un agua de panela");
        }
    }
}
