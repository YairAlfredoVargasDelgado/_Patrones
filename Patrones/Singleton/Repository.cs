using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Singleton
{
    public interface IRepository<TEntity>
    {
        void Add(TEntity entity);
        void Delete(int id);
        void Update(TEntity entity);
        IEnumerable<TEntity> Select();
    }
}
