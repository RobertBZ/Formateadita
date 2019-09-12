using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Serialization
{
    public class Serializer<T> where T: IModel, new()
    {
        public void ToXml(T person)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            // Nos permite abrir temporalmente un archivo para editarloo leerlo y luego cerrarlo
            using (var writer = XmlWriter.Create(person.Root()))
            {
                serializer.Serialize(writer, person);
            }
        }

        public T ToObject()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            T result = new T();
            using (var reader = XmlReader.Create(result.Root()))
            {
                result = (T)serializer.Deserialize(reader);
            }
            return result;
        }
    }
}
