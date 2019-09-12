using Model;
using System.Collections;
using System.Collections.Generic;

namespace Core
{
    public class Registry<T> : IEnumerable<T> where T : IModel,new()
    {
        private RegistryPivot<T> Enumerator;

        public Registry()
        {
            Enumerator = new RegistryPivot<T>();           
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
