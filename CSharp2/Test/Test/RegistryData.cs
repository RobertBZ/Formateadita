using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class RegistryData<T> : IEnumerator<T> where T : DocumentText, new()
    {
        private StreamReader File { get; set; }
        private T current;
        public RegistryData()
        {
            current = new T();
            File = new StreamReader("Datos.txt");
        }
        public T Current
        {
            get { return current; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public void Dispose()
        {
            File.Close();
            File.Dispose();
        }

        public bool MoveNext()
        {
            var line = File.ReadLine();
            if (line != null)
                Current.GetData(line);
            return line != null;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
