using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Adapter
{
    class GeradorDeXml
    {
        public String GeraXml(object o)
        {
            XmlSerializer serializer = new XmlSerializer(o.GetType());
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, o);
            String xml = writer.ToString();

            return xml;
        }
    }
}
