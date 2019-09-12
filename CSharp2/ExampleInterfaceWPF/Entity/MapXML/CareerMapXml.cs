using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Entity.MapXML
{
    public class CareerMapXml : AbstractMap
    {
        public CareerMapXml()
        {
            // ****** Variables de uso externo, con valores propios de la Clase
            // Indica La lista que contendra el archivo Xml
            KeyGroup = "Careers";
            // Indica el tipo de Instancia que tendra la lista
            KeySingle = "Career";
            // Indica la ruta del archivo
            Root = @"C:\Users\Robert\Desktop\USIP\CSharp2\ExampleInterfaceWPF\ExampleInterfaceWPF\Resources\XML_Files\Carreras.xml";
        }

        // Retorna una Instancia de la Clase Career con los valores del archivo asignado Carreras.xml
        public override IModel GetFormatXml(XElement element)
        {
            return new Career
            {
                Id = int.Parse(element.Attribute("id").Value),
                Name = element.Element("Name").Value,
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
