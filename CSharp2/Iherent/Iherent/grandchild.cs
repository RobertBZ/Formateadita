using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iherent
{
    class Grandchild : Pather
    {
        public Grandchild(string name, string lastname)
            : base(name, lastname)
        { }
        public override void PrepareYourSelf()
        {
            Console.WriteLine("Lo Duchan");
            Console.WriteLine("Lo Visten");
        }
    }
}
