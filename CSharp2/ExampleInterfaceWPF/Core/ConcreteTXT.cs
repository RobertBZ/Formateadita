using Entity;
using Entity.MapTXT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ConcreteTXT : AbstractRegistry
    {
        //Envia un modelo Career, para obtener el mapeado de datos de Carreras.txt
        public override IEnumerable<Career> GetCareers()
        {
            return new UtilFiles<Career>(new CareerMapTxt()).GetTxt();
        }

        //Envia un modelo Professor, para obtener el mapeado de datos de Docentes.txt
        public override IEnumerable<Professor> GetProfessors()
        {
            return new UtilFiles<Professor>(new ProfessorMapTxt()).GetTxt();
        }

        //Envia un modelo Student, para obtener el mapeado de datos de Estudiantes.txt
        public override IEnumerable<Student> GetStudents()
        {
            return new UtilFiles<Student>(new StudentMapTxt()).GetTxt();
        }
    }
}
