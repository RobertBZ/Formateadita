using System.Xml.Serialization;

namespace ReadXmlTxt.Model
{
    [XmlRoot("Student")]
    public class Student : IModel
    {
        [XmlAttribute("id")]
        [XmlElement("Id")]
        public int Id { get; set; }
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("Lastname")]
        public string Lastname { get; set; }
        [XmlElement("Age")]
        public int Age { get; set; }
        [XmlElement("CareerCode")]
        public string CareerCode { get; set; }
    }
}
