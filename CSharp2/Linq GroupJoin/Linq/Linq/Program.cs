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
                    Birthday = new DateTime(1999, 5, 21),
                    Cellphone = "78954613",
                    Email = "ja@gmail.com",
                    IdAddress = 2,
                    IdCareer = 1
                },
                new Student
                {
                    Id = 2,
                    Name = "Ignacio",
                    Lastname = "Vargas",
                    Birthday = new DateTime(1999, 5, 20),
                    Cellphone = "75632149",
                    Email = "iv@gmail.com",
                    IdAddress = 4,
                    IdCareer = 2
                },
                new Student
                {
                    Id = 3,
                    Name = "Camila",
                    Lastname = "Claros",
                    Birthday = new DateTime(1998, 6, 11),
                    Cellphone = "68956564",
                    Email = "cc@gmail.com",
                    IdAddress = 3,
                    IdCareer = 1
                },
                new Student
                {
                    Id = 4,
                    Name = "Mario",
                    Lastname = "Cordova",
                    Birthday = new DateTime(1997, 9, 23),
                    Cellphone = "68665347",
                    Email = "mc@gmail.com",
                    IdAddress = 1,
                    IdCareer = 3
                },
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
                    Director = "Ing. Eddy Perez"
                },
                new Career
                {
                    Id = 2,
                    Code = "ADM",
                    Name = "Administracion de Empresas",
                    Director = "Ing. Bortier"
                },
                new Career
                {
                    Id = 3,
                    Code = "ARC",
                    Name = "Arquitectura",
                    Director = "Lic. Erick Peredo"
                }
            };
        }

        public static List<Address> ReadAddresses()
        {
            return new List<Address>
            {
                new Address
                {
                    Id = 1,
                    Zone = "Muyurina"
                },
                new Address
                {
                    Id = 2,
                    Zone = "Muyurina"
                },
                new Address
                {
                    Id = 3,
                    Zone = "Muyurina"
                },
                new Address
                {
                    Id = 4,
                    Zone = "Sarco"
                },
            };
        }


        static void Main(string[] args)
        {
            var students = ReadStudents();
            var careers = ReadCareers();
            var addresses = ReadAddresses();
            var zones = new List<string>();

            //Extension Methods
            //Console.WriteLine(students
            //  .Count(s => s.Birthday.Year.Equals(1999)));

            // Linq to SQL
            //var filtered = 
            //    (from s in students
            //     join c in careers on s.IdCareer equals c.Id                                 
            //     join a in addresses on s.IdAddress equals a.Id
            //     join z in zones on a.Street equals z
            //     where (s.Birthday.AddYears(20) - DateTime.Now).TotalDays <= 0
            //     select new
            //     {
            //        Career = c.Name,
            //        Complete = s.ToString()
            //     });

            //var filtered2 = students
            //    .Join(careers,
            //        s => s.IdCareer,
            //        c => c.Id,
            //        (s, c) => new
            //        {
            //            s.Birthday,
            //            Complete = s.ToString(),
            //            Career = c.Name
            //        })
            //    .Where(s => (s.Birthday.AddYears(20) - DateTime.Now).TotalDays <= 0);                


            //foreach (var item in filtered2)
            //{
            //    Console.WriteLine("{0} estudia {1}", item.Complete, item.Career);
            //}


            //var studentsPerCareer =
            //    (from career in careers
            //     join student in students on career.Id equals student.IdCareer into studentsNumber
            //     where studentsNumber.Count() > 30 
            //     select new
            //     {
            //         Career = career.Name,
            //         StudentsNumber = studentsNumber.Count()
            //     });

            //var studentsPerCareer2 = careers
            //    .GroupJoin(students,
            //        career => career.Id,
            //        student => student.IdCareer,
            //        (career, studentsNumber) => new
            //        {
            //            Career = career.Name,
            //            StudentsNumber = studentsNumber.Count()
            //        })
            //     .Where(s => s.StudentsNumber > 30);

            //foreach (var career in studentsPerCareer2)
            //{
            //    Console.WriteLine("{0} ({1})", 
            //        career.Career, 
            //        career.StudentsNumber);
            //}


            var top10Zones =
                (from zone in (from address in addresses
                               select address.Zone).Distinct()
                 join address in (from student in students
                                  join address in addresses on student.IdAddress equals address.Id
                                  select new
                                  {
                                      address.Zone,
                                      student.Id
                                  }) on zone equals address.Zone into studentPerZone
                 orderby studentPerZone.Count() descending
                 select new
                 {
                     Name = zone,
                     StudentPerZone = studentPerZone.Count()
                 }).Take(10);

            // Extention methods
            var top10Zones2 = addresses
                .GroupJoin(students,
                    addres => addres.Id,
                    student => student.IdAddress,
                    (addres, zonesNumber) => new
                    {
                        Zones = addres.Zone,
                        zonesNumber = zonesNumber.Count()
                    })
                 .OrderBy(s => zones.Count());


            foreach (var zone in top10Zones2)
            {
                Console.WriteLine("{0} ({1})", zone.Zones, zone.zonesNumber);
            }
                 
            
            Console.ReadKey();

        }
    }
}
