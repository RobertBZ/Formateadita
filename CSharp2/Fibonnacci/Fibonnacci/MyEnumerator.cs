using Fibonnaci;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnacci
{
    public class MyEnumerator<T> : IEnumerator<T> where T: AbstractRegression, new()
    {
        public int Quantity { get; private set; }

        public T Current
        {
            get;
        }

        object IEnumerator.Current
        {
            get 
            {
                return Current;
            }
        }

        public MyEnumerator(int quantity)
        {
            Quantity = quantity;
            Current = new T();
        }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            return Current.GetNext(Quantity);
        }

        public void Reset()
        {
            
        }
    }
}
