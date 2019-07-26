namespace Patrones.Observer
{
    public interface ISubscriber
    {
        void Update<TNotification>(TNotification notification);
    }
}