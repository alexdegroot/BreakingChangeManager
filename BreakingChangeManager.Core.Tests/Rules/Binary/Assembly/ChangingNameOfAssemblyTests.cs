using System.Collections.Generic;
using BreakingChangeManager.Core.Rules;
using BreakingChangeManager.Core.Rules.Binary.Assembly;
using BreakingChangeManager.Core.Signatures;
using Xunit;

namespace BreakingChangeManager.Core.Tests.Rules.Binary.Assembly
{
    public class ChangingNameOfAssemblyTests
    {
        [Fact]
        public void GivenTwoAssemblies_WhenChangingTheNameOfOne_BinaryChangeIsDetected()
        {
            var assemblies = new List<Signatures.Assembly>
            {
                new Signatures.Assembly("NameOne"),
                new Signatures.Assembly("NameTwo")
            };
            var context = new ComparisonContext("", assemblies);
            var currentAssembly = new Signatures.Assembly("Name1");

            var rule = new ChangingNameOfAssembly(currentAssembly, context);
            var result = rule.Evaluate();

            Assert.Equal(CompatibilityType.Binary, result.Definition.Type);
            Assert.Equal(EvaluationResult.DisallowedChange, result.Result);
        }
    }
}
