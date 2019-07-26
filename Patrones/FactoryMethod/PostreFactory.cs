namespace Patrones.FactoryMethod
{
    public abstract class PostreFactory<TPostre> where TPostre : BasePostre, new()
    {
        public TPostre PrepararPostre()
        {
            TPostre p = new TPostre();
            p.Preparar();
            return p;
        }
    }
}
