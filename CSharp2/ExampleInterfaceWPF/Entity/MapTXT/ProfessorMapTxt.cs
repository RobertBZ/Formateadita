using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entity.MapTXT
{
    public class ProfessorMapTxt : AbstractMap
    {
        public ProfessorMapTxt()
        {
            // ****** Variables de uso externo, con valores propios de la Clase
            // Indica la ruta del archivo
            Root = @"Resources\Text_Files\Docente.txt";
        }

        // Retorna una Instancia de la Clase Career con los valores del archivo asignado Docente.txt
        public override IModel ToModel(string str)
        {
            var split = str.Split('-');
            return new Professor
            {
                Id = int.Parse(split[0]),
                Name = split[1],
                Lastname = split[2],
                Code = split[3]
            };
        }

        // Metodo sin Uso para esta clase
        public override IModel GetFormatXml(XElement element)
        {
            throw new NotImplementedException();
        }
    }
}
