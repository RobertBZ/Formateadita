namespace Model.AbstractModel
{
    public abstract class AbstractCareer : IModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Root { get; protected set; }

        public abstract void ToModel(string str);       

        public override string ToString()
        {
            return string.Format("{0}({1})", Name, Code);
        }
    }
}
