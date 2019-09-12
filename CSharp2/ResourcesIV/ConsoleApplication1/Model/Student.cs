using System.Xml.Serialization;

namespace Model
{
    [XmlRoot("Student")]
    public class Student : IModel
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("Lastname")]
        public string Lastname { get; set; }
        [XmlElement("Age")]
        public int Age { get; set; }
        [XmlElement("CareerCode")]
        public string CareerCode { get; set; }      
        public override string ToString()
        {
            return string.Format("{0} {1}({2})", Name, Lastname, Age);
        }
    }
}
