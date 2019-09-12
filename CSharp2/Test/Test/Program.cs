using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var registryContact = new Registry<Contact>();
            var registryUniversity = new Registry<University>();
            var registryCareer = new Registry<Career>();

            List<Contact> Contacts = new List<Contact>();
            List<University> Universitys = new List<University>();
            List<Career> Career = new List<Career>();

            foreach (var c in registryContact)
            {
                Console.WriteLine(c.Name);
                Contacts.Add(c);
            }
            foreach (var u in registryUniversity)
            {
                Universitys.Add(u);
            }
            foreach (var e in registryCareer)
            {
                Career.Add(e);
            }
            Console.ReadKey();
        }
    }
}
