using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ChatPluginxD
{
    public class Helper
    {
        public static void Save<T>(string file, T instance)
        {
            var ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            var serializer = new XmlSerializer(typeof(T));
            using (var writer = new StreamWriter(Path.Combine(Core.ProfilesDirectory, file)))
            {
                using (var xmlWriter = XmlWriter.Create(writer, new XmlWriterSettings { OmitXmlDeclaration = true, Indent = true, IndentChars = "\t" }))
                {
                    serializer.Serialize(xmlWriter, instance, ns);
                }
            }
        }
        //Never used
        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        public static T Load<T>(string file)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var reader = XmlReader.Create(Path.Combine(Core.ProfilesDirectory, file)))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}
