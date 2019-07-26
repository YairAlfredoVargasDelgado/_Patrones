namespace Patrones.Decorator
{
    public class ServicioPiscina : ServicioExtraDecorator
    {
        public ServicioPiscina(IHabitación habitación) : base(habitación)
        {
            Nombre = "Piscina";
        }

        public override IHabitación Reservar()
        {
            Habitación.Reservar();
            System.Console.WriteLine("Se agregó el servicio extra piscina");
            return this;
        }
    }
}
