using System;

namespace EstacionamentoForms.Configurations.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class IdentifierAttribute : Attribute
    {
        public string Identifier { get; }

        public IdentifierAttribute(string identifier)
        {
            Identifier = identifier;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class IdentifierProperty : Attribute
    {
        public string Identifier { get; }

        public IdentifierProperty(string identifier)
        {
            Identifier = identifier;
        }
    }
}

