using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    [XmlRoot("Carrera")]
    public class Career : IModel
    {
        [XmlAttribute("Id")]
        public int Id { get; set; }
        [XmlElement("Nombre")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public string Root()
        {
            return "Carrera.xml";
        }
    }
}
