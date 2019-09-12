using Model;
using Model.MapTXT;

namespace Core
{
    public class ConcreteTXT : AbstractRegistry
    {
        public override Registry<IModel> GetCareers()
        {
            return new Registry<Career>();
        }

        public override Registry<IModel> GetStudents()
        {
            return new Registry<Student>();
        }
    }
}
