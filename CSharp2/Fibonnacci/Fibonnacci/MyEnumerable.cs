using Fibonnaci;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnacci
{
    public class MyEnumerable<T> : IEnumerable<T> where T : AbstractRegression, new()
    {
        public int Quantity { get; private set; }
        public MyEnumerable(int quantity)
        {
            Quantity = quantity;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyEnumerator<T>(Quantity);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
