using System;
using System.Collections.Generic;

namespace Patrones.Singleton
{
    public class ProductoRepository : IRepository<Producto>
    {
        public void Add(Producto entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> Select()
        {
            throw new NotImplementedException();
        }

        public void Update(Producto entity)
        {
            throw new NotImplementedException();
        }
    }
}