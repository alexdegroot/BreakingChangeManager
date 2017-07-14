using System;
using System.Linq;
using BreakingChangeManager.Core.Signatures;

namespace BreakingChangeManager.Core.Rules.Binary.Assembly
{
    public class ChangingNameOfAssembly : IRule
    {
        private Signatures.Assembly Current { get; }
        public ComparisonContext ComparisonContext { get; }

        public ChangingNameOfAssembly(Signatures.Assembly current, ComparisonContext comparisonContext)
        {
            Current = current;
            ComparisonContext = comparisonContext;
        }

        public IRuleDefinition Definition => new RuleDefinition("AS01", CompatibilityType.Binary, "Changing the name of an assembly");

        public EvaluationOutcome Evaluate()
        {
            var match = ComparisonContext.Assemblies.Any(a => a.Name.Equals(Current.Name, StringComparison.InvariantCultureIgnoreCase));
            var ruleResult = match ? EvaluationResult.NoChange : EvaluationResult.DisallowedChange;
            return new EvaluationOutcome(Definition, ruleResult);
        }
    }
}
