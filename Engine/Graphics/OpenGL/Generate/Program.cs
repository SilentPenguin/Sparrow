using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Sparrow.Graphics.OpenGL.Generate
{
    public class Program
    {

        static string xmlPath = @"Engine/Graphics/OpenGL/Registry/Api/gl.xml";
        static string commandPath = @"Engine/Graphics/OpenGL/Commands.cs";
        static string enumPath = @"Engine/Graphics/OpenGL/Enums.cs";
        static string groupPath = @"Engine/Graphics/OpenGL/Groups.cs";

        public static void Main(string[] args)
        {
            XElement registry = XElement.Load(xmlPath, LoadOptions.PreserveWhitespace);

            var commands = registry.Descendants("commands");
            var enums = registry.Descendants("enums");
            var groups = registry.Descendants("groups");

            using (var stream = new StreamWriter(File.Create(commandPath)))
                stream.Write(new Commands(commands));

            using (var stream = new StreamWriter(File.Create(enumPath)))
                stream.Write(new Enums(enums));

            using (var stream = new StreamWriter(File.Create(groupPath)))
                stream.Write(new Groups(groups));

            return;
        }
    }
}