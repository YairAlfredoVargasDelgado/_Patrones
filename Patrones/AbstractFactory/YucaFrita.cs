using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.AbstractFactory
{
    public class YucaFrita : Frito
    {
        public override void Preparar()
        {
            Console.WriteLine("Se preparó una yuca frita");
        }
    }
}
