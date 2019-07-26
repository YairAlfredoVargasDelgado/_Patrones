using Patrones.Facade;
using System;
using System.Collections.Generic;

namespace Patrones.Observer
{
    public class Cliente : ISubscriber
    {
        public IList<Producto> listaDeDeseos { get; set; }

        public Cliente()
        {
            listaDeDeseos = new List<Producto>();
        }

        public void Update<TNotification>(TNotification notification)
        {

        }
    }
}
