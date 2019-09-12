namespace Model
{
    public class Student : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string CareerCode { get; set; }

        public string Root { get; protected set; }

        public override string ToString()
        {
            return string.Format("{0} {1}({2})", Name, Lastname, Age);
        }
    }
}
