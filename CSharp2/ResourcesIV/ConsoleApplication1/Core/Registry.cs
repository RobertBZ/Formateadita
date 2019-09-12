using Model;
using System.Collections;
using System.Collections.Generic;

namespace Core
{
    public class Registry<T> : IEnumerable<T> where T: IModel, new()
    {
        public AbstractMap Map { get; set; }
        
        public Registry(AbstractMap map)
        {
            Map = map;            
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new RegistryPivot<T>(Map);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
