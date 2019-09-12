using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Dummy
    {
        public delegate int Subtract(int number);
        public Subtract Methods;

        public void Execute()
        {
            foreach (var method in Methods.GetInvocationList())
            {
                Console.WriteLine(method.DynamicInvoke(15));
            }
        }
    }
    class Program
    {
        
        public static int Addfifteen(int number)
        {
            return number + 15;
        }
        static void Main(string[] args)
        {
            Dummy dummy = new Dummy();
            dummy.Methods += delegate (int number)
            {
                return number + 10;
            };
            
            dummy.Methods += Addfifteen;

            dummy.Methods += x => x + 5;

            dummy.Methods -= Addfifteen;

            dummy.Execute();
            Console.ReadKey();
        }
    }
}
