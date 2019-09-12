using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersPr2
{
    class Program
    {
        static IEnumerable<int> GetPrimes(int limit)
        {
            for (int pivot = 2; pivot < limit; pivot++)
            {
                if (IsPrime(pivot))
                {
                    yield return pivot;
                }
            }
        }

        static bool IsPrime(int number)
        {
            int cos, res, pivot = 2, limit;
            bool isPrime = true;
            Division(number, pivot, out limit, out res);


            while (isPrime && pivot <= limit)
            {
                Division(number, pivot, out cos, out res);
                isPrime = !(res == 0);
                pivot++;
            }
            return isPrime;
        }

        static void Division(int number1, int number2, out int cos, out int res)
        {
            cos = 0;
            for (int pivot = 0;
                number1 >= number2;
                number1 -= number2) // number1 = number1 - number2 
            {
                cos++;
            }
            res = number1;
        }
        static void Main(string[] args)
        {
            List<int> primes = GetPrimes(30).ToList();
            foreach (int prime in primes)
            {
                Console.WriteLine(prime);
            }

            Console.ReadKey();
        }
    }
}
