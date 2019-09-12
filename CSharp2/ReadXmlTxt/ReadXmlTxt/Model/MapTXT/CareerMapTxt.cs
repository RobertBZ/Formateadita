using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReadXmlTxt.Model.MapTXT
{
    public class CareerMapTxt : AbstractMap
    {
        public CareerMapTxt()
        {
            Root = @"Resources\Text_Files\Carreras.txt";
        }

        public override IModel GetFormatXml(XElement element)
        {
            throw new NotImplementedException();
        }

        public override IModel ToModel(string str)
        {
            var split = str.Split('/');
            return new Career
            {
                Id = int.Parse(split[0]),
                Code = split[1],
                Name = split[2]
            };
        }
    }
}
