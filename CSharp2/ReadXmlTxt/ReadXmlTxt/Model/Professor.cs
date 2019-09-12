using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReadXmlTxt.Model
{
    [XmlRoot("Professor")]
    public class Professor : IModel
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("Lastname")]
        public string Lastname { get; set; }
        [XmlElement("Code")]
        public string Code { get; set; }
    }
}
