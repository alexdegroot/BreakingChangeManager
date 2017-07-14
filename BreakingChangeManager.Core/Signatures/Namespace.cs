using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace BreakingChangeManager.Core.Signatures
{
    public class Namespace
    {
        public Namespace(string path, IEnumerable<Interface> interfaces, IEnumerable<Class> classes, IEnumerable<Event> events)
        {
            Path = path;
            Interfaces = interfaces;
            Classes = classes;
            Events = events;
        }

        public string Path { get; }

        public IEnumerable<Interface> Interfaces { get; }

        public IEnumerable<Class> Classes { get; }

        public IEnumerable<Event> Events { get; }
    }
}
