using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }
        public string Cellphone { get; set; }
        public string Email { get; set; }
        public int IdCareer { get; set; }
        public int IdAddress { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1} {2}", Id, Name, Lastname);
        }
    }
}
