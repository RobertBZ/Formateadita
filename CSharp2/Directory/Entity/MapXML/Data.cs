using System.Collections.Generic;
using System.Xml.Serialization;

namespace Entity.MapXML
{
    [XmlRoot("Data")]
    public class Data : IModel
    {
        [XmlIgnore]
        public int Id { get; }
        [XmlIgnore]
        public List<string> Properties { get; set; }

        public List<Career> Careers { get; set; }
        public List<Professor> Professors { get; set; }

        [XmlArray("Students")]
        [XmlArrayItem("Student")]
        public List<Student> Students { get; set; }
    }
}
