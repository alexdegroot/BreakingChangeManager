namespace BreakingChangeManager.Core.Rules
{
    public class RuleDefinition : IRuleDefinition
    {
        public string Id { get; }
        public CompatibilityType Type { get; } 
        public string Description { get; }

        public RuleDefinition(string id, CompatibilityType type, string description)
        {
            Id = id;
            Type = type;
            Description = description;
        }
    }
}
