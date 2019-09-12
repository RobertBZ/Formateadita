using Model;
using Model.MapXML;

namespace Core
{
    public class ConcreteXML : AbstractRegistry
    {
        public override Registry<IModel> GetCareers()
        {
            return new Registry<IModel>();
        }

        public override Registry<IModel> GetStudents()
        {
            return new Registry<IModel>();
        }
    }
}
