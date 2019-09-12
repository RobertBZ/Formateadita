namespace Model.MapTXT
{
    public class StudentMap : AbstractMap
    {
        public StudentMap()
        {
            Root = @"Text_Files\Estudiantes.txt";
        }

        public override IModel ToModel(string str)
        {
            var split = str.Split('/');
            return new Student
            {
                Id = int.Parse(split[0]),
                Name = split[1],
                Lastname = split[2],
                Age = int.Parse(split[3]),
                CareerCode = split[4]
            };
        }
    }
}
