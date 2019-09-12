using Entity;
using Entity.MapXML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ConcreteXML : AbstractRegistry
    {
        //Envia un modelo Career, para obtener el mapeado de datos de Carreras.xml
        public override IEnumerable<Career> GetCareers()
        {
            return new UtilFiles<Career>(new CareerMapXml()).GetXml();
        }

        //Envia un modelo Professor, para obtener el mapeado de datos de Docentes.xml
        public override IEnumerable<Professor> GetProfessors()
        {
            return new UtilFiles<Professor>(new ProfessorMapXml()).GetXml();
        }

        //Envia un modelo Student, para obtener el mapeado de datos de estudiantes.xml
        public override IEnumerable<Student> GetStudents()
        {
            return new UtilFiles<Student>(new StudentMapXml()).GetXml();
        }
    }
}
