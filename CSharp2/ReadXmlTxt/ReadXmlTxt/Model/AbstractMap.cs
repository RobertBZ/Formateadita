using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReadXmlTxt.Model
{
    public abstract class AbstractMap
    {
        public string Root { get; protected set; }
        public abstract IModel ToModel(string str);
        public abstract IModel GetFormatXml(XElement element);
        public string KeyGroup { get; set; }
        public string KeySingle { get; set; }
    }
}
