using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Division(int number1, int number2, out int cos, out int res)
        {
            cos = 0;
            for (int pivot = 0; number1 >= number2 ; number1 -= number2) // number1 == numer1 -number2
            {
                cos++;
            }
            res = number1;
        }
        static void Main(string[] args)
        {
            int cos, res;
            Division(10, 3, out cos, out res);
            Console.WriteLine("Cosciente: {0}, Residui: {1}",cos, res);
            Console.ReadKey();
        }
    }
}
