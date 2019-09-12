using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entity.MapTXT
{
    public class CareerMapTxt : AbstractMap
    {
        public CareerMapTxt()
        {
            // ****** Variables de uso externo, con valores propios de la Clase
            // Indica la ruta del archivo
            Root = @"Resources\Text_Files\Carreras.txt";
        }

        // Retorna una Instancia de la Clase Career con los valores del archivo asignado Carreras.txt
        public override IModel ToModel(string str)
        {
            var split = str.Split('/');
            return new Career
            {
                Id = int.Parse(split[0]),
                Code = split[1],
                Name = split[2]
            };
        }

        // Metodo sin Uso para esta clase
        public override IModel GetFormatXml(XElement element)
        {
            throw new NotImplementedException();
        }
    }
}
