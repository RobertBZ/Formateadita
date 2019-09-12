﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ReadXmlTxt.Model.MapXML
{
    public class StudentMapXml : AbstractMap
    {
        public StudentMapXml()
        {
            KeyGroup = "Students";
            KeySingle = "Student";
            Root = @"C:\Users\Robert\Desktop\USIP\CSharp2\ReadXmlTxt\ReadXmlTxt\Resources\XML_Files\Estudiantes.xml";
        }
        public override IModel ToModel(string str)
        {
            throw new NotImplementedException();
        }

        public override IModel GetFormatXml(XElement element)
        {
            return new Student
            {
                Id = int.Parse(element.Attribute("id").Value),
                Name = element.Element("Name").Value,
                Lastname = element.Element("Lastname").Value,
                Age = int.Parse(element.Element("Age").Value),
                CareerCode = element.Element("CareerCode").Value
            };
        }
    }
}