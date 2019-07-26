using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.State
{
    public class Enamorado : IPersonaState
    {
        public void Desenamorarse()
        {
            Console.WriteLine("No eres tú soy yo");
        }

        public void Enamorarse()
        {
            Console.WriteLine("Estoy muy enamorado");
        }
    }
}
