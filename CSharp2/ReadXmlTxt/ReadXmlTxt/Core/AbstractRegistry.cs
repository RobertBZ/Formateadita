using ReadXmlTxt.Model;
using System;
using System.Collections.Generic;
namespace ReadXmlTxt.Core
{
    public abstract class AbstractRegistry
    {
        public abstract IEnumerable<Student> GetStudents();
        public abstract IEnumerable<Career> GetCareers();
        public abstract IEnumerable<Professor> GetProfessors();
    }
}
