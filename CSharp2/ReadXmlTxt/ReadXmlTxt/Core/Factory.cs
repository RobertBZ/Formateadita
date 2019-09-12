using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadXmlTxt.Core
{
    public class Factory<T> where T : AbstractRegistry, new()
    {
        public T Get()
        {
            return new T();
        }
    }
}
