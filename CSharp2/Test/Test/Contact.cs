using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Contact : DocumentText
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int IdCareer { get; set; }
        internal bool IsInit = false;
        internal bool IsEnd = false;
        public override void GetData(string str)
        {
            if(VerificInit(str))
            { }
            else
            {
                Console.WriteLine(IsInit);
                if (VerificEnd(str))
                { }
                else
                {
                    if (IsEnd.Equals(false) && IsInit.Equals(true))
                    {
                        var split = str.Split('/');
                        Id = int.Parse(split[0]);
                        Name = split[1];
                        LastName = split[2];
                        Age = int.Parse(split[3]);
                        IdCareer = int.Parse(split[4]);
                    }
                }
            }
        }
        public bool VerificInit(string str)
        {
            if(str.Equals("CONTACTO"))
                IsInit = true;
            return IsInit;
        }
        public bool VerificEnd(string str)
        {
            if (str.Equals("==================="))
                IsEnd = true;
            return IsEnd;
        }
    }
}
