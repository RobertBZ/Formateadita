using Model.AbstractModel;
using System;

namespace Model.MapXML
{
    public class Student : AbstractStudent
    {
        public Student()
        {
            Root = "Estudiantes.txt";
        }

        public override void ToModel(string str)
        {
            var split = str.Split('/');
            Id = 1;
            Name = "";
            Lastname = "";
            Age = 18;
            CareerCode = "TT";
        }
    }
}
