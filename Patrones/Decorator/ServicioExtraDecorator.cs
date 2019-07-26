namespace Patrones.Decorator
{
    public abstract class ServicioExtraDecorator : IHabitación
    {
        protected IHabitación Habitación;
        public string Nombre { get; set; }

        public ServicioExtraDecorator(IHabitación habitación)
        {
            Habitación = habitación;
        }

        public abstract IHabitación Reservar();
    }
}
