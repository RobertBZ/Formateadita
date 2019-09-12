using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieFibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate c = new Calculate();
            c.Calculator(10);

            Console.ReadKey();

        }
    }
}
