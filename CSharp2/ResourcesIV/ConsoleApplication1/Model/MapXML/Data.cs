﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace Model.MapXML
{
    [XmlRoot("Data")]
    public class Data : IModel
    {
        [XmlIgnore]
        public int Id { get; }

        public List<Career> Careers { get; set; }
        public List<Professor> Professors { get; set; }

        [XmlArray("Students")]
        [XmlArrayItem("Student")]
        public List<Student> Students { get; set; }
    }
}