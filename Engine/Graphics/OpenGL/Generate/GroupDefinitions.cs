using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
namespace Sparrow.Graphics.OpenGL.Generate
{
    public class Groups
    {
        public Groups(IEnumerable<XElement> groups)
        {
            this.groups = groups.Descendants("group").Select(e => new Group(e));
        }

        public IEnumerable<Group> groups;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("namespace Sparrow.Graphics.OpenGL");
            sb.AppendLine("{");

            foreach(var group in groups)
                sb.Append(group);

            sb.AppendLine("}");

            return sb.ToString();
        }
    }

    public class Group
    {

        public Group(XElement group)
        {
            name = group.Attribute("name").Value;
            values = @group.Descendants("enum").Select(e => new Property(e));
        }

        public string name;
        public IEnumerable<Property> values;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(String.Format("    public enum {0} : uint", name));
            sb.AppendLine("        {");
            foreach(var value in values)
            {
                sb.AppendLine("        " + value.ToString() + ",");
            }
            sb.AppendLine("        }");
            return sb.ToString();
        }
    }

    public class Property
    {
        public Property(XElement @enum)
        {
            name = @enum.Attribute("name").Value;
        }

        public string name;

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

            return String.Format("{0} = Raw.{1}", sanitisedName, name);
        }
    }
}