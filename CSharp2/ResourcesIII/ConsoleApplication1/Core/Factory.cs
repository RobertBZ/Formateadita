namespace Core
{
    public class Factory<T> where T : AbstractRegistry, new()
    {
        public T Get()
        {
            return new T();
        }
    }
}
