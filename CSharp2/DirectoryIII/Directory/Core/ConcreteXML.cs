using System;
using Entity;
using Entity.MapXML;
using System.Collections.Generic;

namespace Core
{
    public class ConcreteXML : AbstractRegistry
    {
        private Serializer<Data> Serializer { get; set; }
        public ConcreteXML()
        {
            Serializer = 
                new Serializer<Data>(@"C:\Users\labo2\Documents\visual studio 2015\Projects\Directory\Directory\Resources\XML_Files\Data.xml");
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
