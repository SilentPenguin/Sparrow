using System.Linq;
using System.IO;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Sparrow.Graphics.OpenGL.Parse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OutputXmlMapping();
        }

        public static void OutputXmlMapping()
        {
            var groups = XElement.Load(@"Sparrow.Graphics.OpenGL.Parse/Registry/Mapping/Mapping.xml").Descendants("group");
            var commands = XElement.Load(@"Sparrow.Graphics.OpenGL.Parse/Registry/Api/gl.xml").Elements("commands").Elements("command");
            
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

                using (var stream = new StreamWriter(File.Create(@"Sparrow.Graphics.OpenGL.Parse/Registry/Mapping/" + group.Attribute("name").Value + ".xml")))
                {
                    stream.Write(doc);
                }
            }
        }

        public static void OutputCodeMapping()
        {}
    }
}
