using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Career : IModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Root { get; set; }
        public Career()
        {
            Root = "Estudiantes.txt";
        }
        public void ToModel(string str)
        {
            var split = str.Split('/');
            Id = int.Parse(split[0]);
            Code = split[1];
            Name = split[2];
        }
    }
}
