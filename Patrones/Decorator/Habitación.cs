using System;
using System.Collections.Generic;

namespace Patrones.Decorator
{
    public class Habitación : IHabitación
    {
        public int Número { get; set; }
        public List<ServicioExtraDecorator> ServiciosExtra { get; set; }

        public Habitación(int número)
        {
            Número = número;
            ServiciosExtra = new List<ServicioExtraDecorator>();
        }

        public IHabitación Reservar()
        {
            Console.WriteLine("Se reservó la habitación número " + Número);
            return this;
        }

        public void AgregarServicio(ServicioExtraDecorator servicio)
        {
            ServiciosExtra.Add(servicio);
        }

        public void VerServicios()
        {
            foreach (var s in ServiciosExtra)
            {

            }
        }
    }
}
