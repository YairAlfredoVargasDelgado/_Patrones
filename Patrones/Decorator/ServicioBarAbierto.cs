using System;

namespace Patrones.Decorator
{
    public class ServicioBarAbierto : ServicioExtraDecorator
    {
        public ServicioBarAbierto(IHabitación habitación) : base(habitación)
        {
            Nombre = "Bar abierto";
        }

        public override IHabitación Reservar()
        {
            Habitación.Reservar();
            Console.WriteLine("Se agregó el servicio extra bar abierto");
            return this;
        }
    }
}
