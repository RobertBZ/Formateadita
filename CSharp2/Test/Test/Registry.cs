using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Registry<T> : IEnumerable<T> where T : DocumentText, new()
    {
        private RegistryData<T> Content { get; set; }
        public Registry()
        {
            Content = new RegistryData<T>();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return Content;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Content;
        }
    }
}
