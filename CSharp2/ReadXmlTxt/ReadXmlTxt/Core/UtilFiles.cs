using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ReadXmlTxt.Model
{
    public class UtilFiles<T> where T : IModel, new()
    {
        private AbstractMap Map { get; set; }
        private string Root { get; set; }
        private T Current { get; set; }
        public UtilFiles(AbstractMap map)
        {
            Current = new T();
            Map = map;
            Root = map.Root;
        }
        public List<T> GetTxt()
        {
            List<T> Content = new List<T>();
            StreamReader FileTxt = new StreamReader(Root);
            string str = FileTxt.ReadLine();
            while (str != null)
            {
                Current = (T)Map.ToModel(str);
                Content.Add(Current);
                str = FileTxt.ReadLine();
            }
            FileTxt.Close();
            return Content;
        }
        public List<T> GetXml()
        {
            List<T> Content = new List<T>();
            XDocument document = XDocument.Load(Root);

            var OpenDocument = from doc in document.Descendants(Map.KeyGroup) select doc;

            foreach (XElement element in OpenDocument.Elements(Map.KeySingle))
            {
                Current = (T)Map.GetFormatXml(element);
                Content.Add(Current);
            }
            return Content;
        }
    }
}
