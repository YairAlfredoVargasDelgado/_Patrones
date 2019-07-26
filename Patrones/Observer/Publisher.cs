using System.Collections.Generic;

namespace Patrones.Observer
{
    public class Publisher
    {
        protected IList<ISubscriber> subscribers = new List<ISubscriber>();

        public void Subscribe(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public virtual void Notify<TNotification>(TNotification mensaje)
        {
            foreach (ISubscriber subscriber in subscribers)
            {
                subscriber.Update(mensaje);
            }
        }

    }
}
