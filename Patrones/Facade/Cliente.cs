using System.Collections.Generic;

namespace Patrones.Facade
{
    public class Cliente
    {
        public Cuenta Cuenta { get; set; }

        public string Nombre { get; set; }

        public Cliente() { }

        public static bool ClienteRegistrado(Cliente cliente, IEnumerable<Cliente> clientes)
        {
            foreach(Cliente c in clientes)
            {
                if (c.Nombre == cliente.Nombre)
                    return true;
            }
            return false;
        }
    }
}
