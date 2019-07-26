using System;

namespace Patrones.Adapter
{
    public class Círculo
    {
        public float Radio { get; set; }

        public double ObtenerÁrea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public double ObtenerPerímetro()
        {
            return 2 * Math.PI * Radio;
        }

        public string Info()
        {
            return "Es un círculo";
        }
    }
}
