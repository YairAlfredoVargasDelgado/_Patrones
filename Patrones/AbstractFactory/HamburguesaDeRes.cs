using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.AbstractFactory
{
    public class HamburguesaDeRes : Hamburguesa
    {
        public override void Preparar()
        {
            Console.WriteLine("Se preparó una hamburguesa de res");
        }
    }
}
