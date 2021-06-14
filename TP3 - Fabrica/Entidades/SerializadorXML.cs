using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class SerializadorXML<T>
    {
        private readonly string path;

        public SerializadorXML(string path)
        {
            this.path = path;
        }

        /// <summary>
        /// Guarda el XML
        /// </summary>
        /// <param name="objeto"></param>
        public void Guardar(T objeto)
        {
            using (XmlTextWriter xmlTextWriter = new XmlTextWriter(path, Encoding.UTF8))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(xmlTextWriter, serializer);
            }
        }

        /// <summary>
        /// Deserializa el XML
        /// </summary>
        /// <returns>Objeto generico</returns>
        public T Leer()
        {
            using (XmlTextReader xmlTextReader = new XmlTextReader(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                return (T) serializer.Deserialize(xmlTextReader);
            }
        }
    }
}
