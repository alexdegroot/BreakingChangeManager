﻿using System.Collections.Generic;
using System.Linq;

namespace BreakingChangeManager.Core.Signatures
{
    public class Assembly
    {
        public Assembly(string name) : this(name, "", Enumerable.Empty<Namespace>()) { }

        public Assembly(string name, string publicKey, IEnumerable<Namespace> namespaces)
        {
            Name = name;
            PublicKey = publicKey;
            Namespaces = namespaces;
        }

        public string Name { get; }
        public string PublicKey { get; }
        public IEnumerable<Namespace> Namespaces { get; }
    }
}
