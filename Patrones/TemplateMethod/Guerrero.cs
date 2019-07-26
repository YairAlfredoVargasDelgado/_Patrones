using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.TemplateMethod
{
    public class Guerrero : NonPlayableCharacter
    {
        public override void RecogerRecursos()
        {
            Console.WriteLine("El guerreno no puede recoger recursos");
        }

        public override void ConstruirEstructura()
        {
            Console.WriteLine("El guerrero no puede construir estructuras");
        }
    }
}
