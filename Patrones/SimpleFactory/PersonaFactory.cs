using System;

namespace Patrones.SimpleFactory
{
    public class PersonaFactory : BaseFactory<Persona>
    {
        public PersonaFactory() : base(new Persona()
        {
            NombreCompleto = "No definido",
            NúmeroDeIdentificación = "No definido",
            Edad = 0,
            Género = 'I'
        }) { }

        public PersonaFactory NúmeroDeIdentificación(string númeroDeIdentificación)
        {
            Entity.NúmeroDeIdentificación = númeroDeIdentificación;
            return this;
        }

        public PersonaFactory NombreCompleto(string nombreCompleto)
        {
            Entity.NombreCompleto = nombreCompleto;
            return this;
        }

        public PersonaFactory Edad(uint edad)
        {
            Entity.Edad = edad;
            return this;
        }

        public PersonaFactory Género(char género)
        {
            Entity.Género = género;
            return this;
        }
    }
}
