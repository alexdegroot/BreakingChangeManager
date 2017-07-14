namespace BreakingChangeManager.Core.Rules
{
    public class EvaluationOutcome
    {
        public IRuleDefinition Definition { get; }
        public EvaluationResult Result { get; }

        public EvaluationOutcome(IRuleDefinition definition, EvaluationResult result)
        {
            Definition = definition;
            Result = result;
        }
    }
}
