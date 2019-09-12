using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD
{
    class MultipleNumber
    {
        public void calculate(int FirstNumber, int SecondNumber)
        {
            int cont = 2;
            int cos = 0,res;
            int 
            List<int> List = new List<int>();
            while(FirstNumber != 1 && SecondNumber != 1)
            {
                for (int pivot = 0;
                FirstNumber >= cont;
                FirstNumber -= cont)
                {
                    cos++;
                }
                res = FirstNumber;
                Console.WriteLine(cos);
                Console.WriteLine(res);
                for (int pivot = 0;
                SecondNumber >= cont;
                SecondNumber -= cont)
                {
                    cos++;
                }
                res = SecondNumber;
                Console.WriteLine(cos);
                Console.WriteLine(res);
            }

            Console.ReadKey();
        }
    }
}
