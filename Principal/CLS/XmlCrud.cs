using System.Text;
using System.Xml;

namespace Principal.CLS
{
    public class XmlCrud
    {
        // Creando el archivo xml
        public static void CreateXml(string txt)
        {
            //Usando identacion.
            var xmlWriter = new XmlTextWriter("connString.xml", Encoding.UTF8) {Formatting = Formatting.Indented};
            
            //Inicia el archivo XML
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteComment("Archivo XML de conexiones mysql");
            xmlWriter.WriteStartElement("Conexiones");
            xmlWriter.WriteElementString("Conexion", $"{txt}");
            // xmlWriter.WriteString("Cadena de Conexion");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
    }
}