using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> dic = new Dictionary<char, string>();
            dic.Add('a', "se lee A");
            dic.Add('b', "Se lee b");
            Console.ReadKey();
        }
    }
}
