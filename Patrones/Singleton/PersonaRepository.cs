using System;
using System.Collections.Generic;

namespace Patrones.Singleton
{
    public class PersonaRepository : IRepository<Persona>
    {
        public void Add(Persona entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Persona> Select()
        {
            throw new NotImplementedException();
        }

        public void Update(Persona entity)
        {
            throw new NotImplementedException();
        }
    }
}