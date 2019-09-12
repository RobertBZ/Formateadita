using Entity;
using System.Collections.Generic;

namespace Core
{
    public abstract class AbstractRegistry
    {
        public abstract IEnumerable<Student> GetStudents();
        public abstract IEnumerable<Career> GetCareers();
        public abstract IEnumerable<Professor> GetProfessors();
    }
}
