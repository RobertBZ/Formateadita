using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Entity.MapXML
{
    public class StudentMapXml : AbstractMap
    {
        public StudentMapXml()
        {
            // ****** Variables de uso externo, con valores propios de la Clase
            // Indica La lista que contendra el archivo Xml
            KeyGroup = "Students";
            // Indica el tipo de Instancia que tendra la lista
            KeySingle = "Student";
            // Indica la ruta del archivo
            Root = @"C:\Users\Robert\Desktop\USIP\CSharp2\ExampleInterfaceWPF\ExampleInterfaceWPF\Resources\XML_Files\Estudiantes.xml";
        }

        // Retorna una Instancia de la Clase Student con los valores del archivo Estudiantes.xml
        public override IModel GetFormatXml(XElement element)
        {
            return new Student
            {
                Id = int.Parse(element.Attribute("id").Value),
                Name = element.Element("Name").Value,
                Lastname = element.Element("Lastname").Value,
                Age = int.Parse(element.Element("Age").Value),
                CareerCode = element.Element("CareerCode").Value
            };
        }

        // Metodo sin Uso para esta clase
        public override IModel ToModel(string str)
        {
            throw new NotImplementedException();
        }
    }
}
