using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public abstract class AbstractRegistry
    {
        // Inicia funciones abstractas de Get para los distintos tipos de modelos
        public abstract IEnumerable<Student> GetStudents();
        public abstract IEnumerable<Career> GetCareers();
        public abstract IEnumerable<Professor> GetProfessors();
    }
}
