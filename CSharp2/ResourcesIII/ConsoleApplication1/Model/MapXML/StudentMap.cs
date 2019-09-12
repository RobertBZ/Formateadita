using System;

namespace Model.MapXML
{
    public class StudentMap : AbstractMap
    {
        public StudentMap()
        {
            Root = "Estudiantes.XML";
        }

        public override IModel ToModel(string str)
        {
            var split = str.Split('/');
            return new Student
            {
                Id = 1,
                Name = "",
                Lastname = "",
                Age = 18,
                CareerCode = "TT",
            };
        }
    }
}
