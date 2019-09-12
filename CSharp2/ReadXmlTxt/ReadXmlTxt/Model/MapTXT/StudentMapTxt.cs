using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReadXmlTxt.Model.MapTXT
{
    public class StudentMapTxt : AbstractMap
    {
        public StudentMapTxt()
        {
            Root = @"Resources\Text_Files\Estudiantes.txt";
        }

        public override IModel GetFormatXml(XElement element)
        {
            throw new NotImplementedException();
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
