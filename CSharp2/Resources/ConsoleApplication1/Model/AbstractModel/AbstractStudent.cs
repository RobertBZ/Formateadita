namespace Model.AbstractModel
{
    public abstract class AbstractStudent : IModel
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string Lastname { get; protected set; }
        public int Age { get; protected set; }
        public string CareerCode { get; protected set; }

        public string Root { get; protected set; }

        public abstract void ToModel(string str);     

        public override string ToString()
        {
            return string.Format("{0} {1}({2})", Name, Lastname, Age);
        }
    }
}
