using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    [XmlRoot("Datos")]
    public class Data : IModel
    {
        [XmlIgnore]
        public int Id { get; set; }

        [XmlArray("Gente")]
        [XmlArrayItem("Persona")]
        public List<Person> People { get; set; }
        [XmlArray("Carreras")]
        [XmlArrayItem("Carrera")]
        public List<Career> Careers { get; set; }

        public string Root()
        {
            return "Data.xml";
        }
    }
}
