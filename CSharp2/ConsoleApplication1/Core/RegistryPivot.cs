using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class RegistryPivot<T> : IEnumerator<T> where T : IModel, new() // public class RegistryPivot<T> : IEnumerator<T>  // Where T : IModel , new ()
    {
        private StreamReader File { get; set; }
        public RegistryPivot()
        {
            File = new StreamReader(@"Resources\Text_Files\Estudiantes.txt");
        }

        private T current;
        public T Current
        {
            get
            {
                return current;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return this;
            }
        }

        T IEnumerator<T>.Current => throw new NotImplementedException();

        public void Dispose()
        {
            File.Close();
            File.Dispose();
        }

        public bool MoveNext()
        {
            var line = File.ReadLine();
            if (line != null)
                current = new T();
                current.ToModel(line);
            return line != null;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
