using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Career : DocumentText
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdUniversity { get; set; }
        internal bool IsInit = false;
        internal bool IsEnd = false;
        public override void GetData(string str)
        {
            if (VerificInit(str))
            { }
            else
            {
                if (VerificEnd(str))
                { }
                else
                {
                    if (IsEnd.Equals(false))
                    {
                        var split = str.Split('/');
                        Id = int.Parse(split[0]);
                        Name = split[1];
                        IdUniversity = int.Parse(split[2]);
                    }
                }
            }
        }
        public bool VerificInit(string str)
        {
            if (str.Equals("CONTACTO"))
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
