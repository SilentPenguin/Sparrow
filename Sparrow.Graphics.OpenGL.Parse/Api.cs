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
        get { return new Return(Elements("returns").SingleOrDefault()); }
        set {
            Elements("returns").Remove();
            if (value.type != "void") Add(value);
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

    public string name
    {
        get { return Attribute("name").Value; }
        set { SetAttributeValue("name", value); }
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