using System.Xml.Linq;

namespace Entity
{
    public abstract class AbstractMap
    {
        // Obtendra las rutas de archivos al heredarse la clase
        public string Root { get; protected set; }
        // Carga valores de los archivos TXT en los modelos
        public abstract IModel ToModel(string str);
        // Carga valores de los archivos XML en los modelos
        public abstract IModel GetFormatXml(XElement element);

        // ****************************
        // Variables de uso en XDocument para lograr la lectura de archivos XML("FORZADA")
        public string KeyGroup { get; set; }
        public string KeySingle { get; set; }
    }
}
