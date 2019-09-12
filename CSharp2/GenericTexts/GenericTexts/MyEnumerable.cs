using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTexts
{
    class MyEnumerable<T> : IEnumerable<T> where T : AbstractTxt, new()
    {
        public string Text { get; set; }
        public MyEnumerable(String text)
        {
            Text = text;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new MyEnumerator<T>(Text);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
