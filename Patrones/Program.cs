using Patrones.AbstractFactory;
using Patrones.State;
using System;

namespace Patrones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Persona p = new Persona(new Enamorado());
            p.Estado.Enamorarse();

            p.CambiarDeEstado(new Desenamorado());
            p.Estado.Desenamorarse();

            Console.ReadLine();
        }
    }
}
