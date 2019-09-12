using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersPr
{
    class Program
    {
        static void Calculate(ref int Mount, out int calcule, out int aux)
        {
            calcule = 0;
            aux = 0;
            for (int i = 2; i <= Mount; i++)
            {
                calcule = i / 2;
                aux = calcule;
                if (calcule != 0)
                {
                    Console.Write("{0} - ", calcule);
                }
            }
        }
        static void Main(string[] args)
        {
            int Mount = 10, calcule, aux;
            Calculate(ref Mount,out calcule, out aux);
            Console.ReadKey();
        }
    }
}
