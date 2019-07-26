using System;

namespace Patrones.Decorator
{
    public class ServicioBufé : ServicioExtraDecorator
    {
        public ServicioBufé(IHabitación habitación) : base(habitación) { Nombre = "Bufé"; }

        public override IHabitación Reservar()
        {
            Habitación.Reservar();
            Console.WriteLine("Se agregó el servicio extra bufé");
            return this;
        }
    }
}
