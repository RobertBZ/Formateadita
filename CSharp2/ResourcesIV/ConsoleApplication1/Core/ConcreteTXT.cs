using System;
using Model;
using Model.MapTXT;
using System.Collections.Generic;

namespace Core
{
    public class ConcreteTXT : AbstractRegistry
    {
        public override IEnumerable<Career> GetCareers()
        {
            return new Registry<Career>(new CareerMap());
        }

        public override IEnumerable<Professor> GetProfessors()
        {
            return new Registry<Professor>(new ProfessorMap());
        }

        public override IEnumerable<Student> GetStudents()
        {
            return new Registry<Student>(new StudentMap());
        }
    }
}
