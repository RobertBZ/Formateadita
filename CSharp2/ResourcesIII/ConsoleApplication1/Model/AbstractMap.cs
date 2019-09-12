namespace Model
{
    public abstract class AbstractMap
    {
        public string Root { get; protected set; }
        public abstract IModel ToModel(string str);
    }
}
