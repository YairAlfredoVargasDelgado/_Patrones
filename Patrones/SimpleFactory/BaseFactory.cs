namespace Patrones.SimpleFactory
{
    public abstract class BaseFactory<TEntity>
    {
        protected BaseFactory(TEntity baseEntity) { Entity = baseEntity; }

        protected TEntity Entity;

        public TEntity Build()
        {
            return Entity;
        }
    }
}
