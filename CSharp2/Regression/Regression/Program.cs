using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regression
{
    class Program
    {
        public static void PrintRegression(AbstractRegression regression)
        {
            regression.Init();
            Console.WriteLine(regression);
        }

        static void Main(string[] args)
        {
            var fibo = new Fibonnacci(1, 1, 8);
            var usip = new USIPcs(0, 1, 8);

            PrintRegression(fibo);
            Console.WriteLine("==============");
            PrintRegression(usip);

            Console.ReadKey();
        }
    }
}
