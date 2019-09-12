using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTexts
{
    public abstract class AbstractTxt
    {
        public AbstractTxt() { }
        /*public virtual string[] TextController(string str,string type)
        {
            var split = str.Split('/');
            if (type.Equals("Students.txt"))
                return data(split.ToString());
            if (type.Equals("Careers.txt"))
                return data(split.ToString());
        }*/
        //public abstract string data(string split);
        public void TextController(string str,string text)
        {
            var split = str.Split('/');
            if (text.Equals("Students.txt"))
            {
                Student e = new Student();
                e.Id = int.Parse(split[0]);
                e.Name = split[1];
                e.Lastname = split[2];
                e.Birthday = Convert.ToDateTime(split[3]);
                e.Cellphone = split[4];
                e.Email = split[5];
                e.IdCareer = int.Parse(split[6]);
                e.IdAdress = int.Parse(split[7]);
            }
        }
    }
}
