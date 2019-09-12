using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> primes = GetPrimes(30).ToList();
            foreach (int prime in primes)
            {
                Console.WriteLine(prime);
            }*/
            Registry<Student> registry = new Registry<Student>();
            foreach (var item in registry)
            {
                Console.WriteLine(item);
            }
            

            Console.ReadKey();
        }
    }
}
