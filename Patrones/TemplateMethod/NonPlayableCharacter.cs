using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.TemplateMethod
{
    public class NonPlayableCharacter
    {
        public void Turno()
        {
            RecogerRecursos();
            ConstruirEstructura();
            Caminar();
            Atacar();
        }

        public void Luchar()
        {
            Caminar();
            Luchar();
        }

        public virtual void Atacar()
        {
            Console.WriteLine("Atacando");
        }

        public virtual void Caminar()
        {
            Console.WriteLine("Caminando");
        }

        public virtual void RecogerRecursos()
        {
            Console.WriteLine("Recogiendo recursos");
        }

        public virtual void ConstruirEstructura()
        {
            Console.WriteLine("Construyendo estructura");
        }
    }
}
