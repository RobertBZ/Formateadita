using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        public static List<Student> ReadStudents()
        {
            return new List<Student>
            {
                new Student
                {
                    Id = 1,
                    Name = "Jesus",
                    Lastname = "Aguilar",
                    Birthday = new DateTime(1999,5,21),
                    Cellphone = "78954613",
                    Email = "Jesus@gmail.com",
                    IdCareer = 1,
                    IdAdress = 3
                },
                new Student
                {
                    Id = 2,
                    Name = "Ignacio",
                    Lastname = "Vargas",
                    Birthday = new DateTime(1999,5,21),
                    Cellphone = "65465465",
                    Email = "Ginacio@gmail.com",
                    IdCareer = 2,
                    IdAdress = 1
                },
                new Student
                {
                    Id = 3,
                    Name = "Camila",
                    Lastname = "Claros",
                    Birthday = new DateTime(1998,6,11),
                    Cellphone = "654665",
                    Email = "cc@gmail.com",
                    IdCareer = 1,
                    IdAdress = 2
                },
                new Student
                {
                    Id = 4,
                    Name = "Mario",
                    Lastname = "Cordova",
                    Birthday = new DateTime(1997,9,23),
                    Cellphone = "78954613",
                    Email = "mc@gmail.com",
                    IdCareer = 3,
                    IdAdress = 1
                }
            };
        }

        public static List<Adress> ReadAdress()
        {
            return new List<Adress>
            {
                new Adress
                {
                    Id = 1,
                    Zone = "Sacaba",
                    Street = "Villazon",
                    Line1 = "",
                    Line2 = ""
                },
                new Adress
                {
                    Id = 2,
                    Zone = "Quillacollo",
                    Street = "Blanco Galindo",
                    Line1 = "",
                    Line2 = ""
                },
                new Adress
                {
                    Id = 3,
                    Zone = "Sarco",
                    Street = "Villazon",
                    Line1 = "",
                    Line2 = ""
                }
            };
        }

        public static List<Career> ReadCareers()
        {
            return new List<Career>
            {
                new Career
                {
                    Id = 1,
                    Code = "SIS",
                    Name = "Ing. Sistemas",
                    Director = "Ind. Eddy Perez"
                },
                new Career
                {
                    Id = 2,
                    Code = "ADM",
                    Name = "Administracion de Empresas",
                    Director = "Ind. Montiel"
                },
                new Career
                {
                    Id = 3,
                    Code = "ARQ",
                    Name = "Arquitectura",
                    Director = "Ind. Eddy Perez"
                },
            };
        }
        static void Main(string[] args)
        {
            var students = ReadStudents();
            var careers = ReadCareers();
            var adress = ReadAdress();
            List<string> Zones = new List<string>
            {
                "Sarco",
                "Quillacollo"
            };
            /*int quantity = 0;
            foreach (var student in students)
            {
                if (student.Birthday.Year.Equals(1999))
                {
                    quantity++;
                    Console.WriteLine(student);
                }
            }
            Console.WriteLine("cantidad: {0}", quantity);*/

            // Extention Methods
            //Console.WriteLine(students.Count(s => s.Birthday.Year.Equals(1999)));

            // Using Linq
            /*var filtered = (from s in students
                            join c in careers on s.IdCareer equals c.Id
                            join a in adress on s.IdAdress equals a.Id
                            where (s.Birthday.AddYears(20) - DateTime.Now).TotalDays <= 0
                            select new
                            {
                                Career = c.Name,
                                Adress = a.Zone,
                                Complete = s.ToString()
                            });*/

            /*var filtered = (from s in students
                            join c in careers on s.IdCareer equals c.Id
                            join a in adress on s.IdAdress equals a.Id
                            join z in Zones on a.Zone equals z
                            where z.Equals(a.Zone)
                            select new
                            {
                                Career = c.Name,
                                Adress = a.Zone,
                                Complete = s.ToString()
                            });
            // Extention methods
            var filtered2 = students
                .Join(careers,
                    s => s.IdCareer,
                    c => c.Id,
                    (s, c) => new
                    {
                        s.Birthday,
                        Complete = s.ToString(),
                        Career = c.Name
                    })
                .Where(s => (s.Birthday.AddYears(20) - DateTime.Now).TotalDays <= 0);*/

            /*var studentsPerCareer =
                (from career in careers
                 join student in students on career.Id equals student.IdCareer into studentNumber
                 select new
                 {
                     career = career.Name,
                     studentNumber = studentNumber.Count()
                 });
            var studensPerCareer2 = careers
               .GroupJoin(students,
                   career => career.Id,
                   student => student.IdCareer,
                   (career, studentNumber) => new
                   {
                       career = career.Name,
                       studentNumber = studentNumber.Count()
                   });*/

            var countOnCareers =
                (from career in careers
                 join student in students on career.Id equals student.IdCareer into studentNumber
                 where studentNumber.Count() > 30
                 select new
                 {
                     career = career.Name,
                     studentNumber = studentNumber.Count()
                 });
            // exthention methods
            var countOnCareers2 = careers
               .GroupJoin(students,
                   career => career.Id,
                   student => student.IdCareer,
                   (career, studentNumber) => new
                   {
                       career = career.Name,
                       studentNumber = studentNumber.Count()
                   })
                .Where(s => s.studentNumber > 30);

            var AddressTop =
                (from address in adress
                 join student in students on address.Id equals student.IdAdress into studentNumber
                 orderby studentNumber.Count() descending
                 where studentNumber.Count() < 11
                 select new
                 {
                     addres = address.Zone,
                     studentNumber = studentNumber.Count()
                 });
            var AddressTop2 = adress
               .GroupJoin(students,
                   adres => adres.Id,
                   student => student.IdAdress,
                   (adres, studentNumber) => new
                   {
                       address = adres.Zone,
                       studentNumber = studentNumber.Count()
                   });
                //.OrderBy(studentNumber);
            foreach (var address in AddressTop)
            {
                Console.WriteLine("{0}, cantidad: ({1})", address.addres, address.studentNumber);
            }
            Console.ReadKey();
        }
    }
}
