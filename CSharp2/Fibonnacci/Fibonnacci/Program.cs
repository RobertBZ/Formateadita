using Fibonnaci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonnaci = new MyEnumerable<USIPRegression>(10);
            foreach (var item in fibonnaci)
            {
                Console.Write("{0}, ", item.Current);
            }

            Console.ReadKey();
        }
    }
}
