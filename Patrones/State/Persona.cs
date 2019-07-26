using Patrones.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones
{
    public class Persona
    {
        public string Nombre { get; set; }

        public IPersonaState Estado { get; set; }

        public Persona(IPersonaState estadoInicial)
        {
            Estado = estadoInicial;
        }
        
        public void CambiarDeEstado(IPersonaState estado)
        {
            this.Estado = estado;
        }
    }
}
