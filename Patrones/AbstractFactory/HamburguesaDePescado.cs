using System;

namespace Patrones.AbstractFactory
{
    public class HamburguesaDePescado : Hamburguesa
    {
        public override void Preparar()
        {
            Console.WriteLine("Se preparó una hamburguesa de pescado");
        }
    }
}
