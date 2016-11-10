/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Sparrow.Graphics.Generate
{

    public class Features
    {
        public Features(IEnumerable<XElement> features, IEnumerable<XElement> commands)
        {
            this.features = features.Select(e => new Feature(e, commands));
        }

        public IEnumerable<Feature> features;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Runtime.InteropServices;");
            sb.AppendLine("namespace Sparrow.Graphics.Raw");
            sb.AppendLine("{");
            sb.AppendLine("    public static partial class Gl");
            sb.AppendLine("    {");

            foreach(var feature in features)
                sb.Append(feature);

            sb.AppendLine("    }");
            sb.AppendLine("}");
            return sb.ToString();
        }
    }

    public class Feature
    {
        public Feature(XElement feature, IEnumerable<XElement> commands)
        {
            version = feature.Attribute("number").Value;
            this.commands = feature.Descendants("command").Select(e => new Command(e, commands));
        }

        public string version {get; set;}
        public IEnumerable<Command> commands;

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach(var command in commands)
                sb.Append(command);
            return sb.ToString();
        }
    }

    public class Command
    {
        public Command(XElement command, IEnumerable<XElement> commands)
        {
            name = command.Attribute("name").Value;
            arguments = commands.Descendants("command")
                .Single(e => e.Element("proto").Element("name").Value == name)
                .Descendants("param").Select(e => new Argument(e));
        }

        public string name;
        public IEnumerable<Argument> arguments;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(String.Format("        [DllImport(DllName, EntryPoint = \"{0}\")]", name));
            sb.AppendLine(String.Format("        public static extern void {0} ({1});", name.Substring(2), String.Join(", ", arguments)));
            return sb.ToString();
        }
    }

    public class Argument
    {
        public Argument(XElement argument)
        {
            var ptype = argument.Descendants("ptype").SingleOrDefault();

            name = argument.Descendants("name").Single().Value;
            type = ptype != null ? ptype.Value : "IntPtr";
            group = argument.Attribute("group") != null ? argument.Attribute("group").Value : "uint";
        }

        public string name;
        public string type;
        public string group;

        public override string ToString()
        {
            var keywords = new String[]{
                "abstract", "as", "base", "bool", "break", "byte", "case",
                "catch", "char", "checked", "class", "const", "continue", 
                "decimal", "default", "delegate", "do", "double", "else", "enum", 
                "event", "explicit", "extern", "false", "finally", "fixed", 
                "float", "for", "foreach", "goto", "if", "implicit", "in", "int", 
                "interface", "internal", "is", "lock", "long", "namespace", 
                "new", "null", "object", "operator", "out", "override", 
                "params", "private", "protected", "public", "readonly", "ref", 
                "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", 
                "static", "string", "struct", "switch", "this", "throw", "true", 
                "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", 
                "using", "virtual", "void", "volatile", "while",
            };

            var sanitisedName = keywords.Contains(name) ? "@" + name : name;
            var sanitisedType = type == "GLenum" ? group : type.Substring(2);
            return String.Format("{0} {1}", sanitisedType, sanitisedName);
        }
    }
}
*/