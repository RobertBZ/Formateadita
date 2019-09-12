using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTexts
{
    class MyEnumerator<T> : IEnumerator<T> where T : AbstractTxt, new()
    {
        private T current;
        private string Text { get; set; }
        private StreamReader File { get; set; }
        public MyEnumerator(String text)
        {
            Text = text;
            File = new StreamReader(Text);
        }
        public T Current
        {
            get { return current; }
        }
        object IEnumerator.Current
        {
            get { return this; }
        }

        public void Dispose()
        {
            File.Close();
            File.Dispose();
        }

        public bool MoveNext()
        {
            var line = File.ReadLine();
            Console.WriteLine(line);
            if (line != null)
                current.TextController(line,Text);
            return line != null;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
