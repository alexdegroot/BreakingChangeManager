using System.Collections.Generic;

namespace BreakingChangeManager.Core.Signatures
{
    public class ComparisonContext
    {
        public string Name { get; }
        public IEnumerable<Assembly> Assemblies { get; }

        public ComparisonContext(string name, IEnumerable<Signatures.Assembly> assemblies)
        {
            Name = name;
            Assemblies = assemblies;
        }
    }
}
