using Model.AbstractModel;

namespace Model.MapTXT
{
    public class Student : AbstractStudent, IModel
    {
        public Student()
        {
            Root = "Estudiantes.txt";
        }

        public override void ToModel(string str)
        {
            var split = str.Split('/');
            Id = int.Parse(split[0]);
            Name = split[1];
            Lastname = split[2];
            Age = int.Parse(split[3]);
            CareerCode = split[4];
        }
    }
}
