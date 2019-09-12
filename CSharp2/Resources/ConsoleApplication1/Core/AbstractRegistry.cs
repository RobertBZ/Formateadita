using Model;

namespace Core
{
    public abstract class AbstractRegistry
    {
        public abstract Registry<IModel> GetStudents();
        public abstract Registry<IModel> GetCareers();
    }
}
