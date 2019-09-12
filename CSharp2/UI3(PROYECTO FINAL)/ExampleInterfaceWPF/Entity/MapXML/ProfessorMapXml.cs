using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entity.MapXML
{
    public class ProfessorMapXml : AbstractMap
    {
        public ProfessorMapXml()
        {
            // ****** Variables de uso externo, con valores propios de la Clase
            // Indica La lista que contendra el archivo Xml
            KeyGroup = "Professors";
            // Indica el tipo de Instancia que tendra la lista
            KeySingle = "Professor";
            // Indica la ruta del archivo
            Root = @"C:\Users\Robert\Desktop\USIP\CSharp2\ExampleInterfaceWPF\ExampleInterfaceWPF\Resources\XML_Files\Docentes.xml";
        }

        // Retorna una Instancia de la Clase Professor con los valores del archivo asignado Docentes.xml
        public override IModel GetFormatXml(XElement element)
        {
            return new Professor
            {
                Id = int.Parse(element.Attribute("id").Value),
                Name = element.Element("Name").Value,
                Lastname = element.Element("Lastname").Value,
                Code = element.Element("Code").Value
            };
        }

        // Metodo sin Uso para esta clase
        public override IModel ToModel(string str)
        {
            throw new NotImplementedException();
        }
    }
}
