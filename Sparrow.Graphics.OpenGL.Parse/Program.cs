using System.Linq;
using System.IO;
using System.Xml.Linq;
using System.Text.RegularExpressions;

using Syntax = Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using Microsoft.CodeAnalysis.Formatting;
using Microsoft.CodeAnalysis;

namespace Sparrow.Graphics.OpenGL.Parse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OutputXmlMapping();
            OutputCodeMapping();
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
                    .Select( e => new Proto() {
                        @return = new Return { type = e.Element("proto").Element("ptype")?.Value ?? "GLvoid" }, 
                        name = m.Match(e.Element("proto").Element("name").Value).Groups[1].Value,
                        entry = new Entry () { callsite = e.Element("proto").Element("name").Value },
                        @params = e.Descendants("param").Select(p => new Param() {
                            name = p.Element("name").Value,
                            type = (p.Element("ptype")?.Value ?? "GLvoid")
                                + new string(p.Value.Where(c => c == '*').ToArray())
                        })
                    })
                );

                using (var stream = new StreamWriter(File.Create(@"Sparrow.Graphics.OpenGL.Parse/Registry/Mapping/" + group.Attribute("name").Value + ".xml")))
                {
                    stream.Write(doc);
                }
            }
        }

        public static void OutputCodeMapping()
        {
            var groups = XElement.Load(@"Sparrow.Graphics.OpenGL.Parse/Registry/Mapping/Mapping.xml").Descendants("group");
            foreach(var group in groups)
            {
                var root = XDocument.Load(@"Sparrow.Graphics.OpenGL.Parse/Registry/Mapping/" + group.Attribute("name").Value + ".xml").Root;
                var api = new Api(root);

                var @using = Syntax.UsingDirective(Syntax.ParseName("System.Runtime.InteropServices"));
                var cls = Syntax.ClassDeclaration("Gl")
                    .AddModifiers(Syntax.ParseTokens("public static partial").ToArray());

                foreach(var proto in api.protos)
                {
                    var rt = Syntax.ParseTypeName(proto.@return.type);
                    var sl = Syntax.SeparatedList(
                        proto.@params.Select(p =>
                            Syntax.Parameter(Syntax.ParseToken(p.sanitizedName))
                            .WithType(Syntax.ParseTypeName(p.type))));
                    var pl = Syntax.ParameterList(Syntax.ParseToken("("), sl, Syntax.ParseToken(")"));
                    var aal = Syntax.ParseAttributeArgumentList("(DllName, EntryPoint=\"" + proto.entry.callsite + "\")");
                    var al = Syntax.AttributeList()
                        .AddAttributes(Syntax.Attribute(Syntax.ParseName("DllImport"), aal));

                    var md = Syntax.MethodDeclaration(rt, proto.name)
                        .WithModifiers(Syntax.TokenList(Syntax.ParseTokens("public static extern unsafe")))
                        .WithSemicolonToken(Syntax.ParseToken(";"))
                        .WithParameterList(pl)
                        .WithTrailingTrivia(Syntax.ParseTrailingTrivia("\n"))
                        .AddAttributeLists(al);

                    cls = cls.AddMembers(md);
                }

                var comp = Syntax.CompilationUnit()
                    .AddUsings(@using)
                    .AddMembers(cls);

                var cw = new AdhocWorkspace();
                var code = Formatter.Format(comp, cw);

                using (var stream = new StreamWriter(File.Create(@"Sparrow.Graphics.OpenGL/" + group.Attribute("name").Value + ".cs")))
                {
                    stream.Write(code);
                }
            }
        }
    }
}
