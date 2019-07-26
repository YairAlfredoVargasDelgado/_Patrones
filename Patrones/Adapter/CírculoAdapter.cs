using System;

namespace Patrones.Adapter
{
    public class CírculoAdapter : Círculo, IFigura
    {
        public void Mostrar()
        {
            Console.WriteLine(Info());
        }

        public float Área()
        {
            return (float)ObtenerÁrea();
        }
    }
}
