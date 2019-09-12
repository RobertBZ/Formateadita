using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoria_24_04_2019
{
    class Program
    {
        static void Division(int number1, ref int number2, out int cos,out int res)
        {
            cos = 0;
            for(int pivot = 0;
                number1 >= number2;
                number1 -=number2)
            {
                cos++;
            }
            res = number1;
        }
        static bool IsPrime(int number1)
        {
            bool ctrl = true;
            int cos, res;
            for(int number2 = number1-1;number2>1;number2--)
            {
                Division(number1, ref number2, out cos, out res);
                if (res == 0)
                {
                    ctrl = false;
                }
            }
            if (ctrl)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            for(int num = Convert.ToInt32(Console.ReadLine()); num>1;num--)
            {
                if (IsPrime(num))
                {
                    Console.Write("{0}  ", num);
                }
            }
            Console.ReadKey();
        }
    }
}
