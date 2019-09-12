using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iherent
{
    class Dougther : Pather
    {
        public Dougther(string name, string lastname)
            : base(name, lastname)
        { }

        public override void PrepareYourSelf()
        {
            base.PrepareYourSelf();
            Console.WriteLine("Maquillarse");
        }
    }
}
