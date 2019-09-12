using ReadXmlTxt.Model;
using ReadXmlTxt.Model.MapTXT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadXmlTxt.Core
{
    public class ConcreteTXT : AbstractRegistry
    {
        public override IEnumerable<Career> GetCareers()
        {
            return new UtilFiles<Career>(new CareerMapTxt()).GetTxt();
        }

        public override IEnumerable<Professor> GetProfessors()
        {
            return new UtilFiles<Professor>(new ProfessorMapTxt()).GetTxt();
        }

        public override IEnumerable<Student> GetStudents()
        {
            return new UtilFiles<Student>(new StudentMapTxt()).GetTxt();
        }
    }
}
