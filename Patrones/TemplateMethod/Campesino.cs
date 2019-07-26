using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.TemplateMethod
{
    public class Campesino : NonPlayableCharacter
    {
        public override void Atacar()
        {
            Console.WriteLine("El campesino no puede atacar");
        }
    }
}
