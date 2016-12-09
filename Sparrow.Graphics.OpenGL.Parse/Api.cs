using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;

public class Api : XElement
{
    public Api() : base("opengl") {}
    public Api(XElement e) : base(e) {}

    public IEnumerable<Proto> protos
    {
        get { return Elements("proto").Select(e => new Proto(e)); }
        set {
            Elements("proto").Remove();
            foreach(var e in value) Add(e);
        }
    }

    public IEnumerable<Const> consts
    {
        get { return Elements("const").Select(e => new Const(e)); }
        set {
            Elements("const").Remove();
            foreach(var e in value) Add(e);
        }
    }

    public IEnumerable<Enum> enums
    {
        get { return Elements("enum").Select(e => new Enum(e)); }
        set {
            Elements("enum").Remove();
            foreach(var e in value) Add(e);
        }
    }
}

public class Proto : XElement
{
    public Proto() : base("proto") {}
    public Proto(XElement e) : base(e) {}

    public string name
    {
        get { return Attribute("name").Value; }
        set { SetAttributeValue("name", value); }
    }

    public Entry entry
    {
        get { return new Entry(Elements("entry").SingleOrDefault()); }
        set {
            Elements("entry").Remove();
            Add(value);
        }
    }

    public IEnumerable<Param> @params
    {
        get { return Elements("param").Select(e => new Param(e)); }
        set {
            Elements("param").Remove();
            foreach(var e in value) Add(e);
        }
    }

    public Return @return
    {
        get {
            var e = Elements("returns").SingleOrDefault();
            return e== null ? new Return(){ type = "GLvoid" } : new Return(e);
        }
        set {
            Elements("returns").Remove();
            if (value.type != "GLvoid") Add(value);
        }
    }
}

public class Entry : XElement
{
    public Entry() : base("entry") {}
    public Entry(XElement e) : base(e) {}

    public string callsite
    {
        get { return Value; }
        set { Value = value; }
    }
}

public class Param : XElement
{
    public Param() : base("param") {}
    public Param(XElement e) : base(e) {}

    public static readonly string[] keywords = new string[]{
        "abstract", "as", "base", "bool",
        "break", "byte", "case", "catch",
        "char", "checked", "class", "const",
        "continue", "decimal", "default", "delegate",
        "do", "double", "else", "enum",
        "event", "explicit", "extern", "false",
        "finally", "fixed", "float", "for",
        "foreach", "goto", "if", "implicit",
        "in", "int", "interface",
        "internal", "is", "lock", "long",
        "namespace", "new", "null", "object",
        "operator", "out", "override",
        "params", "private", "protected", "public",
        "readonly", "ref", "return", "sbyte",
        "sealed", "short", "sizeof", "stackalloc",
        "static", "string", "struct", "switch",
        "this", "throw", "true", "try",
        "typeof", "uint", "ulong", "unchecked",
        "unsafe", "ushort", "using", "virtual",
        "void", "volatile", "while"
    };

    public static readonly Dictionary<string, string> typemap = new Dictionary<string, string>
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

    public string name
    {
        get { return Attribute("name").Value; }
        set { SetAttributeValue("name", value); }
    }

    public string sanitizedName
    {
        get { return keywords.Contains(name) ? ("@" + name) : name; }
    }

    public string sanitizedType
    {
        get {
            var rawType = type.Replace("*", "");
            return type.Replace(rawType, typemap[rawType]);
        }
    }

    public string type
    {
        get { return Attribute("type").Value; }
        set { SetAttributeValue("type", value); }
    }
}

public class Return : XElement
{
    public Return() : base("return") {}
    public Return(XElement e) : base(e) {}

    public string type

    {
        get { return Attribute("type")?.Value ?? "void"; }
        set { SetAttributeValue("type", value); }
    }

    public string sanitizedType
    {
        get {
            var rawType = type.Replace("*", "");
            return type.Replace(rawType, Param.typemap[rawType]);
        }
    }
}

public class Enum : XElement
{
    public Enum() : base("enum") {}
    public Enum(XElement e) : base(e) {}

    public IEnumerable<Const> consts
    {
        get { return Elements("const").Select(e => new Const(e)); }
        set {
            Elements("const").Remove();
            foreach(var e in value)
                Add(e);
        }
    }
}

public class Const : XElement
{
    public Const() : base("const") {}
    public Const(XElement e) : base(e) {}

    public string name
    {
        get { return Attribute("name").Value; }
        set { SetAttributeValue("name", value); }
    }
    public string value
    {
        get { return Attribute("value").Value; }
        set { SetAttributeValue("value", value); }
    }
}