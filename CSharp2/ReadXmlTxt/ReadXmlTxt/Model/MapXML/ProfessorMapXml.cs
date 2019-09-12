using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReadXmlTxt.Model.MapXML
{
    public class ProfessorMapXml : AbstractMap
    {
        public ProfessorMapXml()
        {
            Root = @"Resources\XML_Files\Docentes.xml";
        }

        public override IModel GetFormatXml(XElement element)
        {
            throw new NotImplementedException();
        }

        public override IModel ToModel(string str)
        {
            throw new NotImplementedException();
        }
    }
}
