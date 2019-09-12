using Model;

namespace Core
{
    public abstract class AbstractRegistry
    {
        public abstract Registry<Student> GetStudents();
        public abstract Registry<Career> GetCareers();
        public abstract Registry<Professor> GetProfessors();
    }
}
