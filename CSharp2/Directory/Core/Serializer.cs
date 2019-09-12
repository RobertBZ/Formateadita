using Entity;
using System.Xml;
using System.Xml.Serialization;

namespace Core
{
    public class Serializer<T> where T : IModel, new()
    {
        public string Root { get; set; }
        public Serializer(string root)
        {
            Root = root;
        }
        public void ToXml(T person)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            // Nos permite abrir temporalmente un archivo para editarloo leerlo y luego cerrarlo
            using (var writer = XmlWriter.Create(Root))
            {
                serializer.Serialize(writer, person);
            }
        }

        public T ToObject()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            T result = new T();
            using (var reader = XmlReader.Create(Root))
            {
                result = (T)serializer.Deserialize(reader);
            }
            return result;
        }
    }
}
