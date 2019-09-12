using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReadXmlTxt.Model
{
    [XmlRoot("Career")]
    public class Career : IModel
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
        [XmlElement("Code")]
        public string Code { get; set; }
        [XmlElement("Name")]
        public string Name { get; set; }
    }
}
