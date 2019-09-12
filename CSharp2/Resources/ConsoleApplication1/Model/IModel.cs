namespace Model
{
    public interface IModel
    {
        int Id { get; }
        string Root { get; }
        void ToModel(string str);
    }
}
