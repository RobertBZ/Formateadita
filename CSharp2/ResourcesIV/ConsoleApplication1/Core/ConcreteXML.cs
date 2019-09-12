using System;
using Model;
using Model.MapXML;
using System.Collections.Generic;

namespace Core
{
    public class ConcreteXML : AbstractRegistry
    {
        private Serializer<Data> Serializer { get; set; }
        public ConcreteXML()
        {
            Serializer = new Serializer<Data>(@"Resources\XML_Files\Data.xml");
        }
        public override IEnumerable<Career> GetCareers()
        {
            return Serializer.ToObject().Careers;
        }

        public override IEnumerable<Professor> GetProfessors()
        {
            return Serializer.ToObject().Professors;
        }
        
        public override IEnumerable<Student> GetStudents()
        {
            
            return Serializer.ToObject().Students;
        }
    }
}
