using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Singleton
{
    public class UnitOfWork
    {
        private DbContext context;

        private static Lazy<UnitOfWork> instance = new Lazy<UnitOfWork>();

        public PersonaRepository PersonaRepository;
        public ProductoRepository ProductoRepository;

        public static UnitOfWork Instance
        {
            get
            {
                return instance.Value;
            }
        }

        private UnitOfWork() { }
    }
}
