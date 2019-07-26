using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.State
{
    public class Desenamorado : IPersonaState
    {
        public void Desenamorarse()
        {
            Console.WriteLine("♪ ♫ ♬ Que viva la soltería ♪ ♫ ♬");
        }

        public void Enamorarse()
        {
            Console.WriteLine("Siempre es bueno intentarlo otra vez");
        }
    }
}
