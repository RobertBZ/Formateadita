using ReadXmlTxt.Model;
using ReadXmlTxt.Model.MapTXT;
using ReadXmlTxt.Model.MapXML;
using System.Collections.Generic;

namespace ReadXmlTxt.Core
{
    public class ConcreteXML : AbstractRegistry
    {
        public override IEnumerable<Career> GetCareers()
        {
            return new UtilFiles<Career>(new CareerMapXml()).GetXml();
        }

        public override IEnumerable<Professor> GetProfessors()
        {
            return new UtilFiles<Professor>(new ProfessorMapXml()).GetXml();
        }
        
        public override IEnumerable<Student> GetStudents()
        {
            return new UtilFiles<Student>(new StudentMapXml()).GetXml();
        }
    }
}
