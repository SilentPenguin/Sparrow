using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Sparrow.Graphics.OpenGL.Generate
{
    public class Commands
    {
        public Commands(IEnumerable<XElement> commands)
        {
            this.commands = commands.Descendants("command").Select(e => new Command(e));
        }

        public IEnumerable<Command> commands;
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Runtime.InteropServices;");
            sb.AppendLine("namespace Sparrow.Graphics.OpenGL");
            sb.AppendLine("{");
            sb.AppendLine("    public unsafe delegate void GLDEBUGPROC (uint source, uint type, uint id, uint severity, int length, char* message, void* userParam);");
            sb.AppendLine("    public static partial class Raw");
            sb.AppendLine("    {");

            foreach(var feature in commands)
                sb.Append(feature);

            sb.AppendLine("    }");
            sb.AppendLine("}");
            return sb.ToString();
        }
    }

    public class Command
    {
        public Command(XElement command)
        {
            name = command.Descendants("name").First().Value;
            arguments = command.Descendants("param").Select(e => new Argument(e));
        }

        public string name;
        public IEnumerable<Argument> arguments;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("        [DllImport(DllName)]");
            sb.AppendLine(String.Format("        public static extern unsafe void {0} ({1});", name, String.Join(", ", arguments)));
            return sb.ToString();
        }
    }

    public class Argument
    {
        public Argument(XElement argument)
        {
            var ptype = argument.Descendants("ptype").SingleOrDefault();

            name = argument.Descendants("name").Single().Value;
            type = ptype != null ? ptype.Value : "GLvoid";
            pointer = argument.Value.Contains("*");
            group = argument.Attribute("group") != null ? argument.Attribute("group").Value : "uint";
        }

        public bool pointer;
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

            var typemap = new Dictionary<string, string>
            {
                { "GLenum", "uint" },
                { "GLboolean", "bool" },
                { "GLbitfield", "uint" },
                { "GLbyte", "sbyte" },
                { "GLshort", "short" },
                { "GLint", "int" },
                { "GLclampx", "int" },
                { "GLubyte", "byte"},
                { "GLushort", "ushort" },
                { "GLuint", "uint" },
                { "GLsizei", "int" },
                { "GLfloat", "float" },
                { "GLclampf", "float" },
                { "GLdouble", "double" },
                { "GLclampd", "double" },
                { "GLeglImageOES", "void*" },
                { "GLchar", "char" },
                { "GLcharARB", "char" },
                { "GLhandleARB", "void*" },
                { "GLhalf", "short" },
                { "GLhalfARB", "short" },
                { "GLfixed", "int" },
                { "GLintptr", "int*" },
                { "GLintptrARB", "int*" },
                { "GLsizeiptr", "int*" },
                { "GLsizeiptrARB", "int*" },
                { "GLint64", "long" },
                { "GLuint64", "ulong" },
                { "GLint64EXT", "long" },
                { "GLuint64EXT", "ulong" },
                { "GLhalfNV", "ushort" },
                { "GLvdpauSurfaceNV", "int*" },
                { "GLsync", "void*" },
                { @"struct _cl_event", "void*" },
                { @"struct _cl_context", "void*" },
                { "GLDEBUGPROC", "GLDEBUGPROC" },
                { "GLDEBUGPROCARB", "GLDEBUGPROC" },
                { "GLDEBUGPROCKHR", "GLDEBUGPROC" },
                { "GLDEBUGPROCAMD", "GLDEBUGPROC" },
                { "GLvoid", "void" },
            };

            var sanitisedName = keywords.Contains(name) ? "@" + name : name;
            var sanitisedType = typemap[type];
            return String.Format(pointer ? "{0}* {1}" : "{0} {1}", sanitisedType, sanitisedName);
        }
    }
}