using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iherent
{
    class Program
    {
        static void DescribeMorning(Pather instance)
        {
            Console.WriteLine("{0} {1} se: ",instance.Name, instance.LastName);
            instance.PrepareYourSelf();
        }
        static void Main(string[] args)
        {
            Son rodrigo = new Son("Rodrigo", "Vargas");
            Dougther natalia = new Dougther("Natalia", "Vargas");
            Grandchild juan = new Grandchild("Juan", "Vargas");
            DescribeMorning(rodrigo);
            Console.WriteLine(" ============================== ");
            DescribeMorning(natalia);
            Console.WriteLine(" ============================== ");
            DescribeMorning(juan);
            Console.ReadKey();
        }
    }
}
