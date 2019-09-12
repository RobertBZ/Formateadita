using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    [XmlRoot("Persona")]
    public class Person : IModel
    {
        [XmlAttribute("Id")]
        public int Id { get; set; }
        [XmlElement("Nombre")]
        public string Name { get; set; }
        [XmlElement("Apellido")]
        public string Lastname { get; set; }
        [XmlElement("Nacimiento")]
        public DateTime Birthdate { get; set; }
        [XmlArray("Celulares")]
        [XmlArrayItem("Celular")]
        public List<string> Cellphones { get; set; }
        [XmlText]
        public string Notes { get; set; }
        [XmlIgnore]
        public int Age
        {
            get
            {
                return (DateTime.Today - Birthdate)
                    .Days / 365;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}({2})", 
                Name, Lastname, Age);
        }

        public string Root()
        {
            return "Contacto.xml";
        }
    }
}
