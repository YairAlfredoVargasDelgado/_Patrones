using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.AbstractFactory
{
    public class PapasFritas : Frito
    {
        public override void Preparar()
        {
            Console.WriteLine("Se prepararon unas papas fritas");
        }
    }
}
