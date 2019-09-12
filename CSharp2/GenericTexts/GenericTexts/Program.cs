using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTexts
{
    class Program
    {
        static void Main(string[] args)
        {
            var clas = new MyEnumerable<Student>("Students.txt");
            foreach (var item in clas)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
