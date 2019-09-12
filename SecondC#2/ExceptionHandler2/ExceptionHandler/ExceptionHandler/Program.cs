using ExceptionCore;
using ExceptionCore.Bussiness;
using ExceptionCore.Critical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                try
                {
                    Console.WriteLine("====Menu====");
                    Console.WriteLine("[1] Hacer algo");
                    Console.WriteLine("[2] Hacer algo mas");
                    Console.WriteLine("[0] Salir");

                    if (!int.TryParse(Console.ReadLine(), out option))
                    {
                        throw new InvalidInputException(2);
                    }

                    if (option == 1)
                    {
                        int i = 0;
                        int j = 0;
                        int y = i / j;
                        Console.WriteLine("Una accion");
                    }
                    else if (option == 2)
                    {
                        var list = new List<int>();
                        var x = list[10];
                    }
                }
                catch (Exception exception)
                {
                    AbstractException catched;
                    if (exception is AbstractException)
                    {
                        catched = exception as AbstractException;
                    }
                    else
                    {
                        catched = new CriticalException(exception);
                    }
                    catched.LogException();
                    option = -1;
                }               
            } while (option != 0);           
        }
    }
}
