using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Student : IModel
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public string Lastname { get; private set; }
        public int Age { get; private set; }
        public Career Career { get; set; }
        public string Root { get; set; }

        public void ToModel(string str)
        {
            var split = str.Split('/');
            Id = int.Parse(split[0]);
            Name = split[1];
            Lastname = split[2];
            Age = int.Parse(split[3]);
        }
        public Student()
        {
            Root = "Estudaintes.txt";
        }
    }
}
