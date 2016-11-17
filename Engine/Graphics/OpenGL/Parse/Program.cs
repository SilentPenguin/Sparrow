using System.Linq;
using System.IO;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Sparrow.Graphics.OpenGL.Parse
{
    public class Program
    {

        static string xmlPath = @"Engine/Graphics/OpenGL/Parse/gl.xml";
        static string codePath = @"Engine/Graphics/OpenGL/Parse/gl.cs";

        public static void Main(string[] args)
        {
            ConstructRegistry();
            //WriteCode();
        }

        public static void ConstructRegistry()
        {
            var groups = XElement.Load(@"Engine/Graphics/OpenGL/Parse/Registry/Mapping.xml").Descendants("group");
            var commands = XElement.Load(@"Engine/Graphics/OpenGL/Registry/Api/gl.xml").Elements("commands").Elements("command");
            
            foreach(var group in groups)
            {
                var methods = group.Descendants("method").Select(e => new Regex("^gl" + e.Value + "$"));
                var doc = new XDocument();
                var api = new Api();
                doc.Add(api);
                api.protos = methods.SelectMany(m =>
                    commands
                        .Where(e => m.IsMatch(e.Element("proto").Element("name").Value))
                        .Select( e => new Proto(){
                            name = m.Match(e.Element("proto").Element("name").Value).Groups[1].Value,
                            entry = new Entry () { callsite = e.Element("proto").Element("name").Value },
                            @params = e.Descendants("param").Select(p => new Param() { name = p.Element("name").Value, type = p.Element("ptype")?.Value ?? "GLvoid" })
                        })
                );

                using (var stream = new StreamWriter(File.Create(@"Engine/Graphics/OpenGL/Parse/Registry/" + group.Attribute("name").Value + ".xml")))
                {
                    stream.Write(doc);
                }
            }
        }

        public static void WriteCode()
        {
            var root = XElement.Load(xmlPath);

            using (var stream = new StreamWriter(File.Create(codePath)))
                stream.Write(new OpenGlXml(root).ToCode());
        }
    }
}