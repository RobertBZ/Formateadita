using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement xelement = XElement.Load(@"XmlFile\Employees.xml");
            IEnumerable<XElement> employees = xelement.Elements();

            // Lee el Archivo Xml en su propio formato
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
            Console.ReadKey();
            Console.Clear();
            // *****************************
            // Lee un los elementos Name y EmpId
            foreach (var employee in employees)
            {
                Console.WriteLine("{0} has Employee ID {1}",
                    employee.Element("Name").Value,
                    employee.Element("EmpId").Value);
            }
            Console.ReadKey();
            Console.Clear();
            // *****************************
            // Realiza consultas Al Xml de los empleados de sexo Femenino
            var name = from nm in xelement.Elements("Employee")
                       where (string)nm.Element("Sex") == "Female"
                       select nm;
            Console.WriteLine("Details of Female Employees:");
            foreach (XElement xEle in name)
                Console.WriteLine(xEle);

            Console.ReadKey();
            Console.Clear();
            //*******************************
            // Realiza consultas de los numeros de telefono del empleado con telefono casa
            var homePhone = from phoneno in xelement.Elements("Employee")
                            where (string)phoneno.Element("Phone").Attribute("Type") == "Home"
                            select phoneno;
            Console.WriteLine("List HomePhone Nos.");
            foreach (XElement xEle in homePhone)
            {
                Console.WriteLine(xEle.Element("Phone").Value);
            }

            Console.ReadKey();
            Console.Clear();
            //*******************************
            // Lista los codigos Zip de las direcciones
            IEnumerable<string> codes = from code in xelement.Elements("Employee")
                                        let zip = (string)code.Element("Address").Element("Zip")
                                        orderby zip
                                        select zip;
            Console.WriteLine("List and Sort all Zip Codes");

            foreach (string zp in codes)
            {
                Console.WriteLine(zp);
            }

            Console.ReadKey();
            Console.Clear();
            //********************************
            //Obtiene todas las referecias del employees
            XElement xElel = XElement.Load(@"XmlFile\Employees.xml");
            xElel.Add(new XElement("Employee",
            new XElement("EmpId", 5),
            new XElement("Name", "George"),
            new XElement("Sex", "Male"),
            new XElement("Phone", "423-555-4224", new XAttribute("Type", "Home")),
            new XElement("Phone", "424-555-0545", new XAttribute("Type", "Work")),
            new XElement("Address",
                new XElement("Street", "Fred Park, East Bay"),
                new XElement("City", "Acampo"),
                new XElement("State", "CA"),
                new XElement("Zip", "95220"),
                new XElement("Country", "USA"))));

            xElel.Save("..\\..\\Employees.xml");
            Console.WriteLine(xElel);
            Console.ReadKey();
        }
    }
}
