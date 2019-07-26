using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Facade
{
    public class Cuenta
    {
        public string Número { get; set; }

        public float Fondos { get; set; }

        public bool Transferir(float monto, Cuenta cuenta)
        {
            if (!FondosInsuficientes(monto, this))
            {
                cuenta.Fondos += monto;
                Fondos -= monto;
                return true;
            }
            return false;
        }

        public static bool FondosInsuficientes(float monto, Cuenta cuenta)
        {
            return cuenta.Fondos < monto;
        }

        public Cuenta() { }
    }
}
