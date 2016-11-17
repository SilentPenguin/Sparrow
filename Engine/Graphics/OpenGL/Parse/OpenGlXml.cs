using System;
using System.Text;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;

namespace Sparrow.Graphics.OpenGL.Parse
{
    public class OpenGlXml
    {
        public OpenGlXml(XElement element)
        {
            consts = element.Elements("const").Select(e => new ConstXml(e));
            enums = element.Elements("enum").Select(e => new EnumXml(e));
            protos = element.Elements("proto").Select(e => new ProtoXml(e));
        }

        public IEnumerable<ConstXml> consts;
        public IEnumerable<EnumXml> enums;
        public IEnumerable<ProtoXml> protos;

        public string ToCode()
        {
            var sb = new StringBuilder();
            sb.AppendLine("using System.Runtime.InteropServices;");
            sb.AppendLine("namespace Sparrow.Graphics.OpenGL");
            sb.AppendLine("{");
            sb.AppendLine("    public class gl");
            sb.AppendLine("    {");
            sb.AppendLine("        private const string DllName = \"OpenGL\";");

            foreach(var @const in consts)
            {
                sb.AppendLine("        public const uint " + @const.ToCode() + ";");
            }
            foreach(var @enum in enums)
            {
                sb.AppendLine(@enum.ToCode());
            }
            foreach(var proto in protos)
            {
                sb.AppendLine(proto.ToCode());
            }
            sb.AppendLine("    }");
            sb.AppendLine("}");
            return sb.ToString();
        }
    }

    public class EnumXml
    {
        public EnumXml(XElement element)
        {
            name = element.Attribute("name").Value;
            consts = element.Descendants("const").Select(e => new ConstXml(e));
        }

        public string name;
        public IEnumerable<ConstXml> consts;

        public string ToCode()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("        public enum {0} : uint", name));
            sb.AppendLine("        {");
            foreach(var @const in consts)
            {
                sb.AppendLine("            " + @const.ToCode() + ",");
            }
            sb.AppendLine("        }");
            return sb.ToString();
        }
    }

    public class ConstXml
    {
        public ConstXml(XElement element)
        {
            name = element.Attribute("name").Value;
            value = element.Attribute("value").Value;
        }

        public string name;
        // public string rawname;
        public string value;

        public string ToCode()
        {
            return string.Format("{0} = {1}", name, value);
        }
    }

    public class ProtoXml
    {
        public ProtoXml(XElement element)
        {
            name = element.Attribute("name")?.Value;
            entries = element.Descendants("entry").Select(e => new EntryXml(e));
            @params = element.Descendants("param").Select(e => new ParamXml(e));
            returns = element.Descendants("return").Attributes("type").SingleOrDefault()?.Value ?? "void";
        }

        public IEnumerable<EntryXml> entries;
        public IEnumerable<ParamXml> @params;
        public string returns;
        public string name;

        public string ToCode()
        {
            var sb = new StringBuilder();
            foreach(var entry in entries)
            {
                var paramstring = string.Join(", ", @params.Where(p => string.IsNullOrWhiteSpace(p.entry) || p.entry.Split(' ').Contains(entry.entrypoint)).Select(p => p.type + " " + p.name));
                sb.AppendLine(string.Format("        [DllImport(DllName, EntryPoint=\"gl{0}\")]", entry.entrypoint));
                sb.AppendLine(string.Format("        public static extern {0} {1} ({2});", returns, entry.name ?? name, paramstring));
            }
            return sb.ToString();
        }
    }

    public class EntryXml
    {
        public EntryXml(XElement element)
        {
            name = element.Attribute("name")?.Value; 
            entrypoint = element.Value;
        }

        public string name;
        public string entrypoint;
    }

    public class ParamXml
    {
        public ParamXml(XElement element)
        {
            type = element.Attribute("type").Value;
            name = element.Attribute("name").Value;
            entry = element.Attribute("entry")?.Value;
        }

        public string type;
        public string name;
        public string entry;
    }
}