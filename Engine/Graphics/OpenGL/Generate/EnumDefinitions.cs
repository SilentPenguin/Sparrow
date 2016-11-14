using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Sparrow.Graphics.OpenGL.Generate
{
    public class Enums
    {
        public Enums(IEnumerable<XElement> enums)
        {
            this.enums = enums.Descendants("enum")
                .Where(e => e.Attribute("api") == null || e.Attribute("api").Value == "gl")
                .Select(e => new Enum(e));
        }

        public IEnumerable<Enum> enums;
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("namespace Sparrow.Graphics.OpenGL");
            sb.AppendLine("{");
            sb.AppendLine("    public static partial class Raw");
            sb.AppendLine("    {");

            foreach(var @enum in enums)
                sb.AppendLine(@enum.ToString());

            sb.AppendLine("    }");
            sb.AppendLine("}");

            return sb.ToString();
        }
    }

    public class Enum
    {
        public Enum(XElement @enum)
        {
            type = @enum.Attribute("type") == null || @enum.Attribute("type").Value == "u" ? "uint" : "ulong";
            name = @enum.Attribute("name").Value;
            value = @enum.Attribute("value").Value;
            if (value.StartsWith("-")) value = String.Format("0x{0:X}", Int32.Parse(value));
        }

        public string type;
        public string name;
        public string value;

        public override string ToString()
        {
            return String.Format("        public const {0} {1} = {2};", type, name, value);
        }
    }
}