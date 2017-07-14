namespace BreakingChangeManager.Core.Rules
{
    public interface IRuleDefinition
    {
        string Id { get; }
        CompatibilityType Type { get; }
        string Description { get; }
    }
}