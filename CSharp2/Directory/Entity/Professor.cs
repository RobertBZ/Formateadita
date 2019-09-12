using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entity
{
    public class Professor : IModel
    {
        [XmlIgnore]
        public List<string> Properties { get; set; }
        public Professor()
        {
            Properties = new List<string>
            {
                "Id",
                "Nombre",
                "Apellido",
                "Codigo"
            };
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Code { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Name, Lastname);
        }
    }
}
