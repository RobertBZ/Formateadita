using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTexts
{
    public class Student : AbstractTxt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }
        public string Cellphone { get; set; }
        public string Email { get; set; }
        public int IdCareer { get; set; }
        public int IdAdress { get; set; }
        public const string text = "Students.txt";
        /*public Student(string str)
        {
            var split = str.Split('/');
            Id = int.Parse(split[0]);
            Name = split[1];
            Lastname = split[2];
            Birthday = Convert.ToDateTime(split[3]);
            Cellphone = split[4];
            Email = split[5];
            IdCareer = int.Parse(split[6]);
            IdAdress = int.Parse(split[7]);
        }*/
        /*public Student(int id, string name, string lastname, DateTime birthday, string cellphone, string email, int idcareer, int idadress)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
            Birthday = birthday;
            Cellphone = cellphone;
            Email = email;
            IdCareer = idcareer;
            IdAdress = idadress;
        }*/
        /*public override string[] data(string split)
        {
            return new Student(
            Id = int.Parse(split[0]),
            Name = split[1],
            Lastname = split[2],
            Birthday = Convert.ToDateTime(split[3]),
            Cellphone = split[4],
            Email = split[5],
            IdCareer = int.Parse(split[6]),
            IdAdress = int.Parse(split[7]));
        }*/
    }
}
