using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance;
            Console.WriteLine(s1.message);

            Singleton.Instance.message = "Singleton esta en uso 2";
            Console.WriteLine(s1.message);

            Console.ReadKey();
        }
    }
}
