namespace BreakingChangeManager.Core.Rules
{
    public interface IRule
    {
        IRuleDefinition Definition { get; }
        EvaluationOutcome Evaluate();
    }
}