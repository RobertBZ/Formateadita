using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iherent
{
    class Pather
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Pather(string name, string lastname)
        {
            Name = name;
            LastName = lastname;
        }
        public virtual void PrepareYourSelf()
        {
            Console.WriteLine("Ducharse");
            Console.WriteLine("Vestirse");
        }
    }
}
