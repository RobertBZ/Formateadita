using System.Collections.Generic;
using System.Xml.Serialization;

namespace Entity
{
    public class Career : IModel
    {
        [XmlIgnore]
        public List<string> Properties { get; set; }
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }     

        public override string ToString()
        {
            return string.Format("{0}({1})", Name, Code);
        }
    }
}
