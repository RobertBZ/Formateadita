using System;
using Model;
using Model.MapTXT;

namespace Core
{
    public class ConcreteTXT : AbstractRegistry
    {
        public override Registry<Career> GetCareers()
        {
            return new Registry<Career>(new CareerMap());
        }

        public override Registry<Professor> GetProfessors()
        {
            return new Registry<Professor>(new ProfessorMap());
        }

        public override Registry<Student> GetStudents()
        {
            return new Registry<Student>(new StudentMap());
        }
    }
}
