using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entity
{
    // Inicializa el nombre de la ruta que contendra el archivo
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
    }
}
