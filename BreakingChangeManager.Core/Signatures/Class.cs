using System;
using System.Collections.Generic;

namespace BreakingChangeManager.Core.Signatures
{
    public class Class
    {
        public string Name { get; }
        public IEnumerable<Attribute> Attributes { get; }

        public Class(string name, IEnumerable<Attribute> attributes, IEnumerable<Field> fields)
        {
            Name = name;
            Attributes = attributes;
        }
    }
}
