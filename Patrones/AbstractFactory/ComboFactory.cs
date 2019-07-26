namespace Patrones.AbstractFactory
{
    public interface IComboFactory
    {
        Hamburguesa CrearHamburguesa();

        Bebida ServirBebida();

        Frito CrearFrito();
    }
}
