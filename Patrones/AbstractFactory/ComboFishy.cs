using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.AbstractFactory
{
    public class ComboFishy : IComboFactory
    {
        public Frito CrearFrito()
        {
            YucaFrita f = new YucaFrita();
            f.Preparar();
            return f;
        }

        public Bebida ServirBebida()
        {
            AguaDePanela a = new AguaDePanela();
            a.Servir();
            return a;
        }

        public Hamburguesa CrearHamburguesa()
        {
            HamburguesaDePescado h = new HamburguesaDePescado();
            h.Preparar();
            return h;
        }
    }
}
