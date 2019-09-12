using ReadXmlTxt.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadXmlTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            var registry = new Factory<ConcreteTXT>().Get().GetCareers();
            foreach (var item in registry)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
