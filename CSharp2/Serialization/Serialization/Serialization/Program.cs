using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var person = new Serializer<Person>();
            var career = new Serializer<Career>();
            var data = new Data
            {
                People = new List<Person>
                {
                    person.ToObject()
                },
                Careers = new List<Career>
                {
                    career.ToObject()
                }
            };*/
           
            Serializer<Data> serializer = new Serializer<Data>();
            var data = serializer.ToObject();

            foreach (var item in data.People)
            {
                Console.WriteLine(item);
            }

            /*foreach (var item in data.Careers)
            {
                Console.WriteLine(item);
            }*/


            Console.ReadKey();
        }
    }
}
