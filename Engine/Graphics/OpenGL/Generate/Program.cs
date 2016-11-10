using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Sparrow.Graphics.OpenGL.Generate
{
    public class Program
    {

        static string xmlPath = @"Engine/Graphics/OpenGL/Registry/Api/gl.xml";
        static string commandPath = @"Engine/Graphics/OpenGL/Raw/Commands.cs";
        static string enumPath = @"Engine/Graphics/OpenGL/Raw/Enums.cs";

        public static void Main(string[] args)
        {
            XElement registry = XElement.Load(xmlPath, LoadOptions.PreserveWhitespace);

            var commands = registry.Descendants("commands");
            var enums = registry.Descendants("enums");

            using (var stream = new StreamWriter(File.Create(commandPath)))
                stream.Write(new Commands(commands));

            using (var stream = new StreamWriter(File.Create(enumPath)))
                stream.Write(new Enums(enums));

            return;
        }
    }
}