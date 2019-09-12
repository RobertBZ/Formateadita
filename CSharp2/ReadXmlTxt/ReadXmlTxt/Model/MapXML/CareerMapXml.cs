using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ReadXmlTxt.Model.MapXML
{
    public class CareerMapXml : AbstractMap
    {
        public CareerMapXml()
        {
            Root = @"Resources\XML_Files\Carreras.xml";
        }

        public override IModel ToModel(string str)
        {
            throw new NotImplementedException();
        }

        public override IModel GetFormatXml(XElement element)
        {
            throw new NotImplementedException();
        }
    }
}
