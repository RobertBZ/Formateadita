using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core
{
    public class UtilFiles<T> where T : IModel, new()
    {
        // ****** Variables de uso Interno
        // Inicia Instacia de AbstractMap
        private AbstractMap Map { get; set; }
        // Variable para ruta de archivo
        private string Root { get; set; }
        // Variable que obtiene una instancia del modelo
        private T Current { get; set; }
        // ******************************
        public UtilFiles(AbstractMap map)
        {
            Current = new T();
            Map = map;
            Root = map.Root;
        }

        // Lista que obtendra todos los datos cualquier archivo "TXT"
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
        // Lista que obtendra todos los datos cualquier archivo "XML"
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
