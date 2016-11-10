/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
namespace Sparrow.Graphics.Generate
{

    public class Groups
    {
        public Groups(IEnumerable<XElement> groups, IEnumerable<XElement> enums)
        {
            this.groups = groups.Descendants("group").Select(e => new Group(e, enums));
        }

        public IEnumerable<Group> groups;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("namespace Sparrow.Graphics.Raw");
            sb.AppendLine("{");
            sb.AppendLine("    public static partial class Gl");
            sb.AppendLine("    {");

            foreach(var group in groups)
                sb.Append(group);

            sb.AppendLine("    }");
            sb.AppendLine("}");

            return sb.ToString();
        }
    }

    public class Group
    {

        public Group(XElement group, IEnumerable<XElement> enums)
        {
            name = group.Attribute("name").Value;
            values = @group.Descendants("enum").Select(e => new Enumeration(e, enums));
        }

        public string name;
        public IEnumerable<Enumeration> values;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(String.Format("        public enum {0} : uint", name));
            sb.AppendLine("        {");
            foreach(var value in values)
            {
                sb.AppendLine("            " + value.ToString() + ",");
            }
            sb.AppendLine("        }");
            return sb.ToString();
        }
    }

    public class Enumeration
    {
        public Enumeration(XElement @enum, IEnumerable<XElement> enums)
        {
            name = @enum.Attribute("name").Value;

            var element = enums.Descendants("enum")
                .SingleOrDefault(e => e.Attribute("name").Value == name);

            if (element == null) return;

            value = element.Attribute("value").Value;
        }

        public string name;
        public string value;

        public override string ToString()
        {

            var sanitisedName = name.Substring(3)
                .Replace("0", "_Zero_")
                .Replace("1", "_One_")
                .Replace("2", "_Two_")
                .Replace("3", "_Three_")
                .Replace("4", "_Four_")
                .Replace("5", "_Five_")
                .Replace("6", "_Six_")
                .Replace("7", "_Seven_")
                .Replace("8", "_Eight_")
                .Replace("9", "_Nine_");
                            
            sanitisedName = String.Join("", 
                            sanitisedName.Split("_".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                            .Select(s => s[0] + s.Substring(1).ToLower()));

            if (String.IsNullOrWhiteSpace(value))
                return sanitisedName; 
            return String.Format("{0} = {1}", sanitisedName, value);
        }
    }
}
*/