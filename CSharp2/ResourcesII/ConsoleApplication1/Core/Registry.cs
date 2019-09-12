using Model;
using System.Collections;
using System.Collections.Generic;

namespace Core
{
    public class Registry<T> : IEnumerable<T> where T: IModel, new()
    {        
        private RegistryPivot<T> Enumerator { get; set; }

        public Registry(AbstractMap map)
        {
            Enumerator = new RegistryPivot<T>(map);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Enumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Enumerator;
        }
    }
}
