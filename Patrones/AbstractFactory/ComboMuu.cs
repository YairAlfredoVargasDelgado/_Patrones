using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.AbstractFactory
{
    public class ComboMuu : IComboFactory
    {
        public Frito CrearFrito()
        {
            PapasFritas p = new PapasFritas();
            p.Preparar();
            return p;
        }

        public Hamburguesa CrearHamburguesa()
        {
            HamburguesaDeRes h = new HamburguesaDeRes();
            h.Preparar();
            return h;
        }

        public Bebida ServirBebida()
        {
            CocaCola c = new CocaCola();
            c.Servir();
            return c;
        }
    }
}
